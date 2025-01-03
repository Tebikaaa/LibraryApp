﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryEFCore.Basiss;

namespace LibraryEFCore.Models
{
    public class OduncIslem
    {
        [Key]
        public int ID { get; set; }

        public int UyeID { get; set; }
        public required Uye Uye { get; set; }

        public int KitapID { get; set; }
        public required Kitap Kitap { get; set; }

        public DateTime OduncTarihi { get; set; }

        public int KalanGun { get; set; }

        public OduncDurumu OduncDurumu { get; set; }

        public string OduncAlmaTipi { get; set; }

        public DateTime? IadeTarihi { get; set; } // Nullable
    }

}
