using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace CSharpAppSensoRestClient
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class RestClient
    {
        public string endPoint { get; set; }
        public string requestHeader { get; set; }
        public httpVerb httpMethod { get; set; }

        public RestClient()
        {
            endPoint = string.Empty;
            requestHeader = string.Empty;
            httpMethod = httpVerb.GET;
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Headers.Add("X-Appsensor-Client-Application-Name2", requestHeader);

            request.Method = httpMethod.ToString();

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode);
                }
                //Process the response stream... (could be JSON, XML or HTML etc...)

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();

                        } //End of using StreamReader
                    }

                } // End of using ResponseStream

            } //End of using response
            catch (Exception ex)
            {
                strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }

            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            return strResponseValue;
        }
    }
}
