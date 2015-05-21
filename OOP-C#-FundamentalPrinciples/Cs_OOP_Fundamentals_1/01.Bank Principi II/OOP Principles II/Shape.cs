namespace OOP_Principles_II
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    abstract class Shape
    {
        private decimal width;
        public decimal Width { get; set; }

        private decimal heigth;
        public decimal Heigth { get; set; }

        public abstract decimal CalculateSurface();
    }
}
