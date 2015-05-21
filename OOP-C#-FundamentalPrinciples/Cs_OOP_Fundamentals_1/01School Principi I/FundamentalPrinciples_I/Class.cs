namespace _01School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Class : ICommentable
    {
        private string identifier;
        private List<Student> students;
        private List<Teacher> teachers;
        private List<string> comments;

        public Class(string identifier, List<Student> students, List<Teacher> teachers)
        {
            this.identifier = identifier;
            this.students = students;
            this.teachers = teachers;
            this.comments = null;
        }
        public string Identifier
        {
            get { return this.identifier; }
        }
        public List<string> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }
        public void MakeComment(string comment)
        {
            comments.Add(comment);
        }

    }
}
