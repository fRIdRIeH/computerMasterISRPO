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

namespace ComputerMaster.Forms.Client
{
    public partial class ClientAddForm : Form
    {
        private readonly ClientRepository _clientRepository;
        private int Id;
        public ClientAddForm(ClientRepository clientRepository, int id)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
            Id = id;

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

            var clientToFill = _clientRepository.Get(Id);

            surnameInput.Text = clientToFill.Surname;
            nameInput.Text = clientToFill.Name;
            patronimycInput.Text = clientToFill.Patronimyc;
            emailInput.Text = clientToFill.Email;
            telephoneInput.Text = clientToFill.Telephone;
            addressInput.Text = clientToFill.Address;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Валидация почты
            string emailPattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            string realEmail = "";
            string email = emailInput.Text;

            if (Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase))
            {
                realEmail = email;
            }
            else
            {
                MessageBox.Show("Почта введена не верно!");
                return;
            }

            //Валидация номера телефона
            //string telephonePattern = @"\D\d";
            string telephonePattern = @".* [A-Z-zА-Яа-яЁё].*";
            string telephone = telephoneInput.Text;
            string realTelephone = "";

            Regex regex = new Regex(telephonePattern);
            bool result = Regex.IsMatch(telephone, telephonePattern);

            if (result)
            {
                realTelephone = telephone;
            }
            else
            {
                MessageBox.Show("Телефон введен не верно! В строке 'Телефон' должны быть только цыфры!");
                return;
            }

            MessageBox.Show(realEmail + " " + telephone);   
        }
    }
}
