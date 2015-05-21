namespace _01School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    interface ICommentable
    {
        List<string> Comments { get; set; }
        void MakeComment(string comment);
    }
}
