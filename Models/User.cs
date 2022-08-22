using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Janus_API.Models
{
    public class User
    {
        /* "DefaultConnection": "Server=LAPTOP-KKJR5H9K\\SQLEXPRESS; Database=Janus;Trusted_Connection=True; ",*/
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string FirstName { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string LastName { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        public string Address { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string Phone1 { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string Phone2 { get; set; }
        public List<Asset> Assets { get; set; }
        public List<Transaction> Transactions { get; set; }

    }
}
