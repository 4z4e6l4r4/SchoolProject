namespace SchoolProject
{
    partial class Form1
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
            this.AddUserGb = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UpdateUserGb = new System.Windows.Forms.GroupBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.AgeNud = new System.Windows.Forms.NumericUpDown();
            this.StatusCb = new System.Windows.Forms.CheckBox();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.StudentDgv = new System.Windows.Forms.DataGridView();
            this.ClassesCb = new System.Windows.Forms.ComboBox();
            this.ClassesLbl = new System.Windows.Forms.Label();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.AddUserGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUserGb
            // 
            this.AddUserGb.Controls.Add(this.AddUserBtn);
            this.AddUserGb.Controls.Add(this.ClassesLbl);
            this.AddUserGb.Controls.Add(this.ClassesCb);
            this.AddUserGb.Controls.Add(this.StatusLbl);
            this.AddUserGb.Controls.Add(this.StatusCb);
            this.AddUserGb.Controls.Add(this.AgeNud);
            this.AddUserGb.Controls.Add(this.AgeLbl);
            this.AddUserGb.Controls.Add(this.textBox2);
            this.AddUserGb.Controls.Add(this.SurnameLbl);
            this.AddUserGb.Controls.Add(this.textBox1);
            this.AddUserGb.Controls.Add(this.NameLbl);
            this.AddUserGb.Location = new System.Drawing.Point(28, 19);
            this.AddUserGb.Name = "AddUserGb";
            this.AddUserGb.Size = new System.Drawing.Size(353, 228);
            this.AddUserGb.TabIndex = 0;
            this.AddUserGb.TabStop = false;
            this.AddUserGb.Text = "Add User";
            // 
            // UpdateUserGb
            // 
            this.UpdateUserGb.Location = new System.Drawing.Point(28, 275);
            this.UpdateUserGb.Name = "UpdateUserGb";
            this.UpdateUserGb.Size = new System.Drawing.Size(353, 228);
            this.UpdateUserGb.TabIndex = 1;
            this.UpdateUserGb.TabStop = false;
            this.UpdateUserGb.Text = "Update User";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(6, 22);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(44, 16);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 22);
            this.textBox2.TabIndex = 5;
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Location = new System.Drawing.Point(6, 82);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(61, 16);
            this.SurnameLbl.TabIndex = 4;
            this.SurnameLbl.Text = "Surname";
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Location = new System.Drawing.Point(6, 149);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(32, 16);
            this.AgeLbl.TabIndex = 6;
            this.AgeLbl.Text = "Age";
            // 
            // AgeNud
            // 
            this.AgeNud.Location = new System.Drawing.Point(8, 181);
            this.AgeNud.Name = "AgeNud";
            this.AgeNud.Size = new System.Drawing.Size(67, 22);
            this.AgeNud.TabIndex = 7;
            // 
            // StatusCb
            // 
            this.StatusCb.AutoSize = true;
            this.StatusCb.Location = new System.Drawing.Point(160, 51);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(76, 20);
            this.StatusCb.TabIndex = 8;
            this.StatusCb.Text = "IsStatus";
            this.StatusCb.UseVisualStyleBackColor = true;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(157, 22);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(44, 16);
            this.StatusLbl.TabIndex = 9;
            this.StatusLbl.Text = "Status";
            // 
            // StudentDgv
            // 
            this.StudentDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDgv.Location = new System.Drawing.Point(409, 31);
            this.StudentDgv.Name = "StudentDgv";
            this.StudentDgv.RowHeadersWidth = 51;
            this.StudentDgv.RowTemplate.Height = 24;
            this.StudentDgv.Size = new System.Drawing.Size(487, 471);
            this.StudentDgv.TabIndex = 2;
            // 
            // ClassesCb
            // 
            this.ClassesCb.FormattingEnabled = true;
            this.ClassesCb.Location = new System.Drawing.Point(160, 107);
            this.ClassesCb.Name = "ClassesCb";
            this.ClassesCb.Size = new System.Drawing.Size(102, 24);
            this.ClassesCb.TabIndex = 10;
            // 
            // ClassesLbl
            // 
            this.ClassesLbl.AutoSize = true;
            this.ClassesLbl.Location = new System.Drawing.Point(157, 82);
            this.ClassesLbl.Name = "ClassesLbl";
            this.ClassesLbl.Size = new System.Drawing.Size(56, 16);
            this.ClassesLbl.TabIndex = 11;
            this.ClassesLbl.Text = "Classes";
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(161, 171);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(100, 22);
            this.AddUserBtn.TabIndex = 12;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 556);
            this.Controls.Add(this.StudentDgv);
            this.Controls.Add(this.UpdateUserGb);
            this.Controls.Add(this.AddUserGb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AddUserGb.ResumeLayout(false);
            this.AddUserGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddUserGb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox UpdateUserGb;
        private System.Windows.Forms.NumericUpDown AgeNud;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.CheckBox StatusCb;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Label ClassesLbl;
        private System.Windows.Forms.ComboBox ClassesCb;
        private System.Windows.Forms.DataGridView StudentDgv;
    }
}

