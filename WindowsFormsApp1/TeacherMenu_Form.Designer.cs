
namespace WindowsFormsApp1
{
    partial class TeacherMenu_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherMenu_Form));
            this.CloseFormStudentMenu = new System.Windows.Forms.PictureBox();
            this.minimaze = new System.Windows.Forms.PictureBox();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelSubjects = new System.Windows.Forms.Panel();
            this.GroupC20 = new System.Windows.Forms.Button();
            this.GroupB18 = new System.Windows.Forms.Button();
            this.GroupB19 = new System.Windows.Forms.Button();
            this.BtnItems = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.PicMess = new System.Windows.Forms.PictureBox();
            this.Maximazer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LabelGroups = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseFormStudentMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.panelSubjects.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximazer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseFormStudentMenu
            // 
            this.CloseFormStudentMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseFormStudentMenu.Image = ((System.Drawing.Image)(resources.GetObject("CloseFormStudentMenu.Image")));
            this.CloseFormStudentMenu.Location = new System.Drawing.Point(956, 12);
            this.CloseFormStudentMenu.Name = "CloseFormStudentMenu";
            this.CloseFormStudentMenu.Size = new System.Drawing.Size(32, 32);
            this.CloseFormStudentMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseFormStudentMenu.TabIndex = 26;
            this.CloseFormStudentMenu.TabStop = false;
            this.CloseFormStudentMenu.Click += new System.EventHandler(this.CloseFormStudentMenu_Click);
            // 
            // minimaze
            // 
            this.minimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimaze.Image = ((System.Drawing.Image)(resources.GetObject("minimaze.Image")));
            this.minimaze.Location = new System.Drawing.Point(880, 12);
            this.minimaze.Name = "minimaze";
            this.minimaze.Size = new System.Drawing.Size(32, 32);
            this.minimaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minimaze.TabIndex = 25;
            this.minimaze.TabStop = false;
            this.minimaze.Click += new System.EventHandler(this.minimaze_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelSideMenu.Controls.Add(this.btnUpdate);
            this.panelSideMenu.Controls.Add(this.panelSubjects);
            this.panelSideMenu.Controls.Add(this.BtnItems);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 600);
            this.panelSideMenu.TabIndex = 27;
            this.panelSideMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSideMenu_MouseDown);
            this.panelSideMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSideMenu_MouseMove);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(0, 550);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 50);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelSubjects
            // 
            this.panelSubjects.AutoScroll = true;
            this.panelSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panelSubjects.Controls.Add(this.GroupC20);
            this.panelSubjects.Controls.Add(this.GroupB18);
            this.panelSubjects.Controls.Add(this.GroupB19);
            this.panelSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubjects.Location = new System.Drawing.Point(0, 178);
            this.panelSubjects.Name = "panelSubjects";
            this.panelSubjects.Size = new System.Drawing.Size(200, 393);
            this.panelSubjects.TabIndex = 2;
            // 
            // GroupC20
            // 
            this.GroupC20.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupC20.FlatAppearance.BorderSize = 0;
            this.GroupC20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupC20.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupC20.Location = new System.Drawing.Point(0, 100);
            this.GroupC20.Name = "GroupC20";
            this.GroupC20.Size = new System.Drawing.Size(200, 50);
            this.GroupC20.TabIndex = 3;
            this.GroupC20.Text = "C20";
            this.GroupC20.UseVisualStyleBackColor = true;
            this.GroupC20.Click += new System.EventHandler(this.GroupC20_Click);
            // 
            // GroupB18
            // 
            this.GroupB18.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupB18.FlatAppearance.BorderSize = 0;
            this.GroupB18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupB18.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupB18.Location = new System.Drawing.Point(0, 50);
            this.GroupB18.Name = "GroupB18";
            this.GroupB18.Size = new System.Drawing.Size(200, 50);
            this.GroupB18.TabIndex = 4;
            this.GroupB18.Text = "B18";
            this.GroupB18.UseVisualStyleBackColor = true;
            this.GroupB18.Click += new System.EventHandler(this.GroupB18_Click);
            // 
            // GroupB19
            // 
            this.GroupB19.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupB19.FlatAppearance.BorderSize = 0;
            this.GroupB19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupB19.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupB19.Location = new System.Drawing.Point(0, 0);
            this.GroupB19.Name = "GroupB19";
            this.GroupB19.Size = new System.Drawing.Size(200, 50);
            this.GroupB19.TabIndex = 2;
            this.GroupB19.Text = "B19";
            this.GroupB19.UseVisualStyleBackColor = true;
            this.GroupB19.Click += new System.EventHandler(this.GroupB19_Click);
            // 
            // BtnItems
            // 
            this.BtnItems.BackColor = System.Drawing.Color.Blue;
            this.BtnItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnItems.FlatAppearance.BorderSize = 0;
            this.BtnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnItems.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnItems.Location = new System.Drawing.Point(0, 128);
            this.BtnItems.Name = "BtnItems";
            this.BtnItems.Size = new System.Drawing.Size(200, 50);
            this.BtnItems.TabIndex = 1;
            this.BtnItems.Text = "Groups";
            this.BtnItems.UseVisualStyleBackColor = false;
            this.BtnItems.Click += new System.EventHandler(this.BtnItems_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelLogo.Controls.Add(this.PicMess);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 128);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            this.panelLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseMove);
            // 
            // PicMess
            // 
            this.PicMess.Image = ((System.Drawing.Image)(resources.GetObject("PicMess.Image")));
            this.PicMess.Location = new System.Drawing.Point(35, 0);
            this.PicMess.Name = "PicMess";
            this.PicMess.Size = new System.Drawing.Size(128, 128);
            this.PicMess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicMess.TabIndex = 3;
            this.PicMess.TabStop = false;
            this.PicMess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicMess_MouseDown);
            this.PicMess.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicMess_MouseMove);
            // 
            // Maximazer
            // 
            this.Maximazer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximazer.Image = global::WindowsFormsApp1.Properties.Resources.maximize;
            this.Maximazer.Location = new System.Drawing.Point(918, 12);
            this.Maximazer.Name = "Maximazer";
            this.Maximazer.Size = new System.Drawing.Size(32, 32);
            this.Maximazer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Maximazer.TabIndex = 29;
            this.Maximazer.TabStop = false;
            this.Maximazer.Click += new System.EventHandler(this.Maximazer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(598, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 46);
            this.label1.TabIndex = 30;
            this.label1.Text = "Teacher menu";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(200, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(800, 550);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // LabelGroups
            // 
            this.LabelGroups.AutoSize = true;
            this.LabelGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelGroups.Location = new System.Drawing.Point(206, 1);
            this.LabelGroups.Name = "LabelGroups";
            this.LabelGroups.Size = new System.Drawing.Size(0, 46);
            this.LabelGroups.TabIndex = 32;
            // 
            // TeacherMenu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.LabelGroups);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimaze);
            this.Controls.Add(this.Maximazer);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.CloseFormStudentMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherMenu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherMenu_Form";
            this.Load += new System.EventHandler(this.TeacherMenu_Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TeacherMenu_Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TeacherMenu_Form_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.CloseFormStudentMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubjects.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximazer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseFormStudentMenu;
        private System.Windows.Forms.PictureBox minimaze;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSubjects;
        private System.Windows.Forms.Button GroupB18;
        private System.Windows.Forms.Button GroupC20;
        private System.Windows.Forms.Button GroupB19;
        private System.Windows.Forms.Button BtnItems;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox PicMess;
        private System.Windows.Forms.PictureBox Maximazer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label LabelGroups;
    }
}