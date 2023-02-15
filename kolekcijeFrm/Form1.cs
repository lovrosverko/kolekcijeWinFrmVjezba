using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolekcijeFrm
{
    
    public partial class Form1 : Form
    {
        List<Vozilo> voziloList = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMarka.Text == "" ||
                    txtModel.Text == "" ||
                    cmbVrsta.Text == "")
                {
                    MessageBox.Show("Pogrešan unos. Molimo pokušajte ponovo",
                                        "Pogrešan unos", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    txtMarka.Clear();
                    txtModel.Clear();
                    txtMarka.Focus();
                }
                else
                {
                    Vozilo vozilo = new Vozilo(txtMarka.Text,
                        txtModel.Text,
                        cmbVrsta.Text);
                    voziloList.Add(vozilo);
                    txtMarka.Clear();
                    txtModel.Clear();
                    txtMarka.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Pogrešan unos. Molimo pokušajte ponovo",
                    "Pogrešan unos", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                txtMarka.Clear();
                txtModel.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Vozilo v in voziloList)
            {
                txtIspis.AppendText(v.ToString());
            }
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            foreach (Vozilo v in voziloList)
            {
                if (v.Vrsta == "Avion")
                {
                    v.VoziPo = "Zrak";
                }
                else if (v.Vrsta == "Vozilo")
                {
                    v.VoziPo = "Cesta";
                }
                else
                {
                    v.VoziPo = "Voda";
                }
            }

        }
    }
}
