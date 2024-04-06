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
    public partial class FrmHeros : Form
    {
        public FrmHeros(List<Hero> heroes)
        {
            InitializeComponent();
            dgvHeros.DataSource = heroes;
            this.Text = $"Displaying {heroes.Count} heroes";
        }
    }
}
