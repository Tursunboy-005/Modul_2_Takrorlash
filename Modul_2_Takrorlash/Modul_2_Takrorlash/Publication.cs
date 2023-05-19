using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_2_Takrorlash
{
    abstract class Publication
    {
        public string Title { get; set; }
        public int PublicationYear { get; set; }

        public Publication(string title, int publicationYear) 
        {
            Title = title;
            PublicationYear = publicationYear;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title [{Title}], PublicationYear  [{PublicationYear}]");
        }
    }
}
