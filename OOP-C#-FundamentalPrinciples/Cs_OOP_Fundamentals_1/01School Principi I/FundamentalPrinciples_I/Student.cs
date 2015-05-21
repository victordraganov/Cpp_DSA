namespace _01School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student : Person,ICommentable
    {
        private string classNumber;
        private List<string> comments;
        
        public Student(string name, string classNumber)
        {
            this.Name = name;
            this.classNumber = classNumber;
            this.comments = null;
        }

        public string ClassNumber
        {
            get { return this.classNumber; }
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
