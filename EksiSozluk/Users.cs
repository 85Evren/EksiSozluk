using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk
{
    [Table("Kullanıcılar")]
    public class Users
    {
        [Key]
        public int UserID { get; set; }

        [Column("Ad Soyad")]
        [StringLength(300)]
        public string Name { get; set; }
        
        [Column("Cinsiyet")]
        [StringLength(1)]
        public string Gender { get; set; }

        [Column("Kayıt Tarihi")]
        public DateTime RegisterDate { get; set; }

    }
}
