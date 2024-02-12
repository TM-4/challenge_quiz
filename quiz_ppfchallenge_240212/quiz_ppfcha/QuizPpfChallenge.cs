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
using createQuestion;
using logger;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quizPpfcha
{
    /// <summary>
    /// メインフォームクラス
    /// </summary>
    public partial class MainForm : System.Windows.Forms.Form
    {

        #region　グローバル変数

        /// <summary>
        /// クイズリスト
        /// </summary>
        private List<Quiz> quizzes;

        /// <summary>
        /// カレントクイズインデックス
        /// </summary>
        private int currentQuizIndex;

        /// <summary>
        /// 正解したクイズの数
        /// </summary>
        private int correctAnswers = 0;

        /// <summary>
        /// 擬似乱数クラス
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// タイマーのスレッド
        /// </summary>
        private System.Threading.Timer threadTimer;

        /// <summary>
        /// 経過時間
        /// </summary>
        private int elapsedTime;

        /// <summary>
        /// タイマーが動いているか
        /// </summary>
        private bool isTimerRunning = false;

        /// <summary>
        /// ファイルパス
        /// </summary>
        string filePath = "questions.csv";
        //絶対パス
        //string filePath = "C:\\Users\\cotoc\\Desktop\\quiz_ppfchallenge\\questions.csv";

        /// <summary>
        /// log.txtを作成
        /// </summary>
        private Logger logger = new Logger("log.txt");


        #endregion

        #region　定数

        private const string CorrectAnswerText = "はい";
        private const string CorrectMessage = "正解！";

        #endregion

        #region　コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region　イベント

        /// <summary>
        /// logファイルに記録する
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void PpfQuizForm(object sender, EventArgs e)
        {
            logger.Log("アプリが起動しました。");
            logger = new Logger("log.txt");
        }

        /// <summary>
        /// クリックイベントハンドラ
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void BtnStartClick(object sender, EventArgs e)
        {
            LoadQuizzesFromFile(filePath);
            startPanel.Visible = false;
            mainPanel.Visible = true;
            StartTimer();
        }

        /// <summary>
        /// 〇ボタン
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void BtnCircleClick(object sender, EventArgs e)
        {
            CheckAnswer(true);
        }

        /// <summary>
        /// ×ボタン
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void BtnCrossClick(object sender, EventArgs e)
        {
            CheckAnswer(false);
        }

        /// <summary>
        /// 問題作成ボタン
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void BtnCreateQuestionClick(object sender, EventArgs e)
        {
            //問題作成フォーム追加
            CreateQuestionForm createQuestionForm = new CreateQuestionForm();

            // MainForm を親フォームとして設定
            createQuestionForm.Owner = this;

            // モーダルダイアログとしてフォームを表示し、その結果を取得
            DialogResult result = createQuestionForm.ShowDialog();

            // 新しい問題を追加
            if (result == DialogResult.OK)
            {
                // 新しい問題を作成
                if (createQuestionForm.NewQuestion != null)
                {
                    
                }
            }
            else
            {
                this.Close();
            }
        }

        #endregion

        #region　関数

        /// <summary>
        /// クイズロード
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        private void LoadQuizzesFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                }

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

        /// <summary>
        /// ユーザーの回答が正解かどうかを判定し、次のクイズを表示
        /// </summary>
        /// <param name="userAnswer">回答</param>
        private void CheckAnswer(bool userAnswer)
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
                elapsedTime = 0;
                timeLabel.Text = "0";
            }
            else
            {
                StopTimer();
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

        /// <summary>
        /// クイズを表示する
        /// </summary>
        private void ShowQuiz()
        {
            if (currentQuizIndex < quizzes.Count)
            {
                questionText.Text = quizzes[currentQuizIndex].Question;
            }
        }

        /// <summary>
        /// 音を鳴らす
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
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

        /// <summary>
        /// タイマースタート
        /// </summary>
        private void StartTimer()
        {
            // タイマーが既に実行中の場合は一旦停止
            if (threadTimer != null)
                StopTimer();

            // タイマーを作成、開始
            threadTimer = new System.Threading.Timer(TimerCallback, null, 0, 1000);
            isTimerRunning = true;
        }

        /// <summary>
        /// タイマーコールバック
        /// </summary>
        /// <param name="state">オブジェクト</param>
        private void TimerCallback(object state)
        {
            if (!isTimerRunning)
                return;

            elapsedTime++;

            Invoke(new Action(() =>
            {
                timeLabel.Text = elapsedTime.ToString();
            }));
        }

        /// <summary>
        /// タイマーストップ
        /// </summary>
        private void StopTimer()
        {
            if (threadTimer != null)
            {
                threadTimer.Change(Timeout.Infinite, Timeout.Infinite);
                threadTimer.Dispose();
                threadTimer = null;
            }

            isTimerRunning = false;
        }

        #endregion

    }
}
