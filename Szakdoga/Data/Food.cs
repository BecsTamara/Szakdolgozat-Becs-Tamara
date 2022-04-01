using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Szakdoga.Data
{
    public class Food :BaseEntity
    {
        public string Name { get; set; }
        [ForeignKey("FoodTypeId")]
        public FoodType FoodType { get; set; }
        public int FoodTypeId { get; set; }
        public bool Adult { get; set; }
        public int Price { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        public bool Enabled { get; set; }
    }
}
