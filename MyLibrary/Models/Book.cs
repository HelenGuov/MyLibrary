namespace MyLibrary.Models
{
    public class Book
    {
        //Assumption: one book is writen by only one author 
        public int BookId { get; set; }
        public string? Title { get; set; }

        public ICollection<Author> Authors { get; set; }
    }

}
