using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ReportServer
{
    class ReportingServerExt : BoldReports.RDL.ServerProcessor.ReportingServer
    {
        internal static Token Token;
        private T Deserialize<T>(string json)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                return (T)serializer.ReadObject(ms);
            }
        }

        T DeseralizeObj<T>(Stream str)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlReader reader = XmlReader.Create(str);
            return (T)serializer.Deserialize(reader);
        }

        BoldReports.RDL.ServerProcessor.DataSourceDefinition GetDataSourceDefinition(ItemResponse response)
        {
            var _rptDefinition = new BoldReports.RDL.ServerProcessor.DataSourceDefinition();
            var _datasourceStream = this.GetFileToStream(response.FileContent);
            var _umpDefinition = this.DeseralizeObj<DataSourceDefinition>(_datasourceStream);
            _rptDefinition.ConnectString = _umpDefinition.ConnectString;
            _rptDefinition.CredentialRetrieval = (BoldReports.RDL.ServerProcessor.CredentialRetrievalEnum)Enum.Parse(typeof(BoldReports.RDL.ServerProcessor.CredentialRetrievalEnum), _umpDefinition.CredentialRetrieval.ToString(), true);
            _rptDefinition.Enabled = _umpDefinition.Enabled;
            _rptDefinition.EnabledSpecified = _umpDefinition.EnabledSpecified;
            _rptDefinition.Extension = _umpDefinition.Extension;
            _rptDefinition.ImpersonateUser = _umpDefinition.ImpersonateUser;
            _rptDefinition.ImpersonateUserSpecified = _umpDefinition.ImpersonateUserSpecified;
            _rptDefinition.OriginalConnectStringExpressionBased = _umpDefinition.OriginalConnectStringExpressionBased;
            _rptDefinition.Password = _umpDefinition.Password;
            _rptDefinition.Prompt = _umpDefinition.Prompt;
            _rptDefinition.UseOriginalConnectString = _umpDefinition.UseOriginalConnectString;
            _rptDefinition.UserName = _umpDefinition.UserName;
            _rptDefinition.WindowsCredentials = _umpDefinition.WindowsCredentials;
            return _rptDefinition;
        }

        public override BoldReports.RDL.ServerProcessor.DataSourceDefinition GetDataSourceDefinition(string dataSource)
        {
            var _credential = this.ReportServerCredential as System.Net.NetworkCredential;
            try
            {
                ItemRequest itemRequest = new ItemRequest();
                itemRequest.ItemType = ItemType.Datasource;
                itemRequest.ReportReferences = new List<string>();
                itemRequest.ReportReferences.Add(dataSource);

                using (var proxy = new CustomWebClient())
                {
                    var ser = new DataContractJsonSerializer(typeof(ItemRequest));
                    var mem = new MemoryStream();
                    ser.WriteObject(mem, itemRequest);
                    UpdateProxy(proxy, this.ReportServerUrl, _credential.UserName, _credential.Password);
                    var data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                    var rdata = proxy.UploadString(new Uri(this.ReportServerUrl + "/reports/data-sources/download"),
                        "POST", data);

                    var result = JsonConvert.DeserializeObject<List<ItemResponse>>(rdata);
                    return this.GetDataSourceDefinition(result.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        public override System.IO.Stream GetReport()
        {
            var _credential = this.ReportServerCredential as System.Net.NetworkCredential;
            try
            {
                Guid itemId;

                var itemRequest = new ItemRequest
                {
                    ItemType = ItemType.Report
                };

                if (Guid.TryParse(this.ReportPath, out itemId))
                {
                    itemRequest.ItemId = itemId;
                }
                else
                {
                    itemRequest.ServerPath = this.ReportPath;
                }

                using (var proxy = new CustomWebClient())
                {
                    var ser = new DataContractJsonSerializer(typeof(ItemRequest));
                    var mem = new MemoryStream();
                    ser.WriteObject(mem, itemRequest);
                    UpdateProxy(proxy, this.ReportServerUrl, _credential.UserName, _credential.Password);
                    var data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

                    var rdata = proxy.UploadString(new Uri(this.ReportServerUrl + "/reports/download"), "POST", data);
                    var result = JsonConvert.DeserializeObject<ItemResponse>(rdata);
                    if (result.Status && result.ItemType == ItemType.Report)
                    {
                        throw new Exception("Report is incorrect Format");
                    }
                    return this.GetFileToStream(result.FileContent);
                }
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        private Stream GetFileToStream(byte[] _fileContent)
        {
            MemoryStream memStream = new MemoryStream();
            memStream.Write(_fileContent, 0, _fileContent.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            return memStream;
        }

        internal static void UpdateProxy(CustomWebClient proxy, string serverUrl, string userName, string password)
        {
            if (ReportingServerExt.Token == null)
            {
                ReportingServerExt.Token = ReportingServerExt.GenerateToken(userName, password);
            }

            proxy.Headers["Content-type"] = "application/json";
            proxy.Headers["Authorization"] = ReportingServerExt.Token.token_type + " " + ReportingServerExt.Token.access_token;
            proxy.Encoding = Encoding.UTF8;
        }

        public static Token GenerateToken(string userName, string password)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();

                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", userName),
                    new KeyValuePair<string, string>("password", password)
                });

                var result = client.PostAsync("https://on-premise-demo.boldreports.com/reporting/api/site/site1/token", content).Result;
                string resultContent = result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Token>(resultContent);
            }
        }

    }

    class CustomWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri uri)
        {
            var request = base.GetWebRequest(uri);
            request.Timeout = 4 * 60 * 1000; //Increase time out
            return request;
        }
    }
}