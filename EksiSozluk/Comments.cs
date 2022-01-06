using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk
{
    [Table("Yorumlar")]
    public class Comments
    {
        [Key]
        public int CommentsID { get; set; }

        [Column("Yorum_Detayı")]
        [StringLength(300)]
        public string Description { get; set; }

        [Column("Yorum_Tarihi")]
        public DateTime PostDate { get; set; }
    }
}
