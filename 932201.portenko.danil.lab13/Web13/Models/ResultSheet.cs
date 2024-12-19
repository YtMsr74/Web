using System.ComponentModel.DataAnnotations;

namespace Web13.Models
{
    public class ResultSheet
    {
        public static int total = 0;
        public static int correct = 0;
        public static List<Question> questionList = new List<Question>();

        public static void Clear()
        {
            total = 0;
            correct = 0;
            questionList.Clear();
        }

        public static void Add(Question question)
        {
            questionList.Add(question);
        }
    }
}
