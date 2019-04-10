namespace MainForm
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
            this.txtInsertFirstName = new System.Windows.Forms.TextBox();
            this.txtInsertLastName = new System.Windows.Forms.TextBox();
            this.lblInsertFirstName = new System.Windows.Forms.Label();
            this.lblInsertLastName = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblUpdateId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.lblUpdateFirstName = new System.Windows.Forms.Label();
            this.lblUpdateLastName = new System.Windows.Forms.Label();
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDeleteId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInsertFirstName
            // 
            this.txtInsertFirstName.Location = new System.Drawing.Point(12, 12);
            this.txtInsertFirstName.Name = "txtInsertFirstName";
            this.txtInsertFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtInsertFirstName.TabIndex = 1;
            // 
            // txtInsertLastName
            // 
            this.txtInsertLastName.Location = new System.Drawing.Point(12, 39);
            this.txtInsertLastName.Name = "txtInsertLastName";
            this.txtInsertLastName.Size = new System.Drawing.Size(100, 20);
            this.txtInsertLastName.TabIndex = 2;
            // 
            // lblInsertFirstName
            // 
            this.lblInsertFirstName.AutoSize = true;
            this.lblInsertFirstName.Location = new System.Drawing.Point(119, 18);
            this.lblInsertFirstName.Name = "lblInsertFirstName";
            this.lblInsertFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblInsertFirstName.TabIndex = 4;
            this.lblInsertFirstName.Text = "First name";
            // 
            // lblInsertLastName
            // 
            this.lblInsertLastName.AutoSize = true;
            this.lblInsertLastName.Location = new System.Drawing.Point(119, 45);
            this.lblInsertLastName.Name = "lblInsertLastName";
            this.lblInsertLastName.Size = new System.Drawing.Size(56, 13);
            this.lblInsertLastName.TabIndex = 5;
            this.lblInsertLastName.Text = "Last name";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(196, 10);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 120);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 7;
            // 
            // lblUpdateId
            // 
            this.lblUpdateId.AutoSize = true;
            this.lblUpdateId.Location = new System.Drawing.Point(119, 123);
            this.lblUpdateId.Name = "lblUpdateId";
            this.lblUpdateId.Size = new System.Drawing.Size(16, 13);
            this.lblUpdateId.TabIndex = 8;
            this.lblUpdateId.Text = "Id";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(196, 120);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(12, 147);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateFirstName.TabIndex = 10;
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Location = new System.Drawing.Point(12, 174);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateLastName.TabIndex = 11;
            // 
            // lblUpdateFirstName
            // 
            this.lblUpdateFirstName.AutoSize = true;
            this.lblUpdateFirstName.Location = new System.Drawing.Point(119, 150);
            this.lblUpdateFirstName.Name = "lblUpdateFirstName";
            this.lblUpdateFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblUpdateFirstName.TabIndex = 12;
            this.lblUpdateFirstName.Text = "First name";
            // 
            // lblUpdateLastName
            // 
            this.lblUpdateLastName.AutoSize = true;
            this.lblUpdateLastName.Location = new System.Drawing.Point(119, 177);
            this.lblUpdateLastName.Name = "lblUpdateLastName";
            this.lblUpdateLastName.Size = new System.Drawing.Size(56, 13);
            this.lblUpdateLastName.TabIndex = 13;
            this.lblUpdateLastName.Text = "Last name";
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.Location = new System.Drawing.Point(12, 254);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteId.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(196, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDeleteId
            // 
            this.lblDeleteId.AutoSize = true;
            this.lblDeleteId.Location = new System.Drawing.Point(119, 257);
            this.lblDeleteId.Name = "lblDeleteId";
            this.lblDeleteId.Size = new System.Drawing.Size(16, 13);
            this.lblDeleteId.TabIndex = 16;
            this.lblDeleteId.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDeleteId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDeleteId);
            this.Controls.Add(this.lblUpdateLastName);
            this.Controls.Add(this.lblUpdateFirstName);
            this.Controls.Add(this.txtUpdateLastName);
            this.Controls.Add(this.txtUpdateFirstName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblUpdateId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblInsertLastName);
            this.Controls.Add(this.lblInsertFirstName);
            this.Controls.Add(this.txtInsertLastName);
            this.Controls.Add(this.txtInsertFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInsertFirstName;
        private System.Windows.Forms.TextBox txtInsertLastName;
        private System.Windows.Forms.Label lblInsertFirstName;
        private System.Windows.Forms.Label lblInsertLastName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblUpdateId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.Label lblUpdateFirstName;
        private System.Windows.Forms.Label lblUpdateLastName;
        private System.Windows.Forms.TextBox txtDeleteId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDeleteId;
    }
}

