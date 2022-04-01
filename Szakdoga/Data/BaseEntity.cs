using System.ComponentModel.DataAnnotations;

namespace Szakdoga.Data
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifyDate { get; set; }
        public string CreatedUserId { get; set; }
        public string LastModifyUserId { get; set; }
    }
}
