using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestME.DAL.Models
{
    public class Acoes
    {
        public Acoes()
        {
            checkFilterMain();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public float? Preco { get; set; }

        [Required]
        public float? PVPA { get; set; }

        [Required]
        public float? PBIT { get; set; }

        [Required]
        public float? EVBIT { get; set; }

        [Required]
        public float? DividendYield { get; set; }

        [Required]
        public float? VolumeFinanceiro { get; set; }

        [Required]
        public DateTime DateLote { get; set; }

        [Required]
        public Company Company { get; set; }

        [Required]        
        public bool FilterMain { get; set; }
        public void checkFilterMain()
        {
            if (DividendYield >= 0 && VolumeFinanceiro > 1000 && EVBIT > 1 && PVPA >= 0)
                FilterMain = true;
        }
        
    }
}
