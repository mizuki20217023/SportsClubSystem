using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsClubProject
{
    public partial class DeleteMenu : Form
    {
        /// <summary>
        /// フォーム起動時に準備
        /// </summary>
        public DeleteMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 会員情報の削除処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            // メッセージボックスを表示
            DialogResult result = MessageBox.Show("本当に削除しますか？", "確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
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
                        cmd.Parameters.Add("DELETE", DbType.Int64);
                        // データ削除
                        cmd.Parameters["DELETE"].Value = int.Parse(DeleteBox.Text);
                        cmd.ExecuteNonQuery();
                        // コミット
                        trans.Commit();

                        // DataTableを生成します。
                        DataTable dataTable = new DataTable();
                        // SQLの実行
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM SportsProduct", con);
                        adapter.Fill(dataTable);
                        SportsDataView.DataSource = dataTable;
                    }
                }
                MessageBox.Show("削除しました");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("キャンセルしました");
            }
        }

        /// <summary>
        /// サブメニューに移動する処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButtonClick(object sender, EventArgs e)
        {
            //登録管理画面に移行
            SubMenu SubForm = new SubMenu();
            SubForm.Show();
            this.Visible = false;
        }

        /// <summary>
        /// テーブルの表示設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteMenuLoad(object sender, EventArgs e)
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
