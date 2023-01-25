
namespace SportsClubProject
{
    partial class SearchMenu
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
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SportsDataView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SportsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SearchLabel.Location = new System.Drawing.Point(159, 53);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(342, 19);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "検索する会員の会員番号を入力してください";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(541, 50);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 22);
            this.SearchBox.TabIndex = 2;
            // 
            // SportsDataView
            // 
            this.SportsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SportsDataView.Location = new System.Drawing.Point(59, 90);
            this.SportsDataView.Name = "SportsDataView";
            this.SportsDataView.RowHeadersWidth = 51;
            this.SportsDataView.RowTemplate.Height = 24;
            this.SportsDataView.Size = new System.Drawing.Size(682, 246);
            this.SportsDataView.TabIndex = 7;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BackButton.Location = new System.Drawing.Point(97, 354);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(141, 58);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "戻る";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SearchButton.Location = new System.Drawing.Point(563, 354);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(141, 58);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "検索";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // SearchMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SportsDataView);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchLabel);
            this.Name = "SearchMenu";
            this.Text = "会員検索";
            this.Load += new System.EventHandler(this.SearchMenuLoad);
            ((System.ComponentModel.ISupportInitialize)(this.SportsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView SportsDataView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SearchButton;
    }
}