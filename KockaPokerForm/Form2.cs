using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KockaPokerForm
{
    public partial class frmKezdo : Form
    {
        private frmFo foForm;

        public frmKezdo(frmFo fo)
        {
            InitializeComponent();
            foForm = fo;
        }

        private void btnHarom_Click(object sender, EventArgs e)
        {
            foForm.KorokSzama = 3;
            foForm.Text += " | A körök száma 3!";
            this.Close();
        }

        private void btnOt_Click(object sender, EventArgs e)
        {
            foForm.KorokSzama = 5;
            foForm.Text += " | A körök száma 5!";
            this.Close();
        }

        private void frmKezdo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (foForm.KorokSzama == 0)
            {
                var result = MessageBox.Show("Nincs beállítva a körök száma!" +
                    " Csak egykörös játék lesz!", "Beállítás nélkül",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    foForm.KorokSzama = 1;
                    foForm.Text += " | A körök száma 1!";
                    e.Cancel = false;
                    return;
                }
            }
        }
    }
}
