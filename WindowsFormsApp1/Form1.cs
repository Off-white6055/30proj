using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        #region Form settings
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)//сворачивание
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region moveForm
        //private void LoginPanel_TextChanged(object sender, EventArgs e)
        //{
        //    this.LoginPanel.Size = new Size(this.LoginPanel.Size.Width, 16);//
        //}

        //private void PassPanel_TextChanged(object sender, EventArgs e)
        //{
        //    this.PassPanel.Size = new Size(this.PassPanel.Size.Width, 16);//

        //}

        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void PicMess_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PicMess_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void PicUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PicUser_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void PicPass_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PicPass_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        //private void label1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        this.Left += e.X - lastPoint.X;
        //        this.Top += e.Y - lastPoint.Y;
        //    }
        //}

        //private void label1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    lastPoint = new Point(e.X, e.Y);
        //}

        #endregion

        #region Settings Enter
        private void LoginPanel_MouseEnter(object sender, EventArgs e)
        {
            if (LoginPanel.Text == "Login")
            {
                LoginPanel.Text = "";

            }
        }

        private void LoginPanel_MouseLeave(object sender, EventArgs e)
        {
            if (LoginPanel.Text == "")
            {
                LoginPanel.Text = "Login";

            }
        }

        private void PassPanel_MouseEnter(object sender, EventArgs e)
        {
            if (PassPanel.Text == "Password")
            {
                PassPanel.Text = "";
                PassPanel.UseSystemPasswordChar = true;
            }

        }

        private void PassPanel_MouseLeave(object sender, EventArgs e)
        {
            if (PassPanel.Text == "")
            {
                PassPanel.Text = "Password";
                PassPanel.UseSystemPasswordChar = false;

            }
        }

        #endregion

        #region signin MySQL
        private void SignInButton_Click(object sender, EventArgs e) 
        {
            try
            {
                if (this.PassPanel.Text != "\0" && this.PassPanel.Text != "Password" &&
                    this.LoginPanel.Text != "\0" && this.LoginPanel.Text != "Login")
                {
                    String loginUser = LoginPanel.Text;
                    String passUser = PassPanel.Text;
                    DB db = new DB();
                    var a = db.openConnection();
                    if (a==1)
                    {
                        DataTable table = new DataTable();

                        MySqlDataAdapter adapter = new MySqlDataAdapter();

                        MySqlCommand command = new MySqlCommand("" +
                            "SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP ", db.getConnection());

                        command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                        command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        try
                        {
                            if (table.Rows.Count > 0)
                            {
                                if (loginUser.StartsWith("s"))    //  if (loginUser.StartsWith("s_id"))
                                {

                                    MessageBox.Show("Завершён", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);//ex.Message,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error
                                    StudentMenu_Form3_ studentform = new StudentMenu_Form3_(); //создаём дочернюю форму
                                    studentform.Txt = this.LoginPanel.Text;
                                    studentform.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    if (loginUser.StartsWith("t_"))
                                    {
                                        MessageBox.Show("Завершён", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        TeacherMenu_Form teacherform = new TeacherMenu_Form(); //создаём дочернюю форму 
                                        teacherform.Txt = this.LoginPanel.Text;
                                        teacherform.Show();
                                        this.Hide();
                                    }
                                    else MessageBox.Show("Не удалось войти");

                                }
                            }
                            else MessageBox.Show("Пользователя не существует");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            db.closeConnection();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка подключения");
                    }

                }
                else
                {
                    if (this.LoginPanel.Text == "Login")
                    {
                        MessageBox.Show("Введите логин");
                        return;
                    }
                    else
                    {
                        if (this.PassPanel.Text == "Password")
                        {
                            MessageBox.Show("Введите пароль");
                            return;
                        }
                        else MessageBox.Show("Не удалось войти");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

       
    }
}
