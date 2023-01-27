using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsClubProject
{
    //会員登録管理の検索メニュー
    public partial class SearchMenu : Form
    {
        /// <summary>
        /// 会員番号をもとに会員データベースから検索する処理
        /// </summary>
        private const string MemberNumberDataView = "SELECT * FROM SportsProduct WHERE MEMBERNUMBER =";

        /// <summary>
        /// フォーム起動時に準備
        /// </summary>
        public SearchMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// テーブルのID検索処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=SportsClub.db"))
            {
                // DataTableを生成します。
                DataTable dataTable = new DataTable();
                // SQLの実行
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(MemberNumberDataView + SearchBox.Text, con);
                adapter.Fill(dataTable);
                SportsDataView.DataSource = dataTable;
            }
        }

        /// <summary>
        /// サブフォームに移動する処理
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
        private void SearchMenuLoad(object sender, EventArgs e)
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
