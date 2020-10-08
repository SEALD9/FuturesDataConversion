namespace 先物データ形式変換
{
    partial class Form1
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
            this.FBD_先物データフォルダ = new System.Windows.Forms.FolderBrowserDialog();
            this.TxtBox_フォルダ選択 = new System.Windows.Forms.TextBox();
            this.Btn_フォルダ選択 = new System.Windows.Forms.Button();
            this.Btn_変換実行 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox_フォルダ選択
            // 
            this.TxtBox_フォルダ選択.Location = new System.Drawing.Point(12, 12);
            this.TxtBox_フォルダ選択.Name = "TxtBox_フォルダ選択";
            this.TxtBox_フォルダ選択.Size = new System.Drawing.Size(547, 19);
            this.TxtBox_フォルダ選択.TabIndex = 0;
            // 
            // Btn_フォルダ選択
            // 
            this.Btn_フォルダ選択.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_フォルダ選択.Location = new System.Drawing.Point(565, 10);
            this.Btn_フォルダ選択.Name = "Btn_フォルダ選択";
            this.Btn_フォルダ選択.Size = new System.Drawing.Size(75, 23);
            this.Btn_フォルダ選択.TabIndex = 1;
            this.Btn_フォルダ選択.Text = "フォルダ選択";
            this.Btn_フォルダ選択.UseVisualStyleBackColor = true;
            this.Btn_フォルダ選択.Click += new System.EventHandler(this.Btn_フォルダ選択_Click);
            // 
            // Btn_変換実行
            // 
            this.Btn_変換実行.Location = new System.Drawing.Point(565, 40);
            this.Btn_変換実行.Name = "Btn_変換実行";
            this.Btn_変換実行.Size = new System.Drawing.Size(75, 23);
            this.Btn_変換実行.TabIndex = 2;
            this.Btn_変換実行.Text = "変換";
            this.Btn_変換実行.UseVisualStyleBackColor = true;
            this.Btn_変換実行.Click += new System.EventHandler(this.Btn_変換実行_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 75);
            this.Controls.Add(this.Btn_変換実行);
            this.Controls.Add(this.Btn_フォルダ選択);
            this.Controls.Add(this.TxtBox_フォルダ選択);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FBD_先物データフォルダ;
        private System.Windows.Forms.TextBox TxtBox_フォルダ選択;
        private System.Windows.Forms.Button Btn_フォルダ選択;
        private System.Windows.Forms.Button Btn_変換実行;
    }
}

