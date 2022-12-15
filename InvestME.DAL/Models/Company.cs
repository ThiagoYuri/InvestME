using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestME.DAL.Models
{
    public class Company
    {
        [Key]
        public string CodeAcao { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }

        public List<Acoes>? Companies { get; set; }
    }
}
