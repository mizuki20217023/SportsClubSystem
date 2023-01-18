using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsClubProject
{
    public partial class FixMenu : Form
    {
        public FixMenu()
        {
            InitializeComponent();
        }

        private void FixButton_Click(object sender, EventArgs e)
        {
            // メッセージボックスを表示
            DialogResult result = MessageBox.Show("本当に会員情報を修正しますか？", "確認", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=SportsClub.db"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        // インサート
                        cmd.CommandText = "UPDATE SportsProduct set NAME = @NAME, ADDRESS = @ADDRESS, TELL = @TELL WHERE MEMBERNUMBER = @UPDATE;";
                        // パラメータセット
                        cmd.Parameters.Add("NAME", System.Data.DbType.String);
                        cmd.Parameters.Add("ADDRESS", System.Data.DbType.String);
                        cmd.Parameters.Add("TELL", System.Data.DbType.String);
                        cmd.Parameters.Add("UPDATE", System.Data.DbType.Int64);
                        // データ修正
                        cmd.Parameters["NAME"].Value = NameBox.Text;
                        cmd.Parameters["ADDRESS"].Value = AddressBox.Text;
                        cmd.Parameters["TELL"].Value = TellBox.Text;
                        cmd.Parameters["UPDATE"].Value = int.Parse(UpdateNumberBox.Text);
                        cmd.ExecuteNonQuery();
                        // コミット
                        trans.Commit();

                        // DataTableを生成します。
                        var dataTable = new DataTable();
                        // SQLの実行
                        var adapter = new SQLiteDataAdapter("SELECT * FROM SportsProduct", con);
                        adapter.Fill(dataTable);
                        SportsDataView.DataSource = dataTable;
                    }
                }
                MessageBox.Show("変更しました");
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("キャンセルしました。");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //登録管理画面に移行
            SubMenu SubForm = new SubMenu();
            SubForm.Show();
            this.Visible = false;
        }

        private void FixMenu_Load(object sender, EventArgs e)
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
