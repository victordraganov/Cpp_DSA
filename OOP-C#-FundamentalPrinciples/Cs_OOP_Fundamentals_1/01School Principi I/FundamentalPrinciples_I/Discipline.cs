using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01School
{
    public class Discipline : ICommentable
    {
        private string name;
        private int lectures;
        private int exersises;
        private List<string> comments;

        public string Name
        {
            get { return this.name; }
        }
        public int Lectures
        {
            get { return this.lectures; }
        }
        public int Exersises
        {
            get { return this.exersises; }
        }
        public List<string> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }

        public Discipline(string name, int lectures, int exersises)
        {
            this.name = name;
            this.lectures = lectures;
            this.exersises = exersises;
            this.comments = null;
        }
        public void MakeComment(string comment)
        {
            comments.Add(comment);
        }
    }
}
