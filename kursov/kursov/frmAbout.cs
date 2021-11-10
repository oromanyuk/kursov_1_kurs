using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursov
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout_Load(object sender, EventArgs e) //Показ данных о названии и версии
        {
            ProdName.Text = string.Format("Имя продукта: {0}", Application.ProductName);
            ProdVers.Text = string.Format("Версия: {0}", Application.ProductVersion);

        }
    }
}
