using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TeacherMenu_Form : Form
    {
        #region to exchange data between forms
        public string subject;
        public string Txt
        {
            get { return subject; }
            set { subject = value; }
        }
        enum subjects : int
        {
            Math = 1,
            Physics = 2,
            Chemistry = 3
        }
        #endregion

        #region var
        private SqlConnection sqlconn = null;
        private SqlCommandBuilder sqlbuilder = null;
        private SqlDataAdapter sqladapter = null;
        private DataSet dataset = null;
        private bool newRowAdding = false;
        #endregion

        public TeacherMenu_Form()
        {
            InitializeComponent();
            hideSubMenu();
        }

        #region SQL server
        private void LoadData(string TableName)
        {
            try
            {
                sqladapter = new SqlDataAdapter("SELECT *, 'Delete' AS [Command] FROM " + @TableName, sqlconn);

                sqlbuilder = new SqlCommandBuilder(sqladapter);

                dataset = new DataSet();
                sqladapter.Fill(dataset, TableName);

                dataGridView1.DataSource = dataset.Tables[TableName];

                sqlbuilder.GetInsertCommand();
                sqlbuilder.GetDeleteCommand();
                sqlbuilder.GetUpdateCommand();

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    DataGridViewLinkCell linkcell = new DataGridViewLinkCell();
                    dataGridView1[18, i] = linkcell;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int ReloadData(String TableName)
        {
            try
            {
                dataset.Tables[TableName].Clear();

                sqladapter.Fill(dataset, TableName);

                dataGridView1.DataSource = dataset.Tables[TableName];

                sqlbuilder.GetUpdateCommand();
                return 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        private void TeacherMenu_Form_Load(object sender, EventArgs e)
        {
            sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\Users\Rebeil\source\repos\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
            sqlconn.Open();
        }
        #endregion

        #region Form settings
        private void CloseFormStudentMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximazer_Click(object sender, EventArgs e)//////// нужно ли это????
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                this.dataGridView1.Location = new System.Drawing.Point(200, 50);
                this.dataGridView1.Size = new System.Drawing.Size(1720, 1027);
                this.panelSubjects.Size = new System.Drawing.Size(200, 900);

            }
            else
            {
                WindowState = FormWindowState.Normal;
                this.dataGridView1.Location = new System.Drawing.Point(200, 50);
                this.dataGridView1.Size = new System.Drawing.Size(800, 550);
                this.panelSubjects.Size = new System.Drawing.Size(200, 393);
            }

        }

        private void minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        #endregion

        #region Show menu
        private void hideSubMenu()
        {
            panelSubjects.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void BtnItems_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubjects);

        }
        #endregion

        #region move Form
        Point lastPoint1;
        private void TeacherMenu_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint1.X;
                this.Top += e.Y - lastPoint1.Y;
            }
        }

        private void TeacherMenu_Form_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint1 = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint1.X;
                this.Top += e.Y - lastPoint1.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint1 = new Point(e.X, e.Y);
        }

        private void panelLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint1.X;
                this.Top += e.Y - lastPoint1.Y;
            }
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint1 = new Point(e.X, e.Y);
        }

        private void PicMess_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint1.X;
                this.Top += e.Y - lastPoint1.Y;
            }
        }

        private void PicMess_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint1 = new Point(e.X, e.Y);
        }

        private void panelSideMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint1.X;
                this.Top += e.Y - lastPoint1.Y;
            }
        }

        private void panelSideMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint1 = new Point(e.X, e.Y);
        }
        #endregion

        #region plnPanel1
        private void GroupB19_Click(object sender, EventArgs e)
        {
            LabelGroups.Text = GroupB19.Text;
            string str = subject.Substring(2);//удаляем t_
            int a = int.Parse(str);
            LoadData("Group" + (subjects)a + LabelGroups.Text.Substring(LabelGroups.Text.Length - 3));
            hideSubMenu();
        }
        #endregion

        #region plnPanel2
        private void GroupB18_Click(object sender, EventArgs e)
        {
            LabelGroups.Text = GroupB18.Text;
            string str = subject.Substring(2);
            int a = int.Parse(str);
            LoadData("Group" + (subjects)a + LabelGroups.Text.Substring(LabelGroups.Text.Length - 3));
            hideSubMenu();
        }
        #endregion

        #region plnPanel3
        private void GroupC20_Click(object sender, EventArgs e)
        {
            LabelGroups.Text = GroupC20.Text;
            string str = subject.Substring(2);
            int a = int.Parse(str);
            LoadData("Group" + (subjects)a + LabelGroups.Text.Substring(LabelGroups.Text.Length - 3));
            hideSubMenu();
        }
        #endregion

        #region button click update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string str = subject.Substring(2);
            int a = int.Parse(str);
            ReloadData("Group" + (subjects)a + LabelGroups.Text.Substring(LabelGroups.Text.Length - 3));
        }
        #endregion

        #region insert update delete
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 18)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();

                    string str = subject.Substring(2);
                    int a = int.Parse(str);

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку?", "Удаление",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;

                            dataGridView1.Rows.RemoveAt(rowIndex);

                            dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                                Substring(LabelGroups.Text.Length - 3)].Rows[rowIndex].Delete();

                            sqladapter.Update(dataset, "Group" + (subjects)a +
                                LabelGroups.Text.Substring(LabelGroups.Text.Length - 3));
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView1.Rows.Count - 2;


                        DataRow row = dataset.Tables["Group" +
                            (subjects)a + LabelGroups.Text.Substring(LabelGroups.Text.Length - 3)].NewRow();

                        row["ученик"] = dataGridView1.Rows[rowIndex].Cells["ученик"].Value;

                        row["Самостоятельная работа 1"] = dataGridView1.Rows[rowIndex].
                            Cells["Самостоятельная работа 1"].Value;

                        row["Самостоятельная работа 2"] = dataGridView1.Rows[rowIndex].
                            Cells["Самостоятельная работа 2"].Value;

                        row["Контрольная работа 1"] = dataGridView1.Rows[rowIndex].
                            Cells["Контрольная работа 1"].Value;

                        row["Итоги за 1 четверть"] = dataGridView1.Rows[rowIndex].
                            Cells["Итоги за 1 четверть"].Value;

                        row["Самостоятельная работа 3"] = dataGridView1.Rows[rowIndex].
                            Cells["Самостоятельная работа 3"].Value;

                        row["Самостоятельная работа 4"] = dataGridView1.Rows[rowIndex].
                            Cells["Самостоятельная работа 4"].Value;

                        row["Контрольная работа 2"] = dataGridView1.Rows[rowIndex].
                            Cells["Контрольная работа 2"].Value;

                        row["Итоги за 2 четверть"] = dataGridView1.Rows[rowIndex].
                            Cells["Итоги за 2 четверть"].Value;

                        row["Самостоятельная работа 5"] = dataGridView1.Rows[rowIndex].
                            Cells["Самостоятельная работа 5"].Value;

                        row["Самостоятельная работа 6"] = dataGridView1.Rows[rowIndex].
                            Cells["Самостоятельная работа 6"].Value;

                        row["Контрольная работа 3"] = dataGridView1.Rows[rowIndex].
                            Cells["Контрольная работа 3"].Value;

                        row["Итоги за 3 четверть"] = dataGridView1.Rows[rowIndex].
                            Cells["Итоги за 4 четверть"].Value;

                        row["Самостоятельная работа 7"] = dataGridView1.Rows[rowIndex].
                            Cells["Самостоятельная работа 7"].Value;

                        row["Самостоятельная работа 8"] = dataGridView1.Rows[rowIndex].
                            Cells["Самостоятельная работа 8"].Value;

                        row["Контрольная работа 4"] = dataGridView1.Rows[rowIndex].
                            Cells["Контрольная работа 4"].Value;

                        row["Итоги за 4 четверть"] = dataGridView1.Rows[rowIndex].
                            Cells["Итоги за 4 четверть"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows.Add(row);

                        dataset.Tables["Group" + (subjects)a +
                            LabelGroups.Text.Substring(LabelGroups.Text.Length - 3)].
                            Rows.RemoveAt(dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].Rows.Count - 2);//

                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                        dataGridView1.Rows[e.RowIndex].Cells[18].Value = "Delete";

                        sqladapter.Update(dataset, "Group" +
                            (subjects)a + LabelGroups.Text.Substring(LabelGroups.Text.Length - 3));
                        newRowAdding = false;



                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["ученик"] = dataGridView1.Rows[r].Cells["ученик"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Самостоятельная работа 1"] = dataGridView1.Rows[r].
                            Cells["Самостоятельная работа 1"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Самостоятельная работа 2"] = dataGridView1.Rows[r].
                            Cells["Самостоятельная работа 2"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Контрольная работа 1"] = dataGridView1.Rows[r].
                            Cells["Контрольная работа 1"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Итоги за 1 четверть"] = dataGridView1.Rows[r].
                            Cells["Итоги за 1 четверть"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Самостоятельная работа 3"] = dataGridView1.Rows[r].
                            Cells["Самостоятельная работа 3"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Самостоятельная работа 4"] = dataGridView1.Rows[r].
                            Cells["Самостоятельная работа 4"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Контрольная работа 2"] = dataGridView1.Rows[r].
                            Cells["Контрольная работа 2"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Итоги за 2 четверть"] = dataGridView1.Rows[r].
                            Cells["Итоги за 2 четверть"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Самостоятельная работа 5"] = dataGridView1.
                            Rows[r].Cells["Самостоятельная работа 5"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Самостоятельная работа 6"] = dataGridView1.
                            Rows[r].Cells["Самостоятельная работа 6"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Контрольная работа 3"] = dataGridView1.Rows[r].
                            Cells["Контрольная работа 3"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Итоги за 3 четверть"] = dataGridView1.Rows[r].
                            Cells["Итоги за 3 четверть"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Самостоятельная работа 7"] = dataGridView1.Rows[r].
                            Cells["Самостоятельная работа 7"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Самостоятельная работа 8"] = dataGridView1.Rows[r].
                            Cells["Самостоятельная работа 8"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Контрольная работа 4"] = dataGridView1.Rows[r].
                            Cells["Контрольная работа 4"].Value;

                        dataset.Tables["Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3)].
                            Rows[r]["Итоги за 4 четверть"] = dataGridView1.Rows[r].
                            Cells["Итоги за 4 четверть"].Value;

                        sqladapter.Update(dataset, "Group" + (subjects)a + LabelGroups.Text.
                            Substring(LabelGroups.Text.Length - 3));

                        dataGridView1.Rows[e.RowIndex].Cells[18].Value = "Delete";


                    }
                    ReloadData("Group" + (subjects)a +
                        LabelGroups.Text.Substring(LabelGroups.Text.Length - 3));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region link button
        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;

                    int lastRow = dataGridView1.Rows.Count - 2;

                    DataGridViewRow row = dataGridView1.Rows[lastRow];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[18, lastRow] = linkCell;

                    row.Cells["Command"].Value = "Insert";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow editingRow = dataGridView1.Rows[rowIndex];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[18, rowIndex] = linkCell;

                    editingRow.Cells["Command"].Value = "Update";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region not enter symbols
        private void dataGridView1_EditingControlShowing(object sender,
            DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            if (dataGridView1.CurrentCell.ColumnIndex == 2 || dataGridView1.CurrentCell.ColumnIndex == 3 ||
                dataGridView1.CurrentCell.ColumnIndex == 4 || dataGridView1.CurrentCell.ColumnIndex == 5 ||
                dataGridView1.CurrentCell.ColumnIndex == 6 || dataGridView1.CurrentCell.ColumnIndex == 7 ||
                dataGridView1.CurrentCell.ColumnIndex == 8 || dataGridView1.CurrentCell.ColumnIndex == 9 ||
                dataGridView1.CurrentCell.ColumnIndex == 10 || dataGridView1.CurrentCell.ColumnIndex == 11 ||
                dataGridView1.CurrentCell.ColumnIndex == 12 || dataGridView1.CurrentCell.ColumnIndex == 13 ||
                dataGridView1.CurrentCell.ColumnIndex == 14 || dataGridView1.CurrentCell.ColumnIndex == 15 ||
                dataGridView1.CurrentCell.ColumnIndex == 16 || dataGridView1.CurrentCell.ColumnIndex == 17)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }

        }
        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
        }
        #endregion





    }
}
