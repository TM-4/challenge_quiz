namespace quizPpfcha
{
    partial class PpfQuiz
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
            this.btn_cross = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.question_text = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.startPanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.startPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.mainPanel.Controls.Add(this.startPanel);
            this.mainPanel.Controls.Add(this.btn_cross);
            this.mainPanel.Controls.Add(this.btn_circle);
            this.mainPanel.Controls.Add(this.question_text);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(893, 597);
            this.mainPanel.TabIndex = 0;
            // 
            // btn_cross
            // 
            this.btn_cross.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_cross.AutoSize = true;
            this.btn_cross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cross.Font = new System.Drawing.Font("Century Gothic", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cross.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_cross.Location = new System.Drawing.Point(553, 251);
            this.btn_cross.MaximumSize = new System.Drawing.Size(150, 150);
            this.btn_cross.Name = "btn_cross";
            this.btn_cross.Size = new System.Drawing.Size(150, 150);
            this.btn_cross.TabIndex = 1;
            this.btn_cross.Text = "×";
            this.btn_cross.UseVisualStyleBackColor = true;
            this.btn_cross.Click += new System.EventHandler(this.Button2Click);
            // 
            // btn_circle
            // 
            this.btn_circle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_circle.AutoSize = true;
            this.btn_circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_circle.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_circle.ForeColor = System.Drawing.Color.Red;
            this.btn_circle.Location = new System.Drawing.Point(218, 251);
            this.btn_circle.MaximumSize = new System.Drawing.Size(150, 150);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(150, 150);
            this.btn_circle.TabIndex = 0;
            this.btn_circle.Text = "〇";
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.Button1Click);
            // 
            // question_text
            // 
            this.question_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.question_text.Cursor = System.Windows.Forms.Cursors.Default;
            this.question_text.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_text.Location = new System.Drawing.Point(12, 108);
            this.question_text.Name = "question_text";
            this.question_text.Size = new System.Drawing.Size(869, 47);
            this.question_text.TabIndex = 2;
            this.question_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(148, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(610, 65);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "〇×クイズ！！！";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.AutoSize = true;
            this.btn_start.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_start.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.MintCream;
            this.btn_start.Location = new System.Drawing.Point(246, 326);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(414, 150);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "始める";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.BtnStartClick);
            // 
            // startPanel
            // 
            this.startPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startPanel.AutoSize = true;
            this.startPanel.BackColor = System.Drawing.Color.Teal;
            this.startPanel.Controls.Add(this.btn_start);
            this.startPanel.Controls.Add(this.textBox1);
            this.startPanel.Location = new System.Drawing.Point(3, 3);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(900, 596);
            this.startPanel.TabIndex = 4;
            // 
            // PpfQuiz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(893, 597);
            this.Controls.Add(this.mainPanel);
            this.Name = "PpfQuiz";
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
        private System.Windows.Forms.Button btn_cross;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.TextBox question_text;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox textBox1;
    }
}

