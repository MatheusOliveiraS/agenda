namespace Agenda
{
    partial class ContactCreation
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
            this.name_txtbx = new System.Windows.Forms.TextBox();
            this.phone_txtbx = new System.Windows.Forms.MaskedTextBox();
            this.email_txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.create_btn = new System.Windows.Forms.Button();
            this.success_lbl = new System.Windows.Forms.Label();
            this.phone_failed_lbl = new System.Windows.Forms.Label();
            this.phone_num_cmbbox = new System.Windows.Forms.ComboBox();
            this.email_cmbbox = new System.Windows.Forms.ComboBox();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_txtbx
            // 
            this.name_txtbx.Location = new System.Drawing.Point(51, 75);
            this.name_txtbx.Name = "name_txtbx";
            this.name_txtbx.Size = new System.Drawing.Size(222, 20);
            this.name_txtbx.TabIndex = 0;
            this.name_txtbx.TextChanged += new System.EventHandler(this.name_txtbx_TextChanged);
            // 
            // phone_txtbx
            // 
            this.phone_txtbx.Location = new System.Drawing.Point(51, 149);
            this.phone_txtbx.Name = "phone_txtbx";
            this.phone_txtbx.Size = new System.Drawing.Size(222, 20);
            this.phone_txtbx.TabIndex = 1;
            this.phone_txtbx.TextChanged += new System.EventHandler(this.phone_txtbx_TextChanged);
            // 
            // email_txtbx
            // 
            this.email_txtbx.Location = new System.Drawing.Point(51, 228);
            this.email_txtbx.Name = "email_txtbx";
            this.email_txtbx.Size = new System.Drawing.Size(222, 20);
            this.email_txtbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(96, 298);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(128, 44);
            this.create_btn.TabIndex = 6;
            this.create_btn.Text = "Criar";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click_1);
            // 
            // success_lbl
            // 
            this.success_lbl.Location = new System.Drawing.Point(61, 268);
            this.success_lbl.Name = "success_lbl";
            this.success_lbl.Size = new System.Drawing.Size(199, 18);
            this.success_lbl.TabIndex = 7;
            this.success_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phone_failed_lbl
            // 
            this.phone_failed_lbl.Location = new System.Drawing.Point(51, 172);
            this.phone_failed_lbl.Name = "phone_failed_lbl";
            this.phone_failed_lbl.Size = new System.Drawing.Size(222, 20);
            this.phone_failed_lbl.TabIndex = 8;
            this.phone_failed_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phone_num_cmbbox
            // 
            this.phone_num_cmbbox.FormattingEnabled = true;
            this.phone_num_cmbbox.Location = new System.Drawing.Point(118, 122);
            this.phone_num_cmbbox.Name = "phone_num_cmbbox";
            this.phone_num_cmbbox.Size = new System.Drawing.Size(85, 21);
            this.phone_num_cmbbox.TabIndex = 9;
            this.phone_num_cmbbox.Text = " ";
            // 
            // email_cmbbox
            // 
            this.email_cmbbox.FormattingEnabled = true;
            this.email_cmbbox.Location = new System.Drawing.Point(118, 201);
            this.email_cmbbox.Name = "email_cmbbox";
            this.email_cmbbox.Size = new System.Drawing.Size(85, 21);
            this.email_cmbbox.TabIndex = 10;
            this.email_cmbbox.Text = " ";
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Location = new System.Drawing.Point(51, 125);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(49, 13);
            this.phone_lbl.TabIndex = 11;
            this.phone_lbl.Text = "Telefone";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(51, 204);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(35, 13);
            this.email_lbl.TabIndex = 12;
            this.email_lbl.Text = "E-mail";
            // 
            // ContactCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 372);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.phone_lbl);
            this.Controls.Add(this.email_cmbbox);
            this.Controls.Add(this.phone_num_cmbbox);
            this.Controls.Add(this.phone_failed_lbl);
            this.Controls.Add(this.success_lbl);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_txtbx);
            this.Controls.Add(this.phone_txtbx);
            this.Controls.Add(this.name_txtbx);
            this.Name = "ContactCreation";
            this.ShowIcon = false;
            this.Text = "ContactCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txtbx;
        private System.Windows.Forms.MaskedTextBox phone_txtbx;
        private System.Windows.Forms.TextBox email_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Label success_lbl;
        private System.Windows.Forms.Label phone_failed_lbl;
        private System.Windows.Forms.ComboBox phone_num_cmbbox;
        private System.Windows.Forms.ComboBox email_cmbbox;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.Label email_lbl;
    }
}