using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTips.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "Name is too long.")]

        public string CustName { get; set; }
        public int CustAge { get; set; }
        public string CustGender { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int CustContact { get; set; }
        public virtual List<Consultation> Consultations { get; set; }
    }
}
