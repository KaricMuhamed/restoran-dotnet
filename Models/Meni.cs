using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace ProjekatRestoran.Models
{
    public class Meni
    {
        [Key]
        public int Id { get; set; } 
        public string NazivJela { get; set; }
        public int Cijena { get; set; }
        public string OznakaJela { get; set; }
    }
}
