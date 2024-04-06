using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace narendra_ques3
{
    public partial class Form1 : Form
    {
        List<Hero> heroes = Hero.GetHeros();
        public Form1()
        {
            InitializeComponent();
            cboPowers.DataSource = Enum.GetNames(typeof(PowerEnum));
            ResetGui();
        }
        void ResetGui()
        {
            txtName.Text = "Narendra";
            txtAge.Text = "60";
            cboPowers.SelectedIndex = 0;
            chkIsGood.Checked = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            ResetGui();
        }

        private void btnShowHeros_Click(object sender, EventArgs e)
        {
            FrmHeros form = new FrmHeros(heroes);
            form.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Hero hero = new Hero(
                    txtName.Text,
                    Convert.ToInt32(txtAge.Text),
                    chkIsGood.Checked,
                    (PowerEnum)Enum.Parse(typeof(PowerEnum), cboPowers.SelectedItem.ToString()));
                heroes.Add(hero);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Check your input values", //test to  show
                    "Error adding hero",        //(optional) title of the dialog
                    MessageBoxButtons.OK);      //(optional) buttons to show
            }
        }
    }
}
