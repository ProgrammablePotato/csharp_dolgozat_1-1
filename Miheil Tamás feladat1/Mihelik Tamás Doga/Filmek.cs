using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    public class Filmek
    {
        private string Title { get; set; }
        private string Director { get; set; }
        private int Year { get; set; }
        private int Length { get; set; }

        public Filmek(string title, string director, int year, int length)
        {
            Title = title;
            Director = director;
            Year = year;
            Length = length;
        }

        public override string? ToString()
        {
            return $"Cím: {this.Title}, rendező: {this.Director}, kiadási év: {this.Year}, hossz (percben): {this.Length}";
        }
    }
}
