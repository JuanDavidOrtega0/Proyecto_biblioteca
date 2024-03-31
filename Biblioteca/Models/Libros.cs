namespace Biblioteca.Models
{
    public class Libros
    {
        public int Id {get; set;}
        public string FrontPage {get; set;}
        public string title {get; set;}
        public string author {get; set;}
        public string genre {get; set;}
        public int PublicationDate {get; set;}
        public int CopiesAvailable {get; set;}

    }
}