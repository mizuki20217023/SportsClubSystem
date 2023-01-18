using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsClubProject
{
    public partial class SubMenu : Form
    {
        public SubMenu()
        {
            InitializeComponent();
        }

        private void RegisterMoveButton_Click(object sender, EventArgs e)
        {
            //登録画面に移行
            RegisterMenu RegisterForm = new RegisterMenu();
            RegisterForm.Show();
            this.Visible = false;
        }

        private void SearchMoveButton_Click(object sender, EventArgs e)
        {
            //検索画面に移行
            SearchMenu SearchForm = new SearchMenu();
            SearchForm.Show();
            this.Visible = false;
        }

        private void FixMoveButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteFormMove_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //登録管理画面に移行
            MainMenu MainForm = new MainMenu();
            MainForm.Show();
            this.Visible = false;
        }

        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            // テーブルを作成する  
            using (var con = new SQLiteConnection("Data Source=SportsClub.db"))
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

        private void DeleteTableButton_Click(object sender, EventArgs e)
        {
            // コネクションを開いてテーブル削除して閉じる 
            using (var con = new SQLiteConnection("Data Source=SportsClub.db"))
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
