﻿namespace UserMaintenance
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
      this.lblFullName = new System.Windows.Forms.Label();
      this.txtFullName = new System.Windows.Forms.TextBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
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
      this.btnAdd.Location = new System.Drawing.Point(318, 71);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(306, 23);
      this.btnAdd.TabIndex = 1;
      this.btnAdd.Text = "button1";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // lblFullName
      // 
      this.lblFullName.AutoSize = true;
      this.lblFullName.Location = new System.Drawing.Point(315, 26);
      this.lblFullName.Name = "lblFullName";
      this.lblFullName.Size = new System.Drawing.Size(35, 13);
      this.lblFullName.TabIndex = 3;
      this.lblFullName.Text = "label2";
      // 
      // txtFullName
      // 
      this.txtFullName.Location = new System.Drawing.Point(427, 23);
      this.txtFullName.Name = "txtFullName";
      this.txtFullName.Size = new System.Drawing.Size(197, 20);
      this.txtFullName.TabIndex = 5;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(318, 407);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(306, 23);
      this.btnSave.TabIndex = 6;
      this.btnSave.Text = "button1";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(318, 100);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(306, 23);
      this.btnDelete.TabIndex = 7;
      this.btnDelete.Text = "button1";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(636, 442);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txtFullName);
      this.Controls.Add(this.lblFullName);
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
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}

