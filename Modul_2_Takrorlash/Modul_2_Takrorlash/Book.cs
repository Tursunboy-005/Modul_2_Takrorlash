using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_2_Takrorlash
{
    internal class Book : Publication
    {
        public string Authoor { get; set; }
        public string ISBN { get; set; }

        public Book()
        {

        }

        public Book(string title, int publicationYear,string author,string isbn)
            :base(title, publicationYear)
        {
            Authoor = author;
            ISBN = isbn;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book; [{Title}], publicationyear [{PublicationYear}], Author  [{Authoor}], ISBN [{ISBN}]");
        }
    }
}
