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

namespace ComputerMaster.Forms.Client
{
    public partial class ClientListForm : Form
    {
        private readonly ClientRepository _clientRepository;
        public ClientListForm(ClientRepository clientRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
        }
    }
}
