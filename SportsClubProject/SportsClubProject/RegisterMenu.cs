using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsClubProject
{
    public partial class RegisterMenu : Form
    {
        public RegisterMenu()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //会員情報を登録する処理
            using (SQLiteConnection con = new SQLiteConnection("Data Source=SportsClub.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    //登録処理
                    SQLiteCommand cmd = con.CreateCommand();
                    // インサート
                    cmd.CommandText = "INSERT INTO SportsProduct (NAME, ADDRESS, TELL) VALUES (@NAME, @ADDRESS, @TELL)";
                    // パラメータセット
                    cmd.Parameters.Add("NAME", System.Data.DbType.String);
                    cmd.Parameters.Add("ADDRESS", System.Data.DbType.String);
                    cmd.Parameters.Add("TELL", System.Data.DbType.String);
                    // データ追加
                    cmd.Parameters["NAME"].Value = NameBox.Text;
                    cmd.Parameters["ADDRESS"].Value = AddressBox.Text;
                    cmd.Parameters["TELL"].Value = TellBox.Text;
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();

                    // DataTableを生成します。（データベースの表示処理）
                    var dataTable = new DataTable();
                    // SQLの実行
                    var adapter = new SQLiteDataAdapter("SELECT * FROM SportsProduct", con);
                    adapter.Fill(dataTable);
                    SportsDataView.DataSource = dataTable;
                }
            }
        }

        private void VerificationButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=SportsClub.db"))
            {
                // DataTableを生成します。
                var dataTable = new DataTable();
                // SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM SportsProduct", con);
                adapter.Fill(dataTable);
                SportsDataView.DataSource = dataTable;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SubMenu SubForm = new SubMenu();
            SubForm.Show();
            this.Visible = false;
        }

        private void RegisterMenu_Load(object sender, EventArgs e)
        {
            //奇数行の背景色を変更
            SportsDataView.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;

            //gridの幅を列にそろえる
            SportsDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //ヘッダーとすべてのセルの内容に合わせて、行の高さを自動調整する
            SportsDataView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //列の項目名を中央揃えdataGridView1.ReadOnly = true;
            SportsDataView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
