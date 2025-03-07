using ComputerMaster.Repositories;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerMaster.Models;

namespace ComputerMaster.Forms.Client
{
    public partial class ClientAddForm : Form
    {
        private readonly ClientRepository _clientRepository;
        int id;
        public ClientAddForm(ClientRepository clientRepository, int clientId)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
            id = clientId;

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
            btnAdd.Text = "Добавить";
            this.Text = "Добавление клиента";
        }

        public void LoadForEdit()
        {
            btnAdd.Text = "Редактировать";
            this.Text = "Редактировать информацию клиента клиента";

            var clientToFill = _clientRepository.Get(id);

            surnameInput.Text = clientToFill.Surname;
            nameInput.Text = clientToFill.Name;
            patronimycInput.Text = clientToFill.Patronimyc;
            emailInput.Text = clientToFill.Email;
            telephoneInput.Text = clientToFill.Telephone;
            addressInput.Text = clientToFill.Address;
        }

        private bool EmailValidate(string Email)
        {
            //Валидация почты
            string emailPattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            string realEmail = "";
            string email = emailInput.Text;

            if (Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Почта введена не верно!");
                return false;
            }
        }

        private bool TelephoneValidate(string Telephone) 
        {
            //Валидация номера телефона
            string telephonePattern = "[A-Za-zА-Яа-яЁё]";
            string telephone = telephoneInput.Text;
            string realTelephone = "";

            Regex regex = new Regex(telephonePattern);
            bool result = Regex.IsMatch(telephone, telephonePattern);

            if (!result)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Телефон введен не верно! В строке 'Телефон' должны быть только цифры!");
                return false;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!EmailValidate(emailInput.Text))
            {
                return;
            }
            if (!TelephoneValidate(telephoneInput.Text))
            {
                return;
            }
            

            try
            {
                if(btnAdd.Text == "Добавить")
                {
                    Models.Client client = new()
                    {
                        Surname = surnameInput.Text,
                        Name = nameInput.Text,
                        Patronimyc = patronimycInput.Text,
                        Email = emailInput.Text,
                        Telephone = telephoneInput.Text,
                        Address = addressInput.Text,
                    };

                    _clientRepository.Add(client);
                    MessageBox.Show("Клиент успешно добавлен!");
                    this.Close();
                }
                if(btnAdd.Text == "Редактировать")
                {
                    Models.Client client = new()
                    {
                        Id = id,
                        Surname = surnameInput.Text,
                        Name = nameInput.Text,
                        Patronimyc = patronimycInput.Text,
                        Email = emailInput.Text,
                        Telephone = telephoneInput.Text,
                        Address = addressInput.Text,
                    };

                    _clientRepository.Update(client);
                    MessageBox.Show("Данные клиента успешно отредактированы!");
                    this.Close();
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Возникла ошибка! " + ex.Message);
            }
        }
    }
}
