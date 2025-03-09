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
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ComputerAddForm computerAddForm = new ComputerAddForm(_computerRepository, 0);
            computerAddForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewComputer.SelectedRows.Count == 1) 
            {
                var selectedRows = dataGridViewComputer.SelectedRows[0];

                var computerId = selectedRows.Cells["Id"].Value;

                if (computerId != null && int.TryParse(computerId.ToString(), out int id)){
                    try
                    {
                        _computerRepository.Delete(id);
                        LoadData();
                        MessageBox.Show("Компьютер удален.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка! " + ex.Message);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewComputer.SelectedRows.Count == 1)
            {
                var selectedRows = dataGridViewComputer.SelectedRows[0];

                var computerId = selectedRows.Cells["Id"].Value;

                if (computerId != null && int.TryParse(computerId.ToString(), out int id)){
                    ComputerAddForm computerAddForm = new ComputerAddForm(_computerRepository, id);
                    computerAddForm.ShowDialog();
                }
            }
        }

        private void dataGridViewComputer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) 
            {
                dataGridViewComputer.Rows[e.RowIndex].Selected = true;
            }
        }

        public void LoadData()
        {
            var computers = _computerRepository.GetAll();

            dataGridViewComputer.DataSource = null;
            dataGridViewComputer.DataSource = computers;
        }
    }
}
