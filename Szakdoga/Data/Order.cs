using System.ComponentModel.DataAnnotations.Schema;

namespace Szakdoga.Data
{
    public class Order :BaseEntity
    {
        public string Name { get; set; }

        [ForeignKey("TableId")]
        public Table Table { get; set; }
        public int TableId { get; set; }

        //[ForeignKey("ReceiptId")]
       // public Receipt Receipt { get; set; }
       // public int? ReceiptId { get; set; }
    }
}