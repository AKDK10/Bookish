namespace Bookish.Models;

public class BookCopyViewModel
{
    public string Barcode {get; set;}
    public BookViewModel? BookIsbn {get; set;} 
    public BookCopyViewModel(string barcode)
    {
        Barcode = barcode;
    }


   
}
