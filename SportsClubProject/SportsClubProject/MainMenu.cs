using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsClubProject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void FormMoveButton_Click(object sender, EventArgs e)
        {
            //サブメニューに移行
            SubMenu SubForm = new SubMenu();
            SubForm.Show();
            this.Visible = false;
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            //システム終了の確認ダイアログ
            if (MessageBox.Show("終了してもよろしいでしょうか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //アプリケーション終了
                Application.Exit();
            }
        }
    }
}
