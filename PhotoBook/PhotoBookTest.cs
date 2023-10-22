using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static oop3.PhotoBook.PhotoBook;

namespace oop3.PhotoBook
{
    public class PhotoBookTest
    {
        public void Main ()
        {

            PhotoBook  photoBookDefault=  new PhotoBook();
            Console.WriteLine("The number of page in the defualt photo book: {0}" , photoBookDefault.GetNumPages() );
            PhotoBook photoBookCustom = new PhotoBook(24);
            Console.WriteLine("The number of page in the custom photo book: {0}", photoBookCustom.GetNumPages());
            BigPhotoBook bigPhotoBook = new BigPhotoBook();
            Console.WriteLine("The number of page in the big photo book: {0}", bigPhotoBook.GetNumPages());


        }
    }
}
