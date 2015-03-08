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
    //Class for the question table in the database
    public class question
    {
        public string id {get; set;}
        public string username { get; set; }
        public string content { get; set; }

        public question(string theId)
        {
            this.id = theId;
        }

        private string mainServerUrl = "";

        //Properly initalize the question object
        public void questionInit()
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            NameValueCollection idValue = new NameValueCollection();
            idValue["id"] = id;
            WebClient dataClient = new WebClient();
            string contentUrl = mainServerUrl + "getQuestion.php";
            byte[] contentResponse = dataClient.UploadValues(contentUrl, "POST", idValue);
            content = Encoding.UTF8.GetString(contentResponse);
            string userUrl = mainServerUrl + "getQuestionUser.php";
            byte[] userResponse = dataClient.UploadValues(userUrl, "POST", idValue);
            username = Encoding.UTF8.GetString(userResponse);
        }
    }
}
