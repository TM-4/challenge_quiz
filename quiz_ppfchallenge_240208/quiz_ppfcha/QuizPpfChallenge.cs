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

namespace quizPpfcha
{
    public partial class PpfQuiz : System.Windows.Forms.Form
    {
        /// <summary>
        /// フィールドと定数
        /// </summary>
        #region
        private List<Quiz> quizzes;
        private int currentQuizIndex;
        private int correctAnswers = 0; // 正解したクイズの数
        private Random random = new Random();

        private const string CorrectAnswerText = "はい";
        private const string CorrectMessage = "正解！";
        #endregion


        public PpfQuiz()
        #region
        {
            InitializeComponent();
        }
        #endregion


        /// <summary>
        /// csvから問題を表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PpfQuizForm(object sender, EventArgs e)
        #region
        {
            //相対パス
            string filePath = "questions.csv";
            //絶対パス
            //string filePath = "C:\\Users\\cotoc\\Desktop\\quiz_ppfchallenge\\questions.csv";

            try
            {
                quizzes = QuizLoader.LoadQuizzes(filePath);
                quizzes = quizzes.OrderBy(q => random.Next()).ToList();

                // 最初のクイズを表示
                ShowQuiz();
            }
            catch (Exception ex)
            {
                // エラーメッセージを表示
                MessageBox.Show($"CSVファイルの読み込み中にエラーが発生しました。\n{ex.Message}");
            }
        }
        #endregion


        /// <summary>
        /// ユーザーの回答が正解かどうかを判定し、次のクイズを表示
        /// </summary>
        /// <param name="userAnswer"></param>
        private void CheckAnswer(bool userAnswer)
        #region
        {
            // ユーザーの回答が正解かどうかを判定
            if (userAnswer == (quizzes[currentQuizIndex].Answer == CorrectAnswerText))
            {
                MessageBox.Show(CorrectMessage);
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
                    //相対パス
                    PlaySound("perfect_sound.wav");
                    //絶対パス
                    //PlaySound(@"C:\Users\cotoc\Desktop\quiz_ppfchallenge\perfect_sound.wav");
                    MessageBox.Show("Excellent!!");
                    Thread.Sleep(2000);
                }

                Application.Exit();
            }
        }
        #endregion


        /// <summary>
        /// クリックイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void BtnStartClick(object sender, EventArgs e)
        {
            startPanel.Visible = false;
            mainPanel.Visible = true;
        }

        private void Button1Click(object sender, EventArgs e)
        {
            CheckAnswer(true);
        }

        private void Button2Click(object sender, EventArgs e)
        {
            CheckAnswer(false);
        }
        #endregion


        /// <summary>
        /// クイズを表示する
        /// </summary>
        private void ShowQuiz()
        #region
        {
            if (currentQuizIndex < quizzes.Count)
            {
                question_text.Text = quizzes[currentQuizIndex].Question;
            }
        }
        #endregion


        /// <summary>
        /// 音を鳴らす
        /// </summary>
        /// <param name="filePath"></param>
        private void PlaySound(string filePath)
        #region
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
        #endregion
    }

}
