using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    public class Grupa
    {
        public int GrupaID { get; set; }
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public bool Aktivno { get; set; }
        public int TipGrupeID { get; set; }

        public string NazivTipa { get; set; }
    }
}
