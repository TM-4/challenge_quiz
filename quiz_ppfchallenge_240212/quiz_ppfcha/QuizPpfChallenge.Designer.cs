namespace quizPpfcha
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.startPanel = new System.Windows.Forms.Panel();
            this.BtnCreateQuestion = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tittleText = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.btnCross = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.questionText = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.startPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.mainPanel.Controls.Add(this.startPanel);
            this.mainPanel.Controls.Add(this.timeLabel);
            this.mainPanel.Controls.Add(this.btnCross);
            this.mainPanel.Controls.Add(this.btnCircle);
            this.mainPanel.Controls.Add(this.questionText);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(893, 597);
            this.mainPanel.TabIndex = 0;
            // 
            // startPanel
            // 
            this.startPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startPanel.AutoSize = true;
            this.startPanel.BackColor = System.Drawing.Color.Teal;
            this.startPanel.Controls.Add(this.BtnCreateQuestion);
            this.startPanel.Controls.Add(this.btnStart);
            this.startPanel.Controls.Add(this.tittleText);
            this.startPanel.Location = new System.Drawing.Point(3, 3);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(902, 596);
            this.startPanel.TabIndex = 4;
            // 
            // BtnCreateQuestion
            // 
            this.BtnCreateQuestion.Location = new System.Drawing.Point(691, 487);
            this.BtnCreateQuestion.Name = "BtnCreateQuestion";
            this.BtnCreateQuestion.Size = new System.Drawing.Size(150, 49);
            this.BtnCreateQuestion.TabIndex = 2;
            this.BtnCreateQuestion.Text = "問題を作成";
            this.BtnCreateQuestion.UseVisualStyleBackColor = true;
            this.BtnCreateQuestion.Click += new System.EventHandler(this.BtnCreateQuestionClick);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStart.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.MintCream;
            this.btnStart.Location = new System.Drawing.Point(246, 326);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(416, 150);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "始める";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
            // 
            // tittleText
            // 
            this.tittleText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tittleText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tittleText.Cursor = System.Windows.Forms.Cursors.Default;
            this.tittleText.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittleText.Location = new System.Drawing.Point(148, 79);
            this.tittleText.Name = "tittleText";
            this.tittleText.Size = new System.Drawing.Size(612, 65);
            this.tittleText.TabIndex = 0;
            this.tittleText.Text = "〇×クイズ！！！";
            this.tittleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.timeLabel.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(86, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(69, 77);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "0";
            // 
            // btnCross
            // 
            this.btnCross.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCross.AutoSize = true;
            this.btnCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCross.Font = new System.Drawing.Font("Century Gothic", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCross.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCross.Location = new System.Drawing.Point(553, 251);
            this.btnCross.MaximumSize = new System.Drawing.Size(150, 150);
            this.btnCross.Name = "btnCross";
            this.btnCross.Size = new System.Drawing.Size(150, 150);
            this.btnCross.TabIndex = 1;
            this.btnCross.Text = "×";
            this.btnCross.UseVisualStyleBackColor = true;
            this.btnCross.Click += new System.EventHandler(this.BtnCrossClick);
            // 
            // btnCircle
            // 
            this.btnCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCircle.AutoSize = true;
            this.btnCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCircle.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircle.ForeColor = System.Drawing.Color.Red;
            this.btnCircle.Location = new System.Drawing.Point(218, 251);
            this.btnCircle.MaximumSize = new System.Drawing.Size(150, 150);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(150, 150);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "〇";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.BtnCircleClick);
            // 
            // questionText
            // 
            this.questionText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionText.Cursor = System.Windows.Forms.Cursors.Default;
            this.questionText.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionText.Location = new System.Drawing.Point(12, 108);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(869, 47);
            this.questionText.TabIndex = 2;
            this.questionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(893, 597);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.Text = "ppf_quiz";
            this.Load += new System.EventHandler(this.PpfQuizForm);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnCross;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.TextBox questionText;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tittleText;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button BtnCreateQuestion;
    }
}

