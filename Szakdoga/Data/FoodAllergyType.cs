using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Szakdoga.Data
{
    public class FoodAllergyType : BaseEntity
    {
        public string Name { get; set; }
    }
}
