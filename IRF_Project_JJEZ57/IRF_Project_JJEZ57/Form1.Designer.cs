namespace IRF_Project_JJEZ57
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonMercedes = new System.Windows.Forms.Button();
            this.buttonBmw = new System.Windows.Forms.Button();
            this.buttonAudi = new System.Windows.Forms.Button();
            this.buttonWheel = new System.Windows.Forms.Button();
            this.CreateTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timerWheel = new System.Windows.Forms.Timer(this.components);
            this.timerBmw = new System.Windows.Forms.Timer(this.components);
            this.timerAudi = new System.Windows.Forms.Timer(this.components);
            this.timerMercedes = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.buttonMentes);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.dataGridView1);
            this.mainPanel.Controls.Add(this.buttonColor);
            this.mainPanel.Controls.Add(this.buttonMercedes);
            this.mainPanel.Controls.Add(this.buttonBmw);
            this.mainPanel.Controls.Add(this.buttonAudi);
            this.mainPanel.Controls.Add(this.buttonWheel);
            this.mainPanel.Location = new System.Drawing.Point(2, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1098, 432);
            this.mainPanel.TabIndex = 0;
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(201, 176);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 4;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonMercedes
            // 
            this.buttonMercedes.Location = new System.Drawing.Point(30, 303);
            this.buttonMercedes.Name = "buttonMercedes";
            this.buttonMercedes.Size = new System.Drawing.Size(75, 23);
            this.buttonMercedes.TabIndex = 3;
            this.buttonMercedes.Text = "Mercedes";
            this.buttonMercedes.UseVisualStyleBackColor = true;
            this.buttonMercedes.Click += new System.EventHandler(this.buttonMercedes_Click);
            // 
            // buttonBmw
            // 
            this.buttonBmw.Location = new System.Drawing.Point(30, 263);
            this.buttonBmw.Name = "buttonBmw";
            this.buttonBmw.Size = new System.Drawing.Size(75, 23);
            this.buttonBmw.TabIndex = 2;
            this.buttonBmw.Text = "BMW";
            this.buttonBmw.UseVisualStyleBackColor = true;
            this.buttonBmw.Click += new System.EventHandler(this.buttonBmw_Click);
            // 
            // buttonAudi
            // 
            this.buttonAudi.Location = new System.Drawing.Point(30, 221);
            this.buttonAudi.Name = "buttonAudi";
            this.buttonAudi.Size = new System.Drawing.Size(75, 23);
            this.buttonAudi.TabIndex = 1;
            this.buttonAudi.Text = "Audi";
            this.buttonAudi.UseVisualStyleBackColor = true;
            this.buttonAudi.Click += new System.EventHandler(this.buttonAudi_Click);
            // 
            // buttonWheel
            // 
            this.buttonWheel.Location = new System.Drawing.Point(30, 176);
            this.buttonWheel.Name = "buttonWheel";
            this.buttonWheel.Size = new System.Drawing.Size(75, 23);
            this.buttonWheel.TabIndex = 0;
            this.buttonWheel.Text = "Wheel";
            this.buttonWheel.UseVisualStyleBackColor = true;
            this.buttonWheel.Click += new System.EventHandler(this.buttonWheel_Click);
            // 
            // CreateTimer
            // 
            this.CreateTimer.Enabled = true;
            this.CreateTimer.Interval = 3000;
            this.CreateTimer.Tick += new System.EventHandler(this.CreateTimer_Tick);
            // 
            // MoveTimer
            // 
            this.MoveTimer.Enabled = true;
            this.MoveTimer.Interval = 10;
            this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(477, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // timerWheel
            // 
            this.timerWheel.Interval = 3000;
            this.timerWheel.Tick += new System.EventHandler(this.timerWheel_Tick);
            // 
            // timerBmw
            // 
            this.timerBmw.Interval = 3000;
            this.timerBmw.Tick += new System.EventHandler(this.timerBmw_Tick);
            // 
            // timerAudi
            // 
            this.timerAudi.Interval = 3000;
            this.timerAudi.Tick += new System.EventHandler(this.timerAudi_Tick);
            // 
            // timerMercedes
            // 
            this.timerMercedes.Interval = 3000;
            this.timerMercedes.Tick += new System.EventHandler(this.timerMercedes_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gyártás szünteteltetése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(30, 390);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(197, 23);
            this.buttonMentes.TabIndex = 7;
            this.buttonMentes.Text = "Készlet mentése fájlba";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Milyen színű legyen a gumi?\r\nKérem válasszon!\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kérem\r\nválasszon terméket!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Név";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Azonosító szám";
            // 
            // textBoxuser
            // 
            this.textBoxuser.Location = new System.Drawing.Point(528, 530);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(100, 22);
            this.textBoxuser.TabIndex = 12;
            this.textBoxuser.TextChanged += new System.EventHandler(this.textBoxuser_TextChanged);
            this.textBoxuser.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxuser_Validating);
            // 
            // textBoxpass
            // 
            this.textBoxpass.Location = new System.Drawing.Point(528, 565);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(100, 22);
            this.textBoxpass.TabIndex = 13;
            this.textBoxpass.TextChanged += new System.EventHandler(this.textBoxpass_TextChanged);
            this.textBoxpass.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxpass_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Belépéshez adja meg adatait!";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 630);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxuser);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer CreateTimer;
        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.Button buttonMercedes;
        private System.Windows.Forms.Button buttonBmw;
        private System.Windows.Forms.Button buttonAudi;
        private System.Windows.Forms.Button buttonWheel;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timerWheel;
        private System.Windows.Forms.Timer timerBmw;
        private System.Windows.Forms.Timer timerAudi;
        private System.Windows.Forms.Timer timerMercedes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

