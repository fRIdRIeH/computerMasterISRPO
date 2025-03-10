using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerMaster.Repositories;
using ComputerMaster.Models;
using System.Security.Cryptography;

namespace ComputerMaster.Forms.Commission
{
    public partial class CommissionAddForm : Form
    {
        private readonly ClientRepository _clientRepository;
        private readonly ComputerRepository _computerRepository;
        private readonly CommissionRepository _commissionRepository;
        int id;
        public CommissionAddForm(ClientRepository clientRepository, ComputerRepository computerRepository, CommissionRepository commissionRepository, int commissionId)
        {
            InitializeComponent();

            _clientRepository = clientRepository;
            _computerRepository = computerRepository;
            _commissionRepository = commissionRepository;
            id = commissionId;

            //Данные для статуса
            statusInput.DataSource = new List<string> { "В процессе", "Подтвержден", "Отменен" };

            modelInput.Enabled = false;
            priceInput.Enabled = false;
            clientNameInput.Enabled = false;
            clientTelephoneInput.Enabled = false;
            clientAddressInput.Enabled = false;
            btnAddOrEdit.Enabled = false;

            if (id == 0)
            {
                LoadForAdd();
            }
            else
            {
                LoadForEdit();
            }
        }

        public void LoadForAdd()
        {
            this.Text = "Добавление заказа";
            btnAddOrEdit.Text = "Добавить";

            this.Size = new Size(1300, 800);

            var computers = _computerRepository.GetAll();
            var clients = _clientRepository.GetAll();

            dataGridViewComputers.DataSource = computers;
            dataGridViewClients.DataSource = clients;
        }

        public void LoadForEdit()
        {
            this.Text = "Редактирование заказа";
            btnAddOrEdit.Text = "Редактировать";

            this.Size = new Size(341, 800);

            //скрытие ненужного для редактирования
            label9.Visible = false;
            label10.Visible = false;
            dataGridViewClients.Visible = false;
            dataGridViewComputers.Visible = false;

            //заполнение строк данными из бд
            var commissionToFill = _commissionRepository.Get(id);

            modelInput.Text = commissionToFill.ComputerModel;
            dateInput.Value = commissionToFill.CommissionDate;
            priceInput.Value = commissionToFill.CommissionPrice;
            clientNameInput.Text = commissionToFill.ClientName;
            clientTelephoneInput.Text = commissionToFill.ClientTelephone;
            clientAddressInput.Text = commissionToFill.ClientAddress;
            statusInput.Text = commissionToFill.Status;
            noteInput.Text = commissionToFill.Note;

            //активация кнопки
            btnAddOrEdit.Enabled = true;
        }

        private void dataGridViewComputers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                dataGridViewComputers.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                dataGridViewClients.Rows[e.RowIndex].Selected = true;
            }
        }

        //вывод значений в текстовые поля данных компьютера и клиента
        private void btnPreview_Click(object sender, EventArgs e)
        {
            var selectedComputerRow = dataGridViewComputers.SelectedRows[0];
            var computerId = selectedComputerRow.Cells[id].Value;

            var selectedClientRow = dataGridViewClients.SelectedRows[0];
            var clientId = selectedClientRow.Cells[id].Value;

            if (computerId != null && int.TryParse(computerId.ToString(), out int compId))
            {
                if (clientId != null && int.TryParse(clientId.ToString(), out int cId))
                {
                    var computer = _computerRepository.Get(compId);
                    var client = _clientRepository.Get(cId);

                    modelInput.Text = computer.Model;
                    priceInput.Value = computer.Price;

                    clientNameInput.Text = client.Name;
                    clientTelephoneInput.Text = client.Address;
                    clientAddressInput.Text = client.Telephone;

                    btnAddOrEdit.Enabled = true;
                }
            }
        }

        private void btnAddOrEdit_Click(object sender, EventArgs e)
        {
            if(btnAddOrEdit.Text == "Добавить")
            {
                var selectedComputerRow = dataGridViewComputers.SelectedRows[0];
                var computerId = selectedComputerRow.Cells[id].Value;

                var selectedClientRow = dataGridViewClients.SelectedRows[0];
                var clientId = selectedClientRow.Cells[id].Value;

                if (computerId != null && int.TryParse(computerId.ToString(), out int compId))
                {
                    if (clientId != null && int.TryParse(clientId.ToString(), out int cId))
                    {
                        try
                        {
                            Models.Commission commission = new() 
                            { 
                                ComputerId = compId,
                                CommissionDate = dateInput.Value,
                                CommissionPrice = priceInput.Value,
                                ClientId = cId,
                                Status = statusInput.Text,
                                Note = noteInput.Text,
                            };
                            _commissionRepository.Add(commission);
                            MessageBox.Show("Заказ успешно добавлен!");
                            this.Close();
                        }
                        catch (Exception ex) 
                        {
                            MessageBox.Show("Заказ не добавлен! Ошибка: " + ex.Message);
                        }
                    }
                }
            }
            if (btnAddOrEdit.Text == "Редактировать")
            {
                try
                {
                    Models.Commission commission = new()
                    {
                        Id = id,
                        CommissionDate = dateInput.Value,
                        CommissionPrice = priceInput.Value,
                        Status = statusInput.Text,
                        Note = noteInput.Text,
                    };
                    _commissionRepository.Update(commission);
                    MessageBox.Show("Заказ успешно отредактирован!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Заказ не отредактирован! Ошибка: " + ex.Message);
                }
            }
        }
    }
}
