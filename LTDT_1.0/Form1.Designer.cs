namespace LTDT_1._0
{
    partial class PrimAndDijsktra
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
            this.Create = new System.Windows.Forms.Button();
            this.PrintMatrix = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.CreLine = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Nen = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dijsktrarbt = new System.Windows.Forms.RadioButton();
            this.primrbt = new System.Windows.Forms.RadioButton();
            this.Run = new System.Windows.Forms.Button();
            this.DuongDi = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.GiaTri = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.GO = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dijGoto = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rundijbt = new System.Windows.Forms.Button();
            this.dijto = new System.Windows.Forms.ComboBox();
            this.dijfrom = new System.Windows.Forms.ComboBox();
            this.exitdij = new System.Windows.Forms.Button();
            this.Nen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DuongDi.SuspendLayout();
            this.dijGoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(229, 12);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(67, 59);
            this.Create.TabIndex = 3;
            this.Create.Text = "Tạo đỉnh";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // PrintMatrix
            // 
            this.PrintMatrix.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PrintMatrix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PrintMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintMatrix.Location = new System.Drawing.Point(375, 12);
            this.PrintMatrix.Name = "PrintMatrix";
            this.PrintMatrix.Size = new System.Drawing.Size(67, 59);
            this.PrintMatrix.TabIndex = 5;
            this.PrintMatrix.Text = "Xem ma trận";
            this.PrintMatrix.UseVisualStyleBackColor = false;
            this.PrintMatrix.Click += new System.EventHandler(this.PrintMatrix_Click);
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(448, 12);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(67, 59);
            this.New.TabIndex = 6;
            this.New.Text = "Tạo đồ thị mới";
            this.New.UseVisualStyleBackColor = false;
            // 
            // CreLine
            // 
            this.CreLine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CreLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CreLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreLine.Location = new System.Drawing.Point(302, 12);
            this.CreLine.Name = "CreLine";
            this.CreLine.Size = new System.Drawing.Size(67, 59);
            this.CreLine.TabIndex = 4;
            this.CreLine.Text = "Tạo đường đi";
            this.CreLine.UseVisualStyleBackColor = false;
            this.CreLine.Click += new System.EventHandler(this.CreLine_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(521, 12);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(67, 59);
            this.Save.TabIndex = 7;
            this.Save.Text = "Lưu đồ thị";
            this.Save.UseVisualStyleBackColor = false;
            // 
            // Nen
            // 
            this.Nen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Nen.Controls.Add(this.groupBox1);
            this.Nen.Controls.Add(this.Run);
            this.Nen.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nen.Location = new System.Drawing.Point(0, 0);
            this.Nen.Name = "Nen";
            this.Nen.Size = new System.Drawing.Size(941, 95);
            this.Nen.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dijsktrarbt);
            this.groupBox1.Controls.Add(this.primrbt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thuật toán";
            // 
            // dijsktrarbt
            // 
            this.dijsktrarbt.AutoSize = true;
            this.dijsktrarbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dijsktrarbt.Location = new System.Drawing.Point(109, 29);
            this.dijsktrarbt.Name = "dijsktrarbt";
            this.dijsktrarbt.Size = new System.Drawing.Size(80, 24);
            this.dijsktrarbt.TabIndex = 2;
            this.dijsktrarbt.Text = "Dijkstra";
            this.dijsktrarbt.UseVisualStyleBackColor = true;
            // 
            // primrbt
            // 
            this.primrbt.AutoSize = true;
            this.primrbt.Checked = true;
            this.primrbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primrbt.Location = new System.Drawing.Point(6, 29);
            this.primrbt.Name = "primrbt";
            this.primrbt.Size = new System.Drawing.Size(58, 24);
            this.primrbt.TabIndex = 1;
            this.primrbt.TabStop = true;
            this.primrbt.Text = "Prim";
            this.primrbt.UseVisualStyleBackColor = true;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(594, 12);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(67, 59);
            this.Run.TabIndex = 8;
            this.Run.Text = "Chạy thuật toán";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // DuongDi
            // 
            this.DuongDi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DuongDi.Controls.Add(this.label4);
            this.DuongDi.Controls.Add(this.GiaTri);
            this.DuongDi.Controls.Add(this.Cancel);
            this.DuongDi.Controls.Add(this.GO);
            this.DuongDi.Controls.Add(this.End);
            this.DuongDi.Controls.Add(this.Start);
            this.DuongDi.Controls.Add(this.label2);
            this.DuongDi.Controls.Add(this.label3);
            this.DuongDi.Controls.Add(this.label1);
            this.DuongDi.Location = new System.Drawing.Point(0, 101);
            this.DuongDi.Name = "DuongDi";
            this.DuongDi.Size = new System.Drawing.Size(223, 127);
            this.DuongDi.TabIndex = 3;
            this.DuongDi.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tạo đường đi giữa các đỉnh";
            // 
            // GiaTri
            // 
            this.GiaTri.Location = new System.Drawing.Point(74, 65);
            this.GiaTri.Name = "GiaTri";
            this.GiaTri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GiaTri.Size = new System.Drawing.Size(67, 20);
            this.GiaTri.TabIndex = 11;
            this.GiaTri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(141, 91);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(73, 30);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Thoát";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // GO
            // 
            this.GO.Location = new System.Drawing.Point(17, 89);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(73, 30);
            this.GO.TabIndex = 12;
            this.GO.Text = "Tạo";
            this.GO.UseVisualStyleBackColor = true;
            this.GO.Click += new System.EventHandler(this.GO_Click);
            // 
            // End
            // 
            this.End.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.End.FormattingEnabled = true;
            this.End.Location = new System.Drawing.Point(132, 38);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(42, 21);
            this.End.TabIndex = 10;
            // 
            // Start
            // 
            this.Start.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Start.FormattingEnabled = true;
            this.Start.Location = new System.Drawing.Point(48, 38);
            this.Start.MaxDropDownItems = 100;
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(42, 21);
            this.Start.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá trị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đi từ";
            // 
            // dijGoto
            // 
            this.dijGoto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dijGoto.Controls.Add(this.label7);
            this.dijGoto.Controls.Add(this.label6);
            this.dijGoto.Controls.Add(this.exitdij);
            this.dijGoto.Controls.Add(this.label5);
            this.dijGoto.Controls.Add(this.rundijbt);
            this.dijGoto.Controls.Add(this.dijto);
            this.dijGoto.Controls.Add(this.dijfrom);
            this.dijGoto.Location = new System.Drawing.Point(0, 234);
            this.dijGoto.Name = "dijGoto";
            this.dijGoto.Size = new System.Drawing.Size(225, 109);
            this.dijGoto.TabIndex = 4;
            this.dijGoto.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Dijkstra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đi từ";
            // 
            // rundijbt
            // 
            this.rundijbt.Location = new System.Drawing.Point(17, 70);
            this.rundijbt.Name = "rundijbt";
            this.rundijbt.Size = new System.Drawing.Size(73, 30);
            this.rundijbt.TabIndex = 16;
            this.rundijbt.Text = "Chạy";
            this.rundijbt.UseVisualStyleBackColor = true;
            this.rundijbt.Click += new System.EventHandler(this.rundijbt_Click);
            // 
            // dijto
            // 
            this.dijto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dijto.FormattingEnabled = true;
            this.dijto.Location = new System.Drawing.Point(148, 43);
            this.dijto.Name = "dijto";
            this.dijto.Size = new System.Drawing.Size(42, 21);
            this.dijto.TabIndex = 15;
            // 
            // dijfrom
            // 
            this.dijfrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dijfrom.FormattingEnabled = true;
            this.dijfrom.Location = new System.Drawing.Point(60, 43);
            this.dijfrom.MaxDropDownItems = 100;
            this.dijfrom.Name = "dijfrom";
            this.dijfrom.Size = new System.Drawing.Size(42, 21);
            this.dijfrom.TabIndex = 14;
            // 
            // exitdij
            // 
            this.exitdij.Location = new System.Drawing.Point(141, 70);
            this.exitdij.Name = "exitdij";
            this.exitdij.Size = new System.Drawing.Size(73, 30);
            this.exitdij.TabIndex = 17;
            this.exitdij.Text = "Thoát";
            this.exitdij.UseVisualStyleBackColor = true;
            this.exitdij.Click += new System.EventHandler(this.exitdij_Click);
            // 
            // PrimAndDijsktra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.dijGoto);
            this.Controls.Add(this.DuongDi);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.New);
            this.Controls.Add(this.PrintMatrix);
            this.Controls.Add(this.CreLine);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Nen);
            this.Name = "PrimAndDijsktra";
            this.Text = "Prim & Dijsktra";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PrimAndDijsktra_MouseClick);
            this.Nen.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DuongDi.ResumeLayout(false);
            this.DuongDi.PerformLayout();
            this.dijGoto.ResumeLayout(false);
            this.dijGoto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button PrintMatrix;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button CreLine;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Panel Nen;
        private System.Windows.Forms.Panel DuongDi;
        private System.Windows.Forms.Button GO;
        private System.Windows.Forms.ComboBox End;
        private System.Windows.Forms.ComboBox Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox GiaTri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton dijsktrarbt;
        private System.Windows.Forms.RadioButton primrbt;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel dijGoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dijto;
        private System.Windows.Forms.ComboBox dijfrom;
        private System.Windows.Forms.Button rundijbt;
        private System.Windows.Forms.Button exitdij;
    }
}

