using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceIt
{
    //Notification class for the notifications table in the database
    public class Notification
    {
        public string project;
        public string content;
        public string id;

        public Notification(string notificationUsername, string notificationContent, string notificationId)
        {
            this.project = notificationUsername;
            this.content = notificationContent;
            this.id = notificationId;
        }
    }
}
