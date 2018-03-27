using System.Windows.Forms;

namespace QLHangHoa
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSystem = new System.Windows.Forms.Button();
            this.btnApplication = new System.Windows.Forms.Button();
            this.btnIntroduction = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbApplication = new System.Windows.Forms.GroupBox();
            this.grbWarehouse = new System.Windows.Forms.GroupBox();
            this.grbSale = new System.Windows.Forms.GroupBox();
            this.grbContact = new System.Windows.Forms.GroupBox();
            this.grbIntroduction = new System.Windows.Forms.GroupBox();
            this.grbSystem = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbApplication.SuspendLayout();
            this.grbSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.btnSystem);
            this.groupBox1.Controls.Add(this.btnApplication);
            this.groupBox1.Controls.Add(this.btnIntroduction);
            this.groupBox1.Controls.Add(this.btnContact);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSystem
            // 
            this.btnSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSystem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSystem.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystem.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSystem.Location = new System.Drawing.Point(11, 23);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(211, 50);
            this.btnSystem.TabIndex = 4;
            this.btnSystem.Text = "System";
            this.btnSystem.UseVisualStyleBackColor = false;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // btnApplication
            // 
            this.btnApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplication.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnApplication.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplication.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplication.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnApplication.Location = new System.Drawing.Point(11, 109);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(211, 50);
            this.btnApplication.TabIndex = 5;
            this.btnApplication.Text = "Application";
            this.btnApplication.UseVisualStyleBackColor = false;
            this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);
            // 
            // btnIntroduction
            // 
            this.btnIntroduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIntroduction.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnIntroduction.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnIntroduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntroduction.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntroduction.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnIntroduction.Location = new System.Drawing.Point(11, 195);
            this.btnIntroduction.Name = "btnIntroduction";
            this.btnIntroduction.Size = new System.Drawing.Size(211, 50);
            this.btnIntroduction.TabIndex = 6;
            this.btnIntroduction.Text = "Intrduction";
            this.btnIntroduction.UseVisualStyleBackColor = false;
            this.btnIntroduction.Click += new System.EventHandler(this.btnIntroduction_Click);
            // 
            // btnContact
            // 
            this.btnContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContact.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnContact.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnContact.Location = new System.Drawing.Point(11, 281);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(211, 50);
            this.btnContact.TabIndex = 7;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Controls.Add(this.grbApplication);
            this.groupBox2.Controls.Add(this.grbContact);
            this.groupBox2.Controls.Add(this.grbIntroduction);
            this.groupBox2.Controls.Add(this.grbSystem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(249, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 351);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // grbApplication
            // 
            this.grbApplication.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grbApplication.Controls.Add(this.grbWarehouse);
            this.grbApplication.Controls.Add(this.grbSale);
            this.grbApplication.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApplication.ForeColor = System.Drawing.Color.DarkBlue;
            this.grbApplication.Location = new System.Drawing.Point(10, 12);
            this.grbApplication.Name = "grbApplication";
            this.grbApplication.Size = new System.Drawing.Size(245, 332);
            this.grbApplication.TabIndex = 0;
            this.grbApplication.TabStop = false;
            this.grbApplication.Text = "Application";
            this.grbApplication.Visible = false;
            // 
            // grbWarehouse
            // 
            this.grbWarehouse.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grbWarehouse.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbWarehouse.ForeColor = System.Drawing.Color.DarkBlue;
            this.grbWarehouse.Location = new System.Drawing.Point(6, 176);
            this.grbWarehouse.Name = "grbWarehouse";
            this.grbWarehouse.Size = new System.Drawing.Size(232, 153);
            this.grbWarehouse.TabIndex = 1;
            this.grbWarehouse.TabStop = false;
            this.grbWarehouse.Text = "Warehouse";
            // 
            // grbSale
            // 
            this.grbSale.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grbSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSale.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSale.ForeColor = System.Drawing.Color.DarkBlue;
            this.grbSale.Location = new System.Drawing.Point(6, 21);
            this.grbSale.Name = "grbSale";
            this.grbSale.Size = new System.Drawing.Size(232, 153);
            this.grbSale.TabIndex = 0;
            this.grbSale.TabStop = false;
            this.grbSale.Text = "Sale";
            // 
            // grbContact
            // 
            this.grbContact.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grbContact.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbContact.ForeColor = System.Drawing.Color.DarkBlue;
            this.grbContact.Location = new System.Drawing.Point(10, 12);
            this.grbContact.Name = "grbContact";
            this.grbContact.Size = new System.Drawing.Size(245, 332);
            this.grbContact.TabIndex = 0;
            this.grbContact.TabStop = false;
            this.grbContact.Text = "Contact";
            this.grbContact.Visible = false;
            // 
            // grbIntroduction
            // 
            this.grbIntroduction.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grbIntroduction.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbIntroduction.ForeColor = System.Drawing.Color.DarkBlue;
            this.grbIntroduction.Location = new System.Drawing.Point(10, 12);
            this.grbIntroduction.Name = "grbIntroduction";
            this.grbIntroduction.Size = new System.Drawing.Size(245, 332);
            this.grbIntroduction.TabIndex = 0;
            this.grbIntroduction.TabStop = false;
            this.grbIntroduction.Text = "Introduction";
            this.grbIntroduction.Visible = false;
            // 
            // grbSystem
            // 
            this.grbSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grbSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbSystem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grbSystem.Controls.Add(this.btnExit);
            this.grbSystem.Controls.Add(this.btnChangePassword);
            this.grbSystem.Controls.Add(this.btnAddAccount);
            this.grbSystem.Controls.Add(this.btnLogOut);
            this.grbSystem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSystem.ForeColor = System.Drawing.Color.DarkBlue;
            this.grbSystem.Location = new System.Drawing.Point(10, 12);
            this.grbSystem.Margin = new System.Windows.Forms.Padding(0);
            this.grbSystem.Name = "grbSystem";
            this.grbSystem.Size = new System.Drawing.Size(245, 332);
            this.grbSystem.TabIndex = 0;
            this.grbSystem.TabStop = false;
            this.grbSystem.Text = "System";
            this.grbSystem.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnExit.Location = new System.Drawing.Point(22, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnChangePassword.Location = new System.Drawing.Point(22, 199);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(200, 40);
            this.btnChangePassword.TabIndex = 0;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddAccount.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddAccount.Location = new System.Drawing.Point(22, 118);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(200, 40);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLogOut.Location = new System.Drawing.Point(22, 37);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 40);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(525, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grbApplication.ResumeLayout(false);
            this.grbSystem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSystem;
        private Button btnApplication;
        private Button btnIntroduction;
        private Button btnContact;
        private GroupBox groupBox2;
        private GroupBox grbApplication;
        private GroupBox grbWarehouse;
        private GroupBox grbSale;
        private GroupBox grbContact;
        private GroupBox grbIntroduction;
        private GroupBox grbSystem;
        private Button btnExit;
        private Button btnChangePassword;
        private Button btnAddAccount;
        private Button btnLogOut;
    }
}