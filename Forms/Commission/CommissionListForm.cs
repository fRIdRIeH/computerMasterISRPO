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

namespace ComputerMaster.Forms.Commission
{
    public partial class CommissionListForm : Form
    {
        private readonly ClientRepository _clientRepository;
        private readonly ComputerRepository _computerRepository;
        private readonly CommissionRepository _commissionRepository;
        public CommissionListForm(ClientRepository clientRepository, ComputerRepository computerRepository, CommissionRepository commissionRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
            _computerRepository = computerRepository;
            _commissionRepository = commissionRepository;
            LoadData();
        }

        private void dataGridViewCommission_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewCommission.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CommissionAddForm commissionAddForm = new CommissionAddForm(_clientRepository, _computerRepository, _commissionRepository, 0);
            commissionAddForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCommission.Rows.Count == 1) 
            {
                var selectedRow = dataGridViewCommission.SelectedRows[0];

                var commissionId = selectedRow.Cells["Идентификатор_Заказа"].Value;

                if(commissionId != null && int.TryParse(commissionId.ToString(), out int id))
                {
                    try
                    {
                        _commissionRepository.Delete(id);
                        MessageBox.Show("Заказ удален.");
                        LoadData();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Ошибка! " + ex.Message);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dataGridViewCommission.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridViewCommission.SelectedRows[0];

                var commissionId = selectedRow.Cells["Id"].Value;

                if (commissionId != null && int.TryParse(commissionId.ToString(), out int id))
                {
                    CommissionAddForm commissionAddForm = new CommissionAddForm(_clientRepository, _computerRepository, _commissionRepository, id);
                    commissionAddForm.ShowDialog();
                }
            }
        }

        public void LoadData()
        {
            var commissions = _commissionRepository.GetAll();

            dataGridViewCommission.DataSource = null;
            dataGridViewCommission.DataSource = commissions;
        }
    }
}
