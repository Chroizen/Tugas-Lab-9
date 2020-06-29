using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLab8.ClassInduk;

namespace TugasLab8.ClassAnak
{
    public class Sales : Karyawan
    {
        public int JumlahPenjualan { get; set; }
        public int Komisi { get; set; }
        public override double Gaji()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}
