namespace Forms1
{
    partial class frmDataEntry
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
            this.grbDataEntry = new System.Windows.Forms.GroupBox();
            this.grbTimer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timTimer = new System.Windows.Forms.Timer(this.components);
            this.grbDataEntry.SuspendLayout();
            this.grbTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDataEntry
            // 
            this.grbDataEntry.Controls.Add(this.txtZip);
            this.grbDataEntry.Controls.Add(this.txtState);
            this.grbDataEntry.Controls.Add(this.txtCity);
            this.grbDataEntry.Controls.Add(this.txtAddress);
            this.grbDataEntry.Controls.Add(this.txtName);
            this.grbDataEntry.Controls.Add(this.label5);
            this.grbDataEntry.Controls.Add(this.label4);
            this.grbDataEntry.Controls.Add(this.label3);
            this.grbDataEntry.Controls.Add(this.label2);
            this.grbDataEntry.Controls.Add(this.label1);
            this.grbDataEntry.Location = new System.Drawing.Point(39, 32);
            this.grbDataEntry.Name = "grbDataEntry";
            this.grbDataEntry.Size = new System.Drawing.Size(269, 250);
            this.grbDataEntry.TabIndex = 0;
            this.grbDataEntry.TabStop = false;
            this.grbDataEntry.Text = "Data Entry";
            // 
            // grbTimer
            // 
            this.grbTimer.Controls.Add(this.txtTimer);
            this.grbTimer.Location = new System.Drawing.Point(431, 32);
            this.grbTimer.Name = "grbTimer";
            this.grbTimer.Size = new System.Drawing.Size(200, 100);
            this.grbTimer.TabIndex = 1;
            this.grbTimer.TabStop = false;
            this.grbTimer.Text = "Timer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(83, 79);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(157, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(83, 120);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(157, 20);
            this.txtCity.TabIndex = 7;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(83, 159);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(157, 20);
            this.txtState.TabIndex = 8;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(83, 203);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(157, 20);
            this.txtZip.TabIndex = 9;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(53, 326);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(224, 326);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTimer
            // 
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.Location = new System.Drawing.Point(50, 53);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ReadOnly = true;
            this.txtTimer.Size = new System.Drawing.Size(100, 22);
            this.txtTimer.TabIndex = 0;
            this.txtTimer.Text = "00:00:00";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(496, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(496, 198);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 13;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(496, 159);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timTimer
            // 
            this.timTimer.Interval = 1000;
            this.timTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 378);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.grbTimer);
            this.Controls.Add(this.grbDataEntry);
            this.Name = "frmDataEntry";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Data Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDataEntry.ResumeLayout(false);
            this.grbDataEntry.PerformLayout();
            this.grbTimer.ResumeLayout(false);
            this.grbTimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDataEntry;
        private System.Windows.Forms.GroupBox grbTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timTimer;
    }
}

