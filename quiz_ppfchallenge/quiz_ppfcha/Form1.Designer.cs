namespace quiz_ppfcha
{
    partial class ppf_quiz
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
            this.main_panel = new System.Windows.Forms.Panel();
            this.start_panel = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.question_text = new System.Windows.Forms.TextBox();
            this.btn_cross = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.main_panel.SuspendLayout();
            this.start_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.CadetBlue;
            this.main_panel.Controls.Add(this.start_panel);
            this.main_panel.Controls.Add(this.question_text);
            this.main_panel.Controls.Add(this.btn_cross);
            this.main_panel.Controls.Add(this.btn_circle);
            this.main_panel.Location = new System.Drawing.Point(22, 38);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1797, 871);
            this.main_panel.TabIndex = 0;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // start_panel
            // 
            this.start_panel.BackColor = System.Drawing.Color.Teal;
            this.start_panel.Controls.Add(this.btn_start);
            this.start_panel.Controls.Add(this.textBox1);
            this.start_panel.Location = new System.Drawing.Point(0, 0);
            this.start_panel.Name = "start_panel";
            this.start_panel.Size = new System.Drawing.Size(1797, 871);
            this.start_panel.TabIndex = 4;
            this.start_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.start_panel_Paint);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_start.Font = new System.Drawing.Font("Century", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.MintCream;
            this.btn_start.Location = new System.Drawing.Point(539, 363);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(670, 285);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "始める";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(200, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1348, 65);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "〇×クイズ！！！";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // question_text
            // 
            this.question_text.Cursor = System.Windows.Forms.Cursors.Default;
            this.question_text.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_text.Location = new System.Drawing.Point(403, 149);
            this.question_text.Name = "question_text";
            this.question_text.Size = new System.Drawing.Size(880, 47);
            this.question_text.TabIndex = 2;
            this.question_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.question_text.TextChanged += new System.EventHandler(this.question_text_TextChanged);
            // 
            // btn_cross
            // 
            this.btn_cross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cross.Font = new System.Drawing.Font("Century Gothic", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cross.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_cross.Location = new System.Drawing.Point(1110, 466);
            this.btn_cross.Name = "btn_cross";
            this.btn_cross.Size = new System.Drawing.Size(173, 149);
            this.btn_cross.TabIndex = 1;
            this.btn_cross.Text = "×";
            this.btn_cross.UseVisualStyleBackColor = true;
            this.btn_cross.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_circle.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_circle.ForeColor = System.Drawing.Color.Red;
            this.btn_circle.Location = new System.Drawing.Point(403, 466);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(173, 149);
            this.btn_circle.TabIndex = 0;
            this.btn_circle.Text = "〇";
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.button1_Click);
            // 
            // ppf_quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 993);
            this.Controls.Add(this.main_panel);
            this.Name = "ppf_quiz";
            this.Text = "ppf_quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.start_panel.ResumeLayout(false);
            this.start_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button btn_cross;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.TextBox question_text;
        private System.Windows.Forms.Panel start_panel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_start;
    }
}

