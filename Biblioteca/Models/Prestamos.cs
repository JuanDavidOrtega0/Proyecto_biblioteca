namespace Biblioteca.Models
{
    public class Prestamos
    {
        public int Id {get; set;}
        public int IdUser {get; set;}
        public int Librarian {get; set;}
        public int IdBook {get; set;}
        public DateTime LoanDate {get; set;}
        public DateTime ReturnDate {get; set;}
        public string Renewal {get; set;}

    }
}