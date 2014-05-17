namespace EindopdrachtS22.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Comment
    {
        public string BuildName { get; private set; }
        public string Comments { get; private set; }
        public string CommentID { get; private set; }

        public Comment(string Comment, string BuildName)
        {
            // this.CommentID = Get CommentID from database
            this.Comments = Comment;
            this.BuildName = BuildName;
        }

        private void SendComment()
        {
            // Send insert to Database;
        }

    }
}