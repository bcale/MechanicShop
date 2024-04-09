using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MechanicShop.VehicleForm;

namespace MechanicShop
{
    public partial class NewTechRankForm : Form
    {
        private readonly SqlConnection connection;

        public class TechRank
        {
            public string Desription { get; set; } = string.Empty;
            public double Value { get; set; } = double.NaN;
        }

        public NewTechRankForm()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            double rankValue = double.NaN;
            try
            {
                rankValue = Convert.ToDouble(txt_rank_value.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            TechRank techrank = new TechRank()
            {
                Desription = txt_rank_desc.Text,
                Value = rankValue,
            };

            // Have user confirm before saving
            DialogResult result = MessageBox.Show("Insert Rank into Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string p_insert_rank = @"dbo.[insert_rank]";
                SqlCommand command = new SqlCommand(p_insert_rank, connection);
                command.CommandType = CommandType.StoredProcedure;

                // Set SQL Parameters
                command.Parameters.Clear();
                SqlParameter p_Description = new SqlParameter("@p_Description", techrank.Desription);
                SqlParameter p_Value = new SqlParameter("@p_Value", techrank.Value);

                // Add the parameters to the SqlCommand Object
                command.Parameters.Add(p_Description);
                command.Parameters.Add(p_Value);

                // EXEC the procedure
                command.ExecuteNonQuery();
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // Have user confirm before quitting
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void NewTechRankForm_Load(object sender, EventArgs e)
        {

        }
    }
}
