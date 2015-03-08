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
    //Class for the answers table in the database
    public class answer
    {
        public answer(string answerId)
        {
            this.id = answerId;
        }

        //The databses' table fields 
        public string question { get; set; }
        public string content { get; set; }
        public string username { get; set; }
        public string id { get; set; }

        private string mainServerUrl = "";

        //Gets all the information for the currently selected answer from the databse by id, to initialize properly the object
        public void answerInit()
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            WebClient client = new WebClient();
            NameValueCollection idValue = new NameValueCollection();
            idValue["id"] = id;
            string contentUrl = mainServerUrl + "getAnswerContent.php";
            string userUrl = mainServerUrl + "getAnswerUser.php";
            byte[] contentResponse = client.UploadValues(contentUrl, "POST", idValue);
            byte[] userResponse = client.UploadValues(userUrl, "POST", idValue);
            this.content = Encoding.UTF8.GetString(contentResponse);
            this.username = Encoding.UTF8.GetString(userResponse);
        }
    }
}
