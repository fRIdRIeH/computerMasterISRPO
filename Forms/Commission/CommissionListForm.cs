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
        private readonly CommissionRepository _commissionRepository;
        public CommissionListForm(CommissionRepository commissionRepository)
        {
            InitializeComponent();
        }
    }
}
