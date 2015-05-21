namespace _01School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Teacher : Person,ICommentable
    {
        private List<Discipline> disciplines;
        private List<string> comments;
        
        public Teacher(string name, List<Discipline> disciplines)
        {
            this.Name = name;
            this.disciplines = disciplines;
            this.comments = null;
        }

        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }
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
