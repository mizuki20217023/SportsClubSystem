using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsClubProject
{
    public partial class SubMenu : Form
    {
        /// <summary>
        /// フォーム起動時に準備
        /// </summary>
        public SubMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登録画面に移動する処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterMoveButtonClick(object sender, EventArgs e)
        {
            //登録画面に移動
            RegisterMenu RegisterForm = new RegisterMenu();
            RegisterForm.Show();
            this.Visible = false;
        }

        /// <summary>
        /// 検索画面に移動する処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchMoveButtonClick(object sender, EventArgs e)
        {
            //検索画面に移動
            SearchMenu SearchForm = new SearchMenu();
            SearchForm.Show();
            this.Visible = false;
        }

        /// <summary>
        /// 修正画面に移動する処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FixMoveButtonClick(object sender, EventArgs e)
        {
            //修正画面に移動
            FixMenu FixForm = new FixMenu();
            FixForm.Show();
            this.Visible = false;
        }

        /// <summary>
        /// 削除画面に移動する処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteFormMoveClick(object sender, EventArgs e)
        {
            //削除画面に移動
            DeleteMenu DeleteForm = new DeleteMenu();
            DeleteForm.Show();
            this.Visible = false;
        }

        /// <summary>
        /// 登録画面に移動する処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButtonClick(object sender, EventArgs e)
        {
            //登録管理画面に移動
            MainMenu MainForm = new MainMenu();
            MainForm.Show();
            this.Visible = false;
        }

        /// <summary>
        /// テーブルを作成する処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateTableButtonClick(object sender, EventArgs e)
        {
            // テーブルを作成する
            using (SQLiteConnection con = new SQLiteConnection("Data Source=SportsClub.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                        "create table SportsProduct(MEMBERNUMBER INTEGER  PRIMARY KEY AUTOINCREMENT,NAME TEXT, ADDRESS TEXT, TELL INTEGER)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        
        /// <summary>
        /// テーブルを削除する処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteTableButtonClick(object sender, EventArgs e)
        {
            // コネクションを開いてテーブル削除して閉じる 
            using (SQLiteConnection con = new SQLiteConnection("Data Source=SportsClub.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText = "drop table SportsProduct";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
