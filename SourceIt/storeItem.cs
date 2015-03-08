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
using System.Windows.Media.Effects;

namespace SourceIt
{
    //Class for the store table from the database
    public class storeItem
    {
        public storeItem(string itemName)
        {
            this.name = itemName;
        }

        //The table fields
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }

        private string mainServerUrl = "";

        //Initialiazing the object
        public void loadData()
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            WebClient descriptionClient = new WebClient();
            WebClient categoryClient = new WebClient();
            NameValueCollection nameValue = new NameValueCollection();
            nameValue["name"] = name;
            string descriptionUrl = mainServerUrl + "getStoreDescription.php";
            string categoryUrl = mainServerUrl + "getStoreCategory.php";
            byte[] descriptionResponse = descriptionClient.UploadValues(descriptionUrl, "POST", nameValue);
            description = Encoding.UTF8.GetString(descriptionResponse);
            byte[] categoryResponse = categoryClient.UploadValues(categoryUrl, "POST", nameValue);
            category = Encoding.UTF8.GetString(categoryResponse);
        }

    }
}
