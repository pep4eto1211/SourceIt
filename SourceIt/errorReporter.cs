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
using System.Windows.Media.Animation;

namespace SourceIt
{
    //Class for reporting bugs
    class errorReporter
    {
        //Upload the exception data to the database
        public static void reportError(Exception error, String fileName, string mainServerUrl)
        {
            WebClient client = new WebClient();
            NameValueCollection errorDetails = new NameValueCollection();
            errorDetails["message"] = error.Message + " " + error.StackTrace;
            errorDetails["source"] = error.Source;
            errorDetails["code"] = error.HResult.ToString();
            errorDetails["file"] = fileName;
            string reportUrl = mainServerUrl + "reportError.php";
            client.UploadValues(reportUrl, "POST", errorDetails);
        }
    }
}
