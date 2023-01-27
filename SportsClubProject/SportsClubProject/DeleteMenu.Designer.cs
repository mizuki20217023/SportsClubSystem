
namespace SportsClubProject
{
    partial class DeleteMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteBox = new System.Windows.Forms.TextBox();
            this.SportsDataView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SportsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(162, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "削除する会員の会員番号を入力してください";
            // 
            // DeleteBox
            // 
            this.DeleteBox.Location = new System.Drawing.Point(539, 44);
            this.DeleteBox.Name = "DeleteBox";
            this.DeleteBox.Size = new System.Drawing.Size(100, 22);
            this.DeleteBox.TabIndex = 5;
            // 
            // SportsDataView
            // 
            this.SportsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SportsDataView.Location = new System.Drawing.Point(59, 102);
            this.SportsDataView.Name = "SportsDataView";
            this.SportsDataView.RowHeadersWidth = 51;
            this.SportsDataView.RowTemplate.Height = 24;
            this.SportsDataView.Size = new System.Drawing.Size(682, 246);
            this.SportsDataView.TabIndex = 9;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Tomato;
            this.BackButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BackButton.Location = new System.Drawing.Point(151, 354);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(141, 58);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "戻る";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteButton.Location = new System.Drawing.Point(509, 354);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(141, 58);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // DeleteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SportsDataView);
            this.Controls.Add(this.DeleteBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteMenu";
            this.Text = "削除画面";
            this.Load += new System.EventHandler(this.DeleteMenuLoad);
            ((System.ComponentModel.ISupportInitialize)(this.SportsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeleteBox;
        private System.Windows.Forms.DataGridView SportsDataView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}