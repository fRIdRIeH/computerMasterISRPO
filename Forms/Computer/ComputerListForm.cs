using ComputerMaster.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerMaster.Forms.Computer
{
    public partial class ComputerListForm : Form
    {
        private readonly ComputerRepository _computerRepository;
        public ComputerListForm(ComputerRepository computerRepository)
        {
            InitializeComponent();
            _computerRepository = computerRepository;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewComputer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) 
            {
                dataGridViewComputer.Rows[e.RowIndex].Selected = true;
            }
        }

        private void LoadData()
        {
            var computers = _computerRepository.GetAll();

            dataGridViewComputer.DataSource = null;
            dataGridViewComputer.DataSource = computers;
        }
    }
}
