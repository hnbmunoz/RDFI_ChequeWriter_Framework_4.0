using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChequeWriter.Models
{
    public class ChequeDto
    {
        public string chequeNumber { get; set; }
        public string chequePayee { get; set; }
        public string chequeAmount { get; set; }
        public string chequeAmountWords { get; set; }
        public string chequeDate { get; set; }

    }
}
