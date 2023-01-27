
namespace SportsClubProject
{
    partial class SubMenu
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
            this.BackButton = new System.Windows.Forms.Button();
            this.RegisterMoveButton = new System.Windows.Forms.Button();
            this.SearchMoveButton = new System.Windows.Forms.Button();
            this.FixMoveButton = new System.Windows.Forms.Button();
            this.DeleteFormMove = new System.Windows.Forms.Button();
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.DeleteTableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Tomato;
            this.BackButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BackButton.Location = new System.Drawing.Point(85, 349);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(145, 65);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "戻る";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // RegisterMoveButton
            // 
            this.RegisterMoveButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RegisterMoveButton.Location = new System.Drawing.Point(85, 67);
            this.RegisterMoveButton.Name = "RegisterMoveButton";
            this.RegisterMoveButton.Size = new System.Drawing.Size(284, 109);
            this.RegisterMoveButton.TabIndex = 1;
            this.RegisterMoveButton.Text = "会員情報登録";
            this.RegisterMoveButton.UseVisualStyleBackColor = true;
            this.RegisterMoveButton.Click += new System.EventHandler(this.RegisterMoveButtonClick);
            // 
            // SearchMoveButton
            // 
            this.SearchMoveButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SearchMoveButton.Location = new System.Drawing.Point(431, 67);
            this.SearchMoveButton.Name = "SearchMoveButton";
            this.SearchMoveButton.Size = new System.Drawing.Size(284, 109);
            this.SearchMoveButton.TabIndex = 2;
            this.SearchMoveButton.Text = "会員情報検索";
            this.SearchMoveButton.UseVisualStyleBackColor = true;
            this.SearchMoveButton.Click += new System.EventHandler(this.SearchMoveButtonClick);
            // 
            // FixMoveButton
            // 
            this.FixMoveButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FixMoveButton.Location = new System.Drawing.Point(85, 206);
            this.FixMoveButton.Name = "FixMoveButton";
            this.FixMoveButton.Size = new System.Drawing.Size(284, 109);
            this.FixMoveButton.TabIndex = 3;
            this.FixMoveButton.Text = "会員情報修正";
            this.FixMoveButton.UseVisualStyleBackColor = true;
            this.FixMoveButton.Click += new System.EventHandler(this.FixMoveButtonClick);
            // 
            // DeleteFormMove
            // 
            this.DeleteFormMove.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteFormMove.Location = new System.Drawing.Point(431, 206);
            this.DeleteFormMove.Name = "DeleteFormMove";
            this.DeleteFormMove.Size = new System.Drawing.Size(284, 109);
            this.DeleteFormMove.TabIndex = 4;
            this.DeleteFormMove.Text = "会員情報削除";
            this.DeleteFormMove.UseVisualStyleBackColor = true;
            this.DeleteFormMove.Click += new System.EventHandler(this.DeleteFormMoveClick);
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CreateTableButton.Location = new System.Drawing.Point(328, 349);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(145, 65);
            this.CreateTableButton.TabIndex = 5;
            this.CreateTableButton.Text = "テーブル作成";
            this.CreateTableButton.UseVisualStyleBackColor = true;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButtonClick);
            // 
            // DeleteTableButton
            // 
            this.DeleteTableButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteTableButton.Location = new System.Drawing.Point(570, 349);
            this.DeleteTableButton.Name = "DeleteTableButton";
            this.DeleteTableButton.Size = new System.Drawing.Size(145, 65);
            this.DeleteTableButton.TabIndex = 6;
            this.DeleteTableButton.Text = "テーブル削除";
            this.DeleteTableButton.UseVisualStyleBackColor = true;
            this.DeleteTableButton.Click += new System.EventHandler(this.DeleteTableButtonClick);
            // 
            // SubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteTableButton);
            this.Controls.Add(this.CreateTableButton);
            this.Controls.Add(this.DeleteFormMove);
            this.Controls.Add(this.FixMoveButton);
            this.Controls.Add(this.SearchMoveButton);
            this.Controls.Add(this.RegisterMoveButton);
            this.Controls.Add(this.BackButton);
            this.Name = "SubMenu";
            this.Text = "サブメニュー";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button RegisterMoveButton;
        private System.Windows.Forms.Button SearchMoveButton;
        private System.Windows.Forms.Button FixMoveButton;
        private System.Windows.Forms.Button DeleteFormMove;
        private System.Windows.Forms.Button CreateTableButton;
        private System.Windows.Forms.Button DeleteTableButton;
    }
}