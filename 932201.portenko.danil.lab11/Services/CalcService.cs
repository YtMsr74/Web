namespace Calculator.Services
{
    public class CalcService : ICalcService
    {
        public int Add(int num1, int num2) { return num1 + num2; }
        public int Sub(int num1, int num2) { return num1 - num2; }
        public int Mult(int num1, int num2) { return num1 * num2; }
        public string Div(int num1, int num2)
        {
            if (num2 == 0) return "Деление на ноль";
            else return (num1/num2).ToString();
        }
    }
}
