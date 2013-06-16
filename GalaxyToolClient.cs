using System;
using System.Linq;
using GalaxyToolApi.Roots;
using GalaxyToolApi.Submission;
using GalaxyToolApi.Utils;
using RestSharp;
using RestSharp.Deserializers;

namespace GalaxyToolApi
{
    public class GalaxyToolClient
    {
        private Uri _uri;
        private Uri _ogameUri;
        private string _token;
        private RestClient _client;

        public string Universe { get; private set; }
        public Version GalaxyToolVersion { get; private set; }

        public GalaxyToolClient(Uri uri, Uri ogameUri, string token)
        {
            _uri = uri;
            _ogameUri = ogameUri;
            _token = token;

            _client = new RestClient(_uri.ToString());
            _client.AddHandler("text/xml", new DotNetXmlDeserializer());
        }

        public bool Initialize()
        {
            RestRequest req = new RestRequest();
            req.Method = Method.POST;
            req.AddParameter("type", "validate");
            req.AddParameter("token", _token);

            IRestResponse<ValidationResult> result = _client.Execute<ValidationResult>(req);

            if (result.ErrorException != null)
                return false;

            if (result.Data == null)
                return false;

            GalaxyToolPermission insertPermission = result.Data.Permissions.FirstOrDefault(s => s.Name == "caninsert");
            if (insertPermission == null)
                return false;

            Universe = result.Data.Universe;
            GalaxyToolVersion = result.Data.Version.Version;

            return insertPermission.Value;
        }

        public SubmitResult SubmitData<T>(T data) where T : GalaxyToolRoot
        {
            // Set header
            data.Header.Token = _token;
            data.Header.Universe = Universe;
            data.Header.Debug = false;
            data.Header.Version = "2.6.30";

            // Serialize
            string xml = Serializer.Serialize(data);

            RestRequest req = new RestRequest();
            req.Method = Method.POST;
            req.AddParameter("type", data.Header.ContentType.GetXmlEnumString());
            req.AddParameter("content", xml);
            req.AddParameter("uni_url", _ogameUri.DnsSafeHost);

            IRestResponse<SubmitResult> result = _client.Execute<SubmitResult>(req);

            return result.Data;
        }
    }
}
