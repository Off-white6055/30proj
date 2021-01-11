using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentMenu_Form3_ : Form
    {
        #region to exchange data between forms
        public string Txt
        {
            get { return group; }
            set { group = value; }
        }
        #endregion

        #region var
        public string group;
        private SqlConnection sqlconn = null;
        private SqlCommandBuilder sqlbuilder = null;
        private SqlDataAdapter sqladapter = null;
        private DataSet dataset = null;
        #endregion

        public StudentMenu_Form3_()
        {
            InitializeComponent();
            hideSubMenu();
        }

        #region SQL server local
        private void LoadData(string TableName)
        {
            try
            {
                sqladapter = new SqlDataAdapter("SELECT * FROM " + @TableName, sqlconn);

                //sqladapter = new SqlDataAdapter("SELECT * FROM " + @TableName +
                //    "WHERE" + @TableName + " <> ' '  ", sqlconn);

                sqlbuilder = new SqlCommandBuilder(sqladapter);

                dataset = new DataSet();
                sqladapter.Fill(dataset, TableName);

                dataGridView1.DataSource = dataset.Tables[TableName];

                sqlbuilder.GetUpdateCommand();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadData(String TableName)
        {
            try
            {
                dataset.Tables[TableName].Clear();

                sqladapter.Fill(dataset, TableName);

                dataGridView1.DataSource = dataset.Tables[TableName];

                sqlbuilder.GetUpdateCommand();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentMenu_Form3__Load(object sender, EventArgs e)
        {
            sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rebeil\source\repos\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
            sqlconn.Open();
        }
        #endregion

        #region button click update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ReloadData("Group" + LabelStudent.Text + group.Substring(group.Length - 3));
        }
        #endregion

        #region Form settings
        private void CloseFormStudentMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Maximazer_Click(object sender, EventArgs e)
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

        #region hide Menu
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

        #region groups information click
        private void Math_Click(object sender, EventArgs e)
        {
            LabelStudent.Text = Math.Text;
            LoadData("Group" + LabelStudent.Text + group.Substring(group.Length - 3));
            hideSubMenu();
        }

        private void Physics_Click(object sender, EventArgs e)
        {
            LabelStudent.Text = Physics.Text;
            LoadData("Group" + LabelStudent.Text + group.Substring(group.Length - 3));
            hideSubMenu();

        }

        private void Chemistry_Click(object sender, EventArgs e)
        {
            LabelStudent.Text = Chemistry.Text;
            LoadData("Group" + LabelStudent.Text + group.Substring(group.Length - 3));
            hideSubMenu();

        }
        #endregion

        #region moveForm
        Point lastPoint1;

        private void StudentMenu_Form3__MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint1.X;
                this.Top += e.Y - lastPoint1.Y;
            }
        }

        private void StudentMenu_Form3__MouseDown(object sender, MouseEventArgs e)
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

        #endregion

        #region not enter in table
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.CellStyle.BackColor = Color.Blue;
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            if (dataGridView1.CurrentCell.ColumnIndex == 2 || dataGridView1.CurrentCell.ColumnIndex == 3 ||
                dataGridView1.CurrentCell.ColumnIndex == 4 || dataGridView1.CurrentCell.ColumnIndex == 5 ||
                dataGridView1.CurrentCell.ColumnIndex == 6 || dataGridView1.CurrentCell.ColumnIndex == 7 ||
                dataGridView1.CurrentCell.ColumnIndex == 8 || dataGridView1.CurrentCell.ColumnIndex == 9 ||
                dataGridView1.CurrentCell.ColumnIndex == 10 || dataGridView1.CurrentCell.ColumnIndex == 11 ||
                dataGridView1.CurrentCell.ColumnIndex == 12 || dataGridView1.CurrentCell.ColumnIndex == 13 ||
                dataGridView1.CurrentCell.ColumnIndex == 14 || dataGridView1.CurrentCell.ColumnIndex == 15 ||
                dataGridView1.CurrentCell.ColumnIndex == 16 || dataGridView1.CurrentCell.ColumnIndex == 17 ||
                dataGridView1.CurrentCell.ColumnIndex == 1 || dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)//s_ID1_B19
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
            else if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion


    }
}
