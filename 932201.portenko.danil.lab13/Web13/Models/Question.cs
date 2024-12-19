using System.ComponentModel.DataAnnotations;

namespace Web13.Models
{
    public class Question
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int oper { get; set; }
        public int answer { get; set; }
        public string eq { get; set; }
        [Required(ErrorMessage = "Write any answer")]
        [Range(-20,20)]
        public string guess { get; set; }

        public Question()
        {
            Random rand = new Random();
            oper = rand.Next(2);
            num1 = rand.Next(10);
            num2 = rand.Next(10);
            if (oper == 0)
            {
                answer = num1 + num2;
                eq = $"{num1} + {num2} =";
            }
            else
            {
                answer = num1 - num2;
                eq = $"{num1} - {num2} =";
            }
        }
    }
}
