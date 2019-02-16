namespace Agenda
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
            this.contacts_dataGrid = new System.Windows.Forms.DataGridView();
            this.nome_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_contact_btn = new System.Windows.Forms.Button();
            this.index_cmbbox = new System.Windows.Forms.ComboBox();
            this.delete_lnklbl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.contacts_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contacts_dataGrid
            // 
            this.contacts_dataGrid.AllowUserToAddRows = false;
            this.contacts_dataGrid.AllowUserToDeleteRows = false;
            this.contacts_dataGrid.AllowUserToResizeRows = false;
            this.contacts_dataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.contacts_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contacts_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome_clmn,
            this.tel_clmn,
            this.email_clmn});
            this.contacts_dataGrid.Location = new System.Drawing.Point(39, 68);
            this.contacts_dataGrid.Name = "contacts_dataGrid";
            this.contacts_dataGrid.ReadOnly = true;
            this.contacts_dataGrid.Size = new System.Drawing.Size(513, 194);
            this.contacts_dataGrid.TabIndex = 0;
            this.contacts_dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contacts_dataGrid_CellDoubleClick);
            this.contacts_dataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.contacts_dataGrid_CellMouseClick);
            // 
            // nome_clmn
            // 
            this.nome_clmn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome_clmn.HeaderText = "Nome";
            this.nome_clmn.Name = "nome_clmn";
            this.nome_clmn.ReadOnly = true;
            // 
            // tel_clmn
            // 
            this.tel_clmn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tel_clmn.HeaderText = "Telefone";
            this.tel_clmn.Name = "tel_clmn";
            this.tel_clmn.ReadOnly = true;
            // 
            // email_clmn
            // 
            this.email_clmn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email_clmn.HeaderText = "E-mail";
            this.email_clmn.Name = "email_clmn";
            this.email_clmn.ReadOnly = true;
            // 
            // new_contact_btn
            // 
            this.new_contact_btn.Location = new System.Drawing.Point(230, 268);
            this.new_contact_btn.Name = "new_contact_btn";
            this.new_contact_btn.Size = new System.Drawing.Size(112, 44);
            this.new_contact_btn.TabIndex = 2;
            this.new_contact_btn.Text = "Novo contato";
            this.new_contact_btn.UseVisualStyleBackColor = true;
            this.new_contact_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // index_cmbbox
            // 
            this.index_cmbbox.FormattingEnabled = true;
            this.index_cmbbox.Location = new System.Drawing.Point(39, 23);
            this.index_cmbbox.Name = "index_cmbbox";
            this.index_cmbbox.Size = new System.Drawing.Size(87, 21);
            this.index_cmbbox.TabIndex = 3;
            this.index_cmbbox.Text = "Índice";
            this.index_cmbbox.SelectedIndexChanged += new System.EventHandler(this.index_cmbbox_SelectedIndexChanged);
            // 
            // delete_lnklbl
            // 
            this.delete_lnklbl.AutoSize = true;
            this.delete_lnklbl.Location = new System.Drawing.Point(482, 291);
            this.delete_lnklbl.Name = "delete_lnklbl";
            this.delete_lnklbl.Size = new System.Drawing.Size(80, 13);
            this.delete_lnklbl.TabIndex = 4;
            this.delete_lnklbl.TabStop = true;
            this.delete_lnklbl.Text = "Deletar contato";
            this.delete_lnklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.delete_lnklbl_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.delete_lnklbl);
            this.Controls.Add(this.index_cmbbox);
            this.Controls.Add(this.new_contact_btn);
            this.Controls.Add(this.contacts_dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.contacts_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button new_contact_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_clmn;
        private System.Windows.Forms.ComboBox index_cmbbox;
        private System.Windows.Forms.DataGridView contacts_dataGrid;
        private System.Windows.Forms.LinkLabel delete_lnklbl;
    }
}

