using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KebunBinatangADO
{
    public class ClassLaporanBooking
    {
        public string KodeBooking { get; set; }

        public string Nama { get; set; }

        public string NoHp { get; set; }

        public string Email { get; set; }

        public DateTime TanggalKunjungan { get; set; }

        public string TotalHarga { get; set; }

        public string StatusPembayaran { get; set; }
    }
}
