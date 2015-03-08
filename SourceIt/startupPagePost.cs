using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceIt
{
    //Class for a post on the startup page
    public class startupPagePost
    {
        public string content;
        public string type;
        public string user;
        public string project;
        public string theId;

        public startupPagePost(string postContent, string postType, string postUser, string projectName, string projectId)
        {
            this.content = postContent;
            this.type = postType;
            this.user = postUser;
            this.project = projectName;
            this.theId = projectId;
        }
    }
}
