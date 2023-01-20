﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsClubProject
{
    public partial class SearchMenu : Form
    {
        public SearchMenu()
        {
            InitializeComponent();
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=SportsClub.db"))
            {
                // DataTableを生成します。
                DataTable dataTable = new DataTable();
                // SQLの実行
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM SportsProduct WHERE MEMBERNUMBER =" + SerchBox.Text, con);
                adapter.Fill(dataTable);
                SportsDataView.DataSource = dataTable;
            }
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            SubMenu SubForm = new SubMenu();
            SubForm.Show();
            this.Visible = false;
        }

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
