using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk
{
    [Table("Detaylar")]
    public class Details
    {
        [Key]
        public int DetailsID { get; set; }

        [Column("Açıklama")]
        [StringLength(300)]
        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}
