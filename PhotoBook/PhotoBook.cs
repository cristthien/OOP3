using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.PhotoBook
{
    public class PhotoBook
    {
        private int numPages;
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }
        public PhotoBook() { 
         this.numPages = 16;
        }
        public int GetNumPages() {  return numPages; }
        public class BigPhotoBook: PhotoBook { 
            public BigPhotoBook()
            {
                 numPages = 64;
            }
        
        }
    }
}
