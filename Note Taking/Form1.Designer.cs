namespace Note_Taking
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Titl = new Label();
            Msg = new Label();
            txtTitle = new TextBox();
            txtMsg = new TextBox();
            dataGridView1 = new DataGridView();
            BtnNew = new Button();
            BtnSave = new Button();
            BtnRead = new Button();
            BtnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Titl
            // 
            Titl.AutoSize = true;
            Titl.Font = new Font("Singapore Sling Expanded", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Titl.Location = new Point(82, 41);
            Titl.Name = "Titl";
            Titl.Size = new Size(54, 15);
            Titl.TabIndex = 0;
            Titl.Text = "Title";
            Titl.Click += label1_Click;
            // 
            // Msg
            // 
            Msg.AutoSize = true;
            Msg.Font = new Font("Singapore Sling Expanded", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Msg.Location = new Point(47, 211);
            Msg.Name = "Msg";
            Msg.Size = new Size(99, 15);
            Msg.TabIndex = 1;
            Msg.Text = "Message";
            Msg.Click += label1_Click_1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(162, 38);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(201, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtMsg
            // 
            txtMsg.Location = new Point(162, 138);
            txtMsg.Multiline = true;
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(201, 166);
            txtMsg.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(438, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(280, 250);
            dataGridView1.TabIndex = 4;
            // 
            // BtnNew
            // 
            BtnNew.Font = new Font("Singapore Sling Expanded", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNew.Location = new Point(95, 332);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(100, 52);
            BtnNew.TabIndex = 5;
            BtnNew.Text = "New";
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnSave
            // 
            BtnSave.Font = new Font("Singapore Sling Expanded", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSave.Location = new Point(256, 332);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(107, 52);
            BtnSave.TabIndex = 6;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnRead
            // 
            BtnRead.Font = new Font("Singapore Sling Expanded", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRead.Location = new Point(438, 332);
            BtnRead.Name = "BtnRead";
            BtnRead.Size = new Size(116, 52);
            BtnRead.TabIndex = 7;
            BtnRead.Text = "Read";
            BtnRead.UseVisualStyleBackColor = true;
            BtnRead.Click += BtnRead_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Singapore Sling Expanded", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDelete.Location = new Point(600, 332);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(118, 52);
            BtnDelete.TabIndex = 8;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnDelete);
            Controls.Add(BtnRead);
            Controls.Add(BtnSave);
            Controls.Add(BtnNew);
            Controls.Add(dataGridView1);
            Controls.Add(txtMsg);
            Controls.Add(txtTitle);
            Controls.Add(Msg);
            Controls.Add(Titl);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Note Taking App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titl;
        private Label Msg;
        private TextBox txtTitle;
        private TextBox txtMsg;
        private DataGridView dataGridView1;
        private Button BtnNew;
        private Button BtnSave;
        private Button BtnRead;
        private Button BtnDelete;
    }
}