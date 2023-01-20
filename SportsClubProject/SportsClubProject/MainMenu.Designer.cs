
namespace SportsClubProject
{
    partial class MainMenu
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FormMoveButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleLabel.Location = new System.Drawing.Point(143, 77);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(514, 40);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "HCSスポーツクラブ会員システム";
            // 
            // FormMoveButton
            // 
            this.FormMoveButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormMoveButton.Location = new System.Drawing.Point(295, 172);
            this.FormMoveButton.Name = "FormMoveButton";
            this.FormMoveButton.Size = new System.Drawing.Size(210, 78);
            this.FormMoveButton.TabIndex = 1;
            this.FormMoveButton.Text = "登録管理画面";
            this.FormMoveButton.UseVisualStyleBackColor = true;
            this.FormMoveButton.Click += new System.EventHandler(this.FormMoveButtonClick);
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndButton.Location = new System.Drawing.Point(295, 283);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(210, 78);
            this.EndButton.TabIndex = 2;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButtonClick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.FormMoveButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "MainMenu";
            this.Text = "トップメニュー";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button FormMoveButton;
        private System.Windows.Forms.Button EndButton;
    }
}

