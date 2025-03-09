using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerMaster.Repositories;
using ComputerMaster.Models;

namespace ComputerMaster.Forms.Computer
{
    public partial class ComputerAddForm : Form
    {
        private readonly ComputerRepository _computerRepository;
        int computerId;
        public ComputerAddForm(ComputerRepository computerRepository, int id)
        {
            InitializeComponent();
            computerId = id;
            _computerRepository = computerRepository;

            if (computerId == 0)
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
            this.Text = "Добавить компьютер";
            btn.Text = "Добавить";
        }

        public void LoadForEdit()
        {
            this.Text = "Редактировать компьютер";
            btn.Text = "Редактировать";

            var compToFill = _computerRepository.Get(computerId);

            modelInput.Text = compToFill.Model;
            processorInput.Text = compToFill.Processor;
            ramInput.Text = compToFill.Ram;
            hddInput.Text = compToFill.Hdd;
            priceInput.Value = compToFill.Price;
            amountInput.Value = compToFill.Amount;
            descriptionInput.Text = compToFill.Description;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(btn.Text == "Добавить")
            {
                Models.Computer computer = new()
                {
                    Model = modelInput.Text,
                    Processor = processorInput.Text,
                    Ram = ramInput.Text,
                    Hdd = hddInput.Text,
                    Price = priceInput.Value,
                    Amount = (int)amountInput.Value,
                    Description = descriptionInput.Text,
                };
                try
                {
                    _computerRepository.Add(computer);
                    MessageBox.Show("Компьютер добавлен!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка! " + ex.Message);
                }

            }
            if(btn.Text == "Редактировать")
            {
                Models.Computer computer = new()
                {
                    Id = computerId,
                    Model = modelInput.Text,
                    Processor = processorInput.Text,
                    Ram = ramInput.Text,
                    Hdd = hddInput.Text,
                    Price = priceInput.Value,
                    Amount = (int)amountInput.Value,
                    Description = descriptionInput.Text,
                };
                try
                {
                    _computerRepository.Update(computer);
                    MessageBox.Show("Компьютер отредактирован!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка! " + ex.Message);
                }
            }
        }
    }
}
