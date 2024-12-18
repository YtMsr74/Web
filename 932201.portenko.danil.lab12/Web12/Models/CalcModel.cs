using System.ComponentModel.DataAnnotations;

namespace Web12.Models
{
    public class CalcModel
    {
        [Required] public double Num1 { get; set; }
        [Required] public double Num2 { get; set; }
        [Required] public string Operation { get; set; }
    }
}
