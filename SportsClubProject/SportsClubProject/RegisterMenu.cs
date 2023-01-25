using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsClubProject
{
    public partial class RegisterMenu : Form
    {
        /// <summary>
        /// スポーツクラブの会員情報を表示させる処理
        /// </summary>
        private const string MemberDataView = "SELECT * FROM SportsProduct";

        /// <summary>
        /// フォーム起動時に準備
        /// </summary>
        public RegisterMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 会員情報を登録する処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButtonClick(object sender, EventArgs e)
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
                    cmd.Parameters.Add("NAME", DbType.String);
                    cmd.Parameters.Add("ADDRESS", DbType.String);
                    cmd.Parameters.Add("TELL", DbType.String);
                    // データ追加
                    cmd.Parameters["NAME"].Value = NameBox.Text;
                    cmd.Parameters["ADDRESS"].Value = AddressBox.Text;
                    cmd.Parameters["TELL"].Value = TellBox.Text;
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();

                    // DataTableを生成します。（データベースの表示処理）
                    DataTable dataTable = new DataTable();
                    // SQLの実行
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(MemberDataView , con);
                    adapter.Fill(dataTable);
                    SportsDataView.DataSource = dataTable;
                }
            }
        }

        /// <summary>
        /// テーブルの中身を表示する処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerificationButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=SportsClub.db"))
            {
                // DataTableを生成します。
                DataTable dataTable = new DataTable();
                // SQLの実行
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(MemberDataView , con);
                adapter.Fill(dataTable);
                SportsDataView.DataSource = dataTable;
            }
        }

        /// <summary>
        /// サブメニューに移動する処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButtonClick(object sender, EventArgs e)
        {
            SubMenu SubForm = new SubMenu();
            SubForm.Show();
            this.Visible = false;
        }

        /// <summary>
        /// テーブルの表示設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterMenuLoad(object sender, EventArgs e)
        {
            //奇数行の背景色を変更
            SportsDataView.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue;

            //gridの幅を列にそろえる
            SportsDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //ヘッダーとすべてのセルの内容に合わせて、行の高さを自動調整する
            SportsDataView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //列の項目名を中央揃え
            SportsDataView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
