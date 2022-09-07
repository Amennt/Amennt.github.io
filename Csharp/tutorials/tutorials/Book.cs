using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorials
{
    internal class Book
    {
        public string name;
        public string author;
        private string library;
        public int pages;

        public Book (string aName, string aAuthor, string aLibrary, int aPages)
        {
            name = aName;
            author = aAuthor;
            Library = aLibrary;
            pages = aPages;
        }

        public string Library
        {
            get 
            { 
                return library;
            }
            set
            {
                if(value == "czestochowa" || value == "poznan" || value == "warszawa" || value == "prywatna")
                {
                    library = value;
                }
                else
                {
                    library = "prywatna";
                }
            }
        }
    }
}
