using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public partial class Unos : Form
    {
        public Unos()
        {
            InitializeComponent();
        }

        SqlConnection con = Konekcija.KonekcioniString();

        private void Unos_Load(object sender, EventArgs e)
        {
            string sql = "select*from TipGrupe";
            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            cbTip.DataSource = dt;
            cbTip.ValueMember = "TipGrupeID";
            cbTip.DisplayMember = "Naziv";
            reader.Close();
            con.Close();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            Grupa g = new Grupa();
            SQLklasa sqlk = new SQLklasa();

            g.Sifra = txtSifra.Text;
            g.Naziv = txtNaziv.Text;
            g.Opis = txtOpis.Text;
            g.Aktivno = chbAktivno.Checked;
            g.TipGrupeID = (int)cbTip.SelectedValue;

            try
            {
                sqlk.InsertGrupa(g);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Close();
            }      
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
