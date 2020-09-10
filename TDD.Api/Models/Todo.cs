using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TDD.Api.Models
{
    [Table("TB_Todo")]
    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime Updated { get; set; }
    }
}