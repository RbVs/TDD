using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TDD.Api.Models
{
    [Table("Tb_User")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    }
}