namespace UserMaintenance
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
      this.listUsers = new System.Windows.Forms.ListBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.lblFirstName = new System.Windows.Forms.Label();
      this.lblLastName = new System.Windows.Forms.Label();
      this.txtFirstName = new System.Windows.Forms.TextBox();
      this.txtLastName = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // listUsers
      // 
      this.listUsers.FormattingEnabled = true;
      this.listUsers.Location = new System.Drawing.Point(12, 12);
      this.listUsers.Name = "listUsers";
      this.listUsers.Size = new System.Drawing.Size(279, 420);
      this.listUsers.TabIndex = 0;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(318, 115);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(306, 23);
      this.btnAdd.TabIndex = 1;
      this.btnAdd.Text = "button1";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // lblFirstName
      // 
      this.lblFirstName.AutoSize = true;
      this.lblFirstName.Location = new System.Drawing.Point(315, 32);
      this.lblFirstName.Name = "lblFirstName";
      this.lblFirstName.Size = new System.Drawing.Size(35, 13);
      this.lblFirstName.TabIndex = 2;
      this.lblFirstName.Text = "label1";
      // 
      // lblLastName
      // 
      this.lblLastName.AutoSize = true;
      this.lblLastName.Location = new System.Drawing.Point(315, 70);
      this.lblLastName.Name = "lblLastName";
      this.lblLastName.Size = new System.Drawing.Size(35, 13);
      this.lblLastName.TabIndex = 3;
      this.lblLastName.Text = "label2";
      // 
      // txtFirstName
      // 
      this.txtFirstName.Location = new System.Drawing.Point(427, 29);
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.Size = new System.Drawing.Size(197, 20);
      this.txtFirstName.TabIndex = 4;
      // 
      // txtLastName
      // 
      this.txtLastName.Location = new System.Drawing.Point(427, 67);
      this.txtLastName.Name = "txtLastName";
      this.txtLastName.Size = new System.Drawing.Size(197, 20);
      this.txtLastName.TabIndex = 5;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(636, 442);
      this.Controls.Add(this.txtLastName);
      this.Controls.Add(this.txtFirstName);
      this.Controls.Add(this.lblLastName);
      this.Controls.Add(this.lblFirstName);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.listUsers);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
    }
}

