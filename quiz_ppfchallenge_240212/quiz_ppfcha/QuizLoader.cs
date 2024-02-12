using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class QuizLoader
{
    #region 関数

    /// <summary>
    /// csvファイルからクイズを読み込む
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public static List<Quiz> LoadQuizzes(string filePath)
    {
        List<Quiz> quizzes = new List<Quiz>();

        try
        {
            // CSVファイルを読み込み
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                // カンマで区切って各フィールドを取得
                string[] fields = line.Split(',');

                // 問題、選択肢、答えを取得
                string question = fields[0];
                string choices = fields[1];
                string answer = fields[2];

                // Quizオブジェクトを作成してリストに追加
                quizzes.Add(new Quiz(question, choices, answer));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"エラー: {ex.Message}");
        }

        return quizzes;
    }
    #endregion
}

