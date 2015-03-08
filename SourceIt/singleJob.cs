using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Net;
using System.Collections.Specialized;
using System.ComponentModel;

namespace SourceIt
{
    //Class for the helpReq folder form the database
    public class singleJob
    {
        public singleJob(string jobId)
        {
            this.id = jobId;
        }

        //The fields of the table
        public string id { get; set; }
        public string user { get; set; }
        public string content { get; set; }

        private string mainServerUrl = "";

        //Initialaizing the object like a boss...
        public void jobInit()
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            NameValueCollection idValue = new NameValueCollection();
            idValue["id"] = id;
            WebClient dataClient = new WebClient();
            string contentUrl = mainServerUrl + "getJob.php";
            byte[] contentResponse = dataClient.UploadValues(contentUrl, "POST", idValue);
            content = Encoding.UTF8.GetString(contentResponse);
            string userUrl = mainServerUrl + "getJobUser.php";
            byte[] userResponse = dataClient.UploadValues(userUrl, "POST", idValue);
            user = Encoding.UTF8.GetString(userResponse);
        }
        
    }
}
