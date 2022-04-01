using System.ComponentModel.DataAnnotations;

namespace Szakdoga.Data
{
    public class Table : BaseEntity
    {
        public string Name { get; set; }
        public int SeatsNumber { get; set; }
    }
}