using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace createQuestion
{
    /// <summary>
    /// CreateQuestionFormクラス
    /// </summary>
    public partial class CreateQuestionForm : Form
    {
        public Quiz NewQuestion { get; private set; }

        #region　コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CreateQuestionForm()
        {
            InitializeComponent();
        }

        #endregion

        #region イベント

        /// <summary>
        /// 問題作成ボタン
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void BtnSaveClick(object sender, EventArgs e)
        {
            string question = txtQuestion.Text;

            try
            {
                // CSVファイルに新しい問題を追加する
                using (StreamWriter sw = File.AppendText("questions.csv"))
                {
                    sw.Write(question + Environment.NewLine);
                }
                MessageBox.Show("新しい問題が追加されました！");
            }
            catch (Exception ex)
            {
                // エラーメッセージを表示
                MessageBox.Show($"ファイルへの書き込み中にエラーが発生しました。\n{ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// キャンセルボタン
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void BtnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
