using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quiz_ppfcha
{
    public partial class ppf_quiz : System.Windows.Forms.Form
    {

        private List<Quiz> quizzes;
        private int currentQuizIndex;
        private int correctAnswers = 0; // 正解したクイズの数
        private Random random = new Random();

        public ppf_quiz()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string directory = @"C:\Users\cotoc\Desktop\quiz_ppfchallenge";
            string filePath = Path.Combine(directory, "questions.csv");
            //string filePath = @"C:\Users\cotoc\Desktop\quiz_ppfchallenge\questions.csv";
            quizzes = QuizLoader.LoadQuizzes(filePath);
            quizzes = quizzes.OrderBy(q => random.Next()).ToList();


            // 最初のクイズを表示
            ShowQuiz();
        }


        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void question_text_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CheckAnswer(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckAnswer(false);
        }


        private void start_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            start_panel.Visible = false;
            main_panel.Visible = true;
        }

        private void CheckAnswer(bool userAnswer)
        {
            // ユーザーの回答が正解かどうかを判定
            if (userAnswer == (quizzes[currentQuizIndex].Answer == "はい"))
            {
                MessageBox.Show("正解！");
                correctAnswers++;
            }
            else
            {
                MessageBox.Show($"不正解。正解は「{quizzes[currentQuizIndex].Answer}」です。");
            }

            // 次のクイズを表示
            currentQuizIndex++;
            if (currentQuizIndex < quizzes.Count)
            {
                ShowQuiz();
            }
            else
            {
                double accuracy = (double)correctAnswers / quizzes.Count * 100; // 正答率を計算
                MessageBox.Show("クイズが全問終了しました！！");
                MessageBox.Show("あなたの正解率は" + accuracy + "%です！");
                if (accuracy == 100)
                {
                    string directory = @"C:\Users\cotoc\Desktop\quiz_ppfchallenge";
                    string soundFilePath = Path.Combine(directory, "perfect_sound.wav");
                    PlaySound(soundFilePath);
                    //PlaySound(@"C:\Users\cotoc\Desktop\quiz_ppfchallenge\perfect_sound.wav");
                    MessageBox.Show("Excellent!!");
                    Thread.Sleep(2000);
                }

                Application.Exit();
            }
        }

        private void ShowQuiz()
        {
            // クイズを表示する処理
            if (currentQuizIndex < quizzes.Count)
            {
                question_text.Text = quizzes[currentQuizIndex].Question;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void PlaySound(string filePath)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(filePath);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"音声ファイルの再生中にエラーが発生しました。\n{ex.Message}");
            }
        }
    }

    public class Quiz
    {
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


    public class QuizLoader
    {
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
                    string choices = fields[1] ;
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
    }
}
