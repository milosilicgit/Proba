using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            Unos un = new Unos();
            un.ShowDialog();
            Osvezi();
        }

        private void btnIzmena_Click(object sender, EventArgs e)
        {
            Izmena iz = new Izmena();
            iz.ShowDialog();
            Osvezi();
        }

        private void Osvezi()
        {
            lvGrupa.Items.Clear();
            List<Grupa> grupe;
            SQLklasa sqlk = new SQLklasa();

            try
            {
                grupe = sqlk.IscitajGrupe();
                foreach (var g in grupe)
                {
                    var item = new ListViewItem();
                    item.Text = g.GrupaID.ToString();
                    item.SubItems.Add(g.Sifra);
                    item.SubItems.Add(g.Naziv);
                    item.SubItems.Add(g.Opis);
                    item.SubItems.Add(g.Aktivno ? "Aktivno" : "Neaktivno");
                    item.SubItems.Add(g.NazivTipa);
                    lvGrupa.Items.Add(item);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvezi();
        }
    }
}
