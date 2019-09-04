using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa fue creado por Josue Gutierrez", "Acerca de.... Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void borrarColor()
        {
            azulToolStripMenuItem.Checked = false;
            rojoToolStripMenuItem.Checked = false;
        }

        private void AzulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            Prueba.ForeColor = Color.Blue;
        }

        private void RojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prueba.ForeColor = Color.Red;
        }

        private void TimesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comicSariaToolStripMenuItem.Checked = false;
            Prueba.Font = new Font("Times New Roman ", 18, Prueba.Font.Style);
            timesNewRomanToolStripMenuItem.Checked = true;

        }

        private void ComicSariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comicSariaToolStripMenuItem.Checked = true;
            Prueba.Font = new Font("Comic Saria MS ", 18, Prueba.Font.Style);
            timesNewRomanToolStripMenuItem.Checked = false;
        }
    }
}
