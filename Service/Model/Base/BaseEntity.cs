using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Service.Model.Base
{
   public class BaseEntity
   {
        [Key]
        [Column("PRODUCT_ID")]
        public long Id { get; set; }
   }
}