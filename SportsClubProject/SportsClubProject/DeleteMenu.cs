using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsClubProject
{
    public partial class DeleteMenu : Form
    {
        public DeleteMenu()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // メッセージボックスを表示
            DialogResult result = MessageBox.Show("本当に削除しますか？", "確認", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //会員情報を削除する
                using (SQLiteConnection con = new SQLiteConnection("Data Source=SportsClub.db"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        // インサート
                        cmd.CommandText = "DELETE FROM SportsProduct WHERE MEMBERNUMBER = @DELETE;";
                        // パラメータセット
                        cmd.Parameters.Add("DELETE", System.Data.DbType.Int64);
                        // データ削除
                        cmd.Parameters["DELETE"].Value = int.Parse(DeleteBox.Text);
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
                MessageBox.Show("削除しました");
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("キャンセルしました");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //登録管理画面に移行
            SubMenu SubForm = new SubMenu();
            SubForm.Show();
            this.Visible = false;
        }

        private void DeleteMenu_Load(object sender, EventArgs e)
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
