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
    //Class for the messages table in the database
    public class message
    {
        public message(string messageId)
        {
            this.id = messageId;
        }

        //The fields from the table
        public string id { get; set; }
        public string from { get; set; }
        public string content { get; set; }

        private string mainServerUrl = "";

        //Get all the data about the current message and initialize properly the message
        public void messageInit()
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            WebClient client = new WebClient();
            NameValueCollection idValue = new NameValueCollection();
            idValue["id"] = id;
            string fromUrl = mainServerUrl + "getMessageSender.php";
            string contentUrl = mainServerUrl + "getMessageContent.php";
            from = Encoding.UTF8.GetString(client.UploadValues(fromUrl, "POST", idValue));
            content = Encoding.UTF8.GetString(client.UploadValues(contentUrl, "POST", idValue));
        }
    }
}
