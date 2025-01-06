using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFCore.Models
{
    [Table(name:"AppRapors")]
    public class AppRapor
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime Tarih { get; set; }
    }
}
