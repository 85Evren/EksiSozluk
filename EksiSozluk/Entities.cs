using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk
{
    [Table("Girişler")]
    public class Entities
    {

        [Key]
        public int ID { get; set; }
       
        [Column("Başlık")]
        [StringLength(100)]
        public string Name { get; set; }

        [ForeignKey("Details")]
        public int DetailsID { get; set; }

        [ForeignKey("Users")]
        public int UserID { get; set; }

        [ForeignKey("Comments")]
        public int CommentsID { get; set; }
        public DateTime CreationDate { get; set; }



    }
}
