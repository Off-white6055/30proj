
namespace WindowsFormsApp1
{
    partial class StudentMenu_Form3_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMenu_Form3_));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelSubjects = new System.Windows.Forms.Panel();
            this.Chemistry = new System.Windows.Forms.Button();
            this.Physics = new System.Windows.Forms.Button();
            this.Math = new System.Windows.Forms.Button();
            this.BtnItems = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.PicMess = new System.Windows.Forms.PictureBox();
            this.LabelStudent = new System.Windows.Forms.Label();
            this.Maximazer = new System.Windows.Forms.PictureBox();
            this.CloseFormTeacherMenu = new System.Windows.Forms.PictureBox();
            this.minimaze = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelSideMenu.SuspendLayout();
            this.panelSubjects.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximazer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseFormTeacherMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSideMenu_MouseDown);
            this.panelSideMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSideMenu_MouseMove);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(0, 550);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 50);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelSubjects
            // 
            this.panelSubjects.AutoScroll = true;
            this.panelSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panelSubjects.Controls.Add(this.Chemistry);
            this.panelSubjects.Controls.Add(this.Physics);
            this.panelSubjects.Controls.Add(this.Math);
            this.panelSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubjects.Location = new System.Drawing.Point(0, 178);
            this.panelSubjects.Name = "panelSubjects";
            this.panelSubjects.Size = new System.Drawing.Size(200, 393);
            this.panelSubjects.TabIndex = 4;
            // 
            // Chemistry
            // 
            this.Chemistry.Dock = System.Windows.Forms.DockStyle.Top;
            this.Chemistry.FlatAppearance.BorderSize = 0;
            this.Chemistry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chemistry.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chemistry.Location = new System.Drawing.Point(0, 100);
            this.Chemistry.Name = "Chemistry";
            this.Chemistry.Size = new System.Drawing.Size(200, 50);
            this.Chemistry.TabIndex = 3;
            this.Chemistry.Text = "Chemistry";
            this.Chemistry.UseVisualStyleBackColor = true;
            this.Chemistry.Click += new System.EventHandler(this.Chemistry_Click);
            // 
            // Physics
            // 
            this.Physics.Dock = System.Windows.Forms.DockStyle.Top;
            this.Physics.FlatAppearance.BorderSize = 0;
            this.Physics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Physics.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Physics.Location = new System.Drawing.Point(0, 50);
            this.Physics.Name = "Physics";
            this.Physics.Size = new System.Drawing.Size(200, 50);
            this.Physics.TabIndex = 4;
            this.Physics.Text = "Physics";
            this.Physics.UseVisualStyleBackColor = true;
            this.Physics.Click += new System.EventHandler(this.Physics_Click);
            // 
            // Math
            // 
            this.Math.Dock = System.Windows.Forms.DockStyle.Top;
            this.Math.FlatAppearance.BorderSize = 0;
            this.Math.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Math.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Math.Location = new System.Drawing.Point(0, 0);
            this.Math.Name = "Math";
            this.Math.Size = new System.Drawing.Size(200, 50);
            this.Math.TabIndex = 2;
            this.Math.Text = "Math";
            this.Math.UseVisualStyleBackColor = true;
            this.Math.Click += new System.EventHandler(this.Math_Click);
            // 
            // BtnItems
            // 
            this.BtnItems.BackColor = System.Drawing.Color.Blue;
            this.BtnItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnItems.FlatAppearance.BorderSize = 0;
            this.BtnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnItems.Location = new System.Drawing.Point(0, 128);
            this.BtnItems.Name = "BtnItems";
            this.BtnItems.Size = new System.Drawing.Size(200, 50);
            this.BtnItems.TabIndex = 1;
            this.BtnItems.Text = "Rating";
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
            this.PicMess.Location = new System.Drawing.Point(36, 0);
            this.PicMess.Name = "PicMess";
            this.PicMess.Size = new System.Drawing.Size(128, 128);
            this.PicMess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicMess.TabIndex = 3;
            this.PicMess.TabStop = false;
            this.PicMess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicMess_MouseDown);
            this.PicMess.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicMess_MouseMove);
            // 
            // LabelStudent
            // 
            this.LabelStudent.AutoSize = true;
            this.LabelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStudent.Location = new System.Drawing.Point(206, 1);
            this.LabelStudent.Name = "LabelStudent";
            this.LabelStudent.Size = new System.Drawing.Size(0, 46);
            this.LabelStudent.TabIndex = 26;
            // 
            // Maximazer
            // 
            this.Maximazer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximazer.Image = global::WindowsFormsApp1.Properties.Resources.maximize;
            this.Maximazer.Location = new System.Drawing.Point(918, 12);
            this.Maximazer.Name = "Maximazer";
            this.Maximazer.Size = new System.Drawing.Size(32, 32);
            this.Maximazer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Maximazer.TabIndex = 27;
            this.Maximazer.TabStop = false;
            this.Maximazer.Click += new System.EventHandler(this.Maximazer_Click);
            // 
            // CloseFormTeacherMenu
            // 
            this.CloseFormTeacherMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseFormTeacherMenu.Image = ((System.Drawing.Image)(resources.GetObject("CloseFormTeacherMenu.Image")));
            this.CloseFormTeacherMenu.Location = new System.Drawing.Point(956, 12);
            this.CloseFormTeacherMenu.Name = "CloseFormTeacherMenu";
            this.CloseFormTeacherMenu.Size = new System.Drawing.Size(32, 32);
            this.CloseFormTeacherMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseFormTeacherMenu.TabIndex = 24;
            this.CloseFormTeacherMenu.TabStop = false;
            this.CloseFormTeacherMenu.Click += new System.EventHandler(this.CloseFormStudentMenu_Click);
            // 
            // minimaze
            // 
            this.minimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimaze.Image = ((System.Drawing.Image)(resources.GetObject("minimaze.Image")));
            this.minimaze.Location = new System.Drawing.Point(880, 12);
            this.minimaze.Name = "minimaze";
            this.minimaze.Size = new System.Drawing.Size(32, 32);
            this.minimaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minimaze.TabIndex = 23;
            this.minimaze.TabStop = false;
            this.minimaze.Click += new System.EventHandler(this.minimaze_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(607, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 46);
            this.label1.TabIndex = 28;
            this.label1.Text = "Student menu";
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
            this.dataGridView1.Size = new System.Drawing.Size(800, 547);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // StudentMenu_Form3_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Maximazer);
            this.Controls.Add(this.LabelStudent);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.CloseFormTeacherMenu);
            this.Controls.Add(this.minimaze);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentMenu_Form3_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMenu_Form3_";
            this.Load += new System.EventHandler(this.StudentMenu_Form3__Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StudentMenu_Form3__MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StudentMenu_Form3__MouseMove);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubjects.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximazer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseFormTeacherMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.PictureBox CloseFormTeacherMenu;
        private System.Windows.Forms.PictureBox minimaze;
        private System.Windows.Forms.Button BtnItems;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label LabelStudent;
        private System.Windows.Forms.PictureBox Maximazer;
        private System.Windows.Forms.PictureBox PicMess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelSubjects;
        private System.Windows.Forms.Button Chemistry;
        private System.Windows.Forms.Button Physics;
        private System.Windows.Forms.Button Math;
    }
}