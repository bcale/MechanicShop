using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicShop
{
    public partial class SearchResults : Form
    {
        public SearchResults(RadioButton checkedButton)
        {
            InitializeComponent();
        }

        private void SearchResults_Load(object sender, EventArgs e)
        {

            // TO DO: Switch statement to process which function to call to produce the correct query

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
