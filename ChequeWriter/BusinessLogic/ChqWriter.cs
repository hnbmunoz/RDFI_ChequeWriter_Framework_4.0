using ChequeWriter.EGRepository;
using ChequeWriter.Models;
using ChequeWriter.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ChequeWriter.BusinessLogic
{
    class ChqWriter
    {
        DataTable Maindt = new DataTable();
        DataTable Chqdt = new DataTable();//Exclusive DataTable for Cheque Data

        ExactGlobeRepository EGRepo = new ExactGlobeRepository();

        Utility utilities = new Utility();
        PHPBankPolicy phpPolicy = new PHPBankPolicy();


        public ChequeDto getChequeData(string drpDownValue, string chkNumber, string bankpolicy)
        {

            return EGRepo.getChequeData(drpDownValue, chkNumber, bankpolicy);

        }

        public DataTable getComboBox(string drpdownvalue)
        {
            return EGRepo.LoadComboBox(drpdownvalue);
        }

        public string getCompanyNamebyCode(string drpdownvalue)
        {
            return EGRepo.getCompanyNamebyCode(drpdownvalue);
        }

    }
}
