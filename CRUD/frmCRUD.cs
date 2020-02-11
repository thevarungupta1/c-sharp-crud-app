using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class frmCRUD : Form
    {
        public frmCRUD()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerDataSet);

        }

        private void frmCRUD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerDataSet.Customer);

        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorMoveFirstItem.PerformClick();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorMovePreviousItem.PerformClick();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorMoveNextItem.PerformClick();
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorMoveLastItem.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorAddNewItem.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            customerBindingNavigatorSaveItem_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorDeleteItem.PerformClick();
        }
    }
}
