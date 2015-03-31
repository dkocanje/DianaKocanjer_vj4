using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loto
{
    public partial class FrmLoto : Form
    {
        private Loto loto;
        public Loto () {
            InitializeComponent();
            loto = new Loto();
        }
        public FrmLoto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtUplaceniBrojX_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUplati_Click(object sender, EventArgs e)
        {
            List<string> vrijednosti = new List<string>();
            vrijednosti.Add(txtUplacenibroj1.Text);
            vrijednosti.Add(txtUplacenibroj2.Text);
            vrijednosti.Add(txtUplacenibroj3.Text);
            vrijednosti.Add(txtUplacenibroj4.Text);
            vrijednosti.Add(txtUplacenibroj5.Text);
            vrijednosti.Add(txtUplacenibroj6.Text);
            vrijednosti.Add(txtUplacenibroj7.Text);

            bool ispravnaKombinacija = loto.UnesiUplaceneBrojeve(vrijednosti);
            if (ispravnaKombinacija = true) {
                btnOdigraj.Enabled = true;
            }

            else {
                btnOdigraj.Enabled = false;
                MessageBox.Show ("Kombinacija uplacenih brojeva nije ispravna");
            }
        }

        private void btnOdigraj_Click(object sender, EventArgs e)
        {
            loto.GenerirajDobitnuKombinaciju();

            txtDobitniBroj1.Text = loto.Dobitnibrojevi[0]. ToString();
            txtDobitniBroj2.Text = loto.Dobitnibrojevi[1]. ToString();
            txtDobitniBroj3.Text = loto.Dobitnibrojevi[2]. ToString();
            txtDobitniBroj4.Text = loto.Dobitnibrojevi[3]. ToString();
            txtDobitniBroj5.Text = loto.Dobitnibrojevi[4]. ToString();
            txtDobitniBroj6.Text = loto.Dobitnibrojevi[5]. ToString();
            txtDobitniBroj7.Text = loto.Dobitnibrojevi[6]. ToString();

            int brojPogodaka = loto.IzracunajBrojPogodaka();
            lblBrojPogodaka.Text = brojPogodaka.ToString();
            

        }
    }
}
