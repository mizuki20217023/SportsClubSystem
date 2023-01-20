
namespace SportsClubProject
{
    partial class RegisterMenu
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.TellLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.TellBox = new System.Windows.Forms.TextBox();
            this.SportsDataView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.VerificationButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SportsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(122, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(37, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "名前";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(323, 35);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(37, 15);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "住所";
            // 
            // TellLabel
            // 
            this.TellLabel.AutoSize = true;
            this.TellLabel.Location = new System.Drawing.Point(524, 35);
            this.TellLabel.Name = "TellLabel";
            this.TellLabel.Size = new System.Drawing.Size(67, 15);
            this.TellLabel.TabIndex = 2;
            this.TellLabel.Text = "電話番号";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(125, 53);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(148, 22);
            this.NameBox.TabIndex = 3;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(326, 53);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(148, 22);
            this.AddressBox.TabIndex = 4;
            // 
            // TellBox
            // 
            this.TellBox.Location = new System.Drawing.Point(527, 53);
            this.TellBox.Name = "TellBox";
            this.TellBox.Size = new System.Drawing.Size(148, 22);
            this.TellBox.TabIndex = 5;
            // 
            // SportsDataView
            // 
            this.SportsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SportsDataView.Location = new System.Drawing.Point(59, 97);
            this.SportsDataView.Name = "SportsDataView";
            this.SportsDataView.RowHeadersWidth = 51;
            this.SportsDataView.RowTemplate.Height = 24;
            this.SportsDataView.Size = new System.Drawing.Size(682, 246);
            this.SportsDataView.TabIndex = 6;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BackButton.Location = new System.Drawing.Point(85, 365);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(141, 58);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "戻る";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // VerificationButton
            // 
            this.VerificationButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.VerificationButton.Location = new System.Drawing.Point(330, 365);
            this.VerificationButton.Name = "VerificationButton";
            this.VerificationButton.Size = new System.Drawing.Size(141, 58);
            this.VerificationButton.TabIndex = 11;
            this.VerificationButton.Text = "確認";
            this.VerificationButton.UseVisualStyleBackColor = true;
            this.VerificationButton.Click += new System.EventHandler(this.VerificationButtonClick);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RegisterButton.Location = new System.Drawing.Point(575, 365);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(141, 58);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "登録";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButtonClick);
            // 
            // RegisterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.VerificationButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.SportsDataView);
            this.Controls.Add(this.TellBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.TellLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "RegisterMenu";
            this.Text = "登録画面";
            this.Load += new System.EventHandler(this.RegisterMenuLoad);
            ((System.ComponentModel.ISupportInitialize)(this.SportsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label TellLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox TellBox;
        private System.Windows.Forms.DataGridView SportsDataView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button VerificationButton;
        private System.Windows.Forms.Button RegisterButton;
    }
}