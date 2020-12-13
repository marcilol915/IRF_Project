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
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.dataGridView1);
            this.mainPanel.Controls.Add(this.buttonColor);
            this.mainPanel.Controls.Add(this.buttonMercedes);
            this.mainPanel.Controls.Add(this.buttonBmw);
            this.mainPanel.Controls.Add(this.buttonAudi);
            this.mainPanel.Controls.Add(this.buttonWheel);
            this.mainPanel.Location = new System.Drawing.Point(2, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1098, 617);
            this.mainPanel.TabIndex = 0;
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(152, 175);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 630);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
    }
}

