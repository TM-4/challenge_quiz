using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Quiz
#region
{
    /// <summary>
    /// クイズの情報を取得
    /// </summary>
    /// <param name="question"></param>
    /// <param name="choices"></param>
    /// <param name="answer"></param>
    public Quiz(string question, string choices, string answer)
    {
        Question = question;
        Choices = choices;
        Answer = answer;
    }

    public string Question;
    public string Choices;
    public string Answer;
}
#endregion
