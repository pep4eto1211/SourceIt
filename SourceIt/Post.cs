using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceIt
{
    //Clas for the posts table form the database
    public class Post
    {
        public string content;
        public string type;
        public string user;
        public string theId;

        public Post(string postContent, string postType, string postUser, string projectId)
        {
            this.content = postContent;
            this.type = postType;
            this.user = postUser;
            this.theId = projectId;
        }
    }
}
