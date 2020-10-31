using System.ComponentModel.DataAnnotations;

namespace CoffeeHouse.Models
{
    public class MaquinaCafe
    {
        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Range(0, 100, ErrorMessage = "Campo {0}: Apenas números positivos")]
        [Display(Name = "R$ 0,01")]
        public int UmCentavo { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Range(0, 100, ErrorMessage = "Campo {0}: Apenas números positivos")]
        [Display(Name = "R$ 0,05")]
        public int CincoCentavo { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Range(0, 100, ErrorMessage = "Campo {0}: Apenas números positivos")]
        [Display(Name = "R$ 0,10")]
        public int DezCentavo { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Range(0, 100, ErrorMessage = "Campo {0}: Apenas números positivos")]
        [Display(Name = "R$ 0,25")]
        public int VinteCincoCentavo { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Range(0, 100, ErrorMessage = "Campo {0}: Apenas números positivos")]
        [Display(Name = "R$ 0,50")]
        public int CinquentaCentavo { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Range(0, 100, ErrorMessage = "Campo {0}: Apenas números positivos")]
        [Display(Name = "R$ 1,00")]
        public int UmReal { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Display(Name = "Selecione o café")]
        public int TipoCafe { get; set; }

        [DataType(DataType.Currency)]
        public double ValorCafe { get; set; }

        [DataType(DataType.Currency)]
        public double Troco { get; set; }

        [DataType(DataType.Currency)]
        public double ValorAceito { get; set; }

        public string Descricao { get; set; }

        public MaquinaCafe()
        {
        }
    }
}
