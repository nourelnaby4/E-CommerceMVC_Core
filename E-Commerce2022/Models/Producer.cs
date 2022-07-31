using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce2022.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string profilePicture { get; set; }
        public string Bio { get; set; }


        public List<Movie> Movies { get; set; }
    }
}
