namespace Calculator.Services
{
    public interface ICalcService
    {
        int Add (int num1, int num2);
        int Sub (int num1, int num2);
        int Mult (int num1, int num2);
        string Div (int num1, int num2);
    }
}
