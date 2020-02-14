using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkCRUDApplication
{
    public partial class Form1 : Form
    {
        Costumer model = new Costumer(); // me equivoqué con el nombre de la tabla
        public Form1()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            tbFirstName.Text = tbLastName.Text = tbCity.Text = tbAddress.Text = "";
            bSave.Text = "Save";
            bDelete.Enabled = false;
            model.CostumerID = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clear();
            populateDataGridView();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            model.FirstName = tbFirstName.Text.Trim();
            model.LastName = tbLastName.Text.Trim();
            model.City = tbCity.Text.Trim();
            model.Address = tbAddress.Text.Trim();
            using (DBEntities db = new DBEntities())
            {
                if (model.CostumerID == 0) // Insert
                {
                    db.Costumers.Add(model);
                } else // Update
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
            clear();
            populateDataGridView();
            MessageBox.Show("submitted successfully");
        }

        void populateDataGridView()
        {
            dgvCostumer.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dgvCostumer.DataSource = db.Costumers.ToList<Costumer>();
            }
        }

        private void dgvCostumer_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCostumer.CurrentRow.Index != -1)
            {
                model.CostumerID = Convert.ToInt32(dgvCostumer.CurrentRow.Cells["CustomerID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    model = db.Costumers.Where(x => x.CostumerID == model.CostumerID).FirstOrDefault();
                    tbFirstName.Text = model.FirstName;
                    tbLastName.Text = model.LastName;
                    tbCity.Text = model.City;
                    tbAddress.Text = model.Address;
                }
                bSave.Text = "Update";
                bDelete.Enabled = true;
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Entity Framework - CRUD (Delete)", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Costumers.Attach(model);
                    }
                    db.Costumers.Remove(model);
                    db.SaveChanges();
                    populateDataGridView();
                    clear();
                    MessageBox.Show("deleted successfully");
                }
            }
        }
    }
}
