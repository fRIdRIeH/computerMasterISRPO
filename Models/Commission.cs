using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerMaster.Models
{
    public class Commission
    {
        public int Id { get; set; }
        public int ComputerId { get; set; }
        public string ComputerModel { get; set; }
        public DateTime CommissionDate { get; set; }
        public decimal CommissionPrice { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientTelephone { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }

        public Commission() { }

        //Для вывода в ComissionListForm
        public Commission(int id, string computerModel, DateTime commissionDate, decimal commissionPrice, int clientId, string clientName, string clientAddress, string clientTelephone, string status, string note) 
        {
            Id = id;
            ComputerModel = computerModel;
            CommissionDate = commissionDate;
            CommissionPrice = commissionPrice;
            ClientId = clientId;
            ClientName = clientName;
            ClientAddress = clientAddress;
            ClientTelephone = clientTelephone;
            Status = status;
            Note = note;
        }
        //Для добавления в БД
        public Commission(int computerId, DateTime commissionDate, decimal commissionPrice, int clientId, string status, string note)
        {
            ComputerId = computerId;
            CommissionDate = commissionDate;
            CommissionPrice = commissionPrice;
            ClientId = clientId;
            Status = status;
            Note = note;
        }

        //Для обновления данных в БД
        public Commission(int id, DateTime commissionDate, string status, string note)
        {
            Id = id;
            CommissionDate = commissionDate;
            Status = status;
            Note = note;
        }
    }
}
