using System;
using System.Windows.Forms;

namespace SportsClubProject
{
    public partial class MainMenu : Form
    {
        /// <summary>
        /// フォーム起動時に準備するメソッド
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登録管理画面に移行するためのメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMoveButtonClick(object sender, EventArgs e)
        {
            //サブメニューに移行
            SubMenu SubForm = new SubMenu();
            SubForm.Show();
            this.Visible = false;
        }

        /// <summary>
        /// システム終了時の確認処理のメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndButtonClick(object sender, EventArgs e)
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