using InvestME.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestME.DAL.Models
{  
    public class Investments
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public Acoes Acao { get; set; }

        [Required, DefaultValue(0)]
        public StatusInvestments Status { get; set; }

        [Required]
        public float ValueInvested { get; set; }

    }
}
