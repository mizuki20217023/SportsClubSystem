
namespace SportsClubProject
{
    partial class FixMenu
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
            this.FixLabel = new System.Windows.Forms.Label();
            this.UpdateNumberBox = new System.Windows.Forms.TextBox();
            this.SportsDataView = new System.Windows.Forms.DataGridView();
            this.TellBox = new System.Windows.Forms.TextBox();
            this.TellLabel = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.FixButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SportsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // FixLabel
            // 
            this.FixLabel.AutoSize = true;
            this.FixLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FixLabel.Location = new System.Drawing.Point(194, 31);
            this.FixLabel.Name = "FixLabel";
            this.FixLabel.Size = new System.Drawing.Size(288, 19);
            this.FixLabel.TabIndex = 2;
            this.FixLabel.Text = "修正する会員番号を入力してください";
            // 
            // UpdateNumberBox
            // 
            this.UpdateNumberBox.Location = new System.Drawing.Point(507, 31);
            this.UpdateNumberBox.Name = "UpdateNumberBox";
            this.UpdateNumberBox.Size = new System.Drawing.Size(100, 22);
            this.UpdateNumberBox.TabIndex = 3;
            // 
            // SportsDataView
            // 
            this.SportsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SportsDataView.Location = new System.Drawing.Point(59, 129);
            this.SportsDataView.Name = "SportsDataView";
            this.SportsDataView.RowHeadersWidth = 51;
            this.SportsDataView.RowTemplate.Height = 24;
            this.SportsDataView.Size = new System.Drawing.Size(682, 246);
            this.SportsDataView.TabIndex = 8;
            // 
            // TellBox
            // 
            this.TellBox.Location = new System.Drawing.Point(516, 90);
            this.TellBox.Name = "TellBox";
            this.TellBox.Size = new System.Drawing.Size(100, 22);
            this.TellBox.TabIndex = 14;
            // 
            // TellLabel
            // 
            this.TellLabel.AutoSize = true;
            this.TellLabel.Location = new System.Drawing.Point(513, 68);
            this.TellLabel.Name = "TellLabel";
            this.TellLabel.Size = new System.Drawing.Size(67, 15);
            this.TellLabel.TabIndex = 13;
            this.TellLabel.Text = "電話番号";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(313, 90);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(180, 22);
            this.AddressBox.TabIndex = 12;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(310, 68);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(37, 15);
            this.AddressLabel.TabIndex = 11;
            this.AddressLabel.Text = "住所";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(187, 90);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 22);
            this.NameBox.TabIndex = 10;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(184, 68);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(37, 15);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "氏名";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BackButton.Location = new System.Drawing.Point(172, 381);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(141, 58);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "戻る";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FixButton
            // 
            this.FixButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FixButton.Location = new System.Drawing.Point(494, 381);
            this.FixButton.Name = "FixButton";
            this.FixButton.Size = new System.Drawing.Size(141, 58);
            this.FixButton.TabIndex = 16;
            this.FixButton.Text = "修正";
            this.FixButton.UseVisualStyleBackColor = true;
            this.FixButton.Click += new System.EventHandler(this.FixButton_Click);
            // 
            // FixMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FixButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TellBox);
            this.Controls.Add(this.TellLabel);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SportsDataView);
            this.Controls.Add(this.UpdateNumberBox);
            this.Controls.Add(this.FixLabel);
            this.Name = "FixMenu";
            this.Text = "修正画面";
            this.Load += new System.EventHandler(this.FixMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SportsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FixLabel;
        private System.Windows.Forms.TextBox UpdateNumberBox;
        private System.Windows.Forms.DataGridView SportsDataView;
        private System.Windows.Forms.TextBox TellBox;
        private System.Windows.Forms.Label TellLabel;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button FixButton;
    }
}