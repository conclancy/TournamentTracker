
namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.selectPlayerDropDown = new System.Windows.Forms.ComboBox();
            this.selectPlayerLabel = new System.Windows.Forms.Label();
            this.newPlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.cellPhoneValue = new System.Windows.Forms.TextBox();
            this.cellPhoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamPlayerListBox = new System.Windows.Forms.ListBox();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.saveTeamButton = new System.Windows.Forms.Button();
            this.newPlayerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(35, 109);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(332, 35);
            this.teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamNameLabel.Location = new System.Drawing.Point(28, 69);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(157, 37);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(26, 20);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(213, 50);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Create Team";
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addPlayerButton.Location = new System.Drawing.Point(105, 243);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(181, 38);
            this.addPlayerButton.TabIndex = 19;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            // 
            // selectPlayerDropDown
            // 
            this.selectPlayerDropDown.FormattingEnabled = true;
            this.selectPlayerDropDown.Location = new System.Drawing.Point(36, 199);
            this.selectPlayerDropDown.Name = "selectPlayerDropDown";
            this.selectPlayerDropDown.Size = new System.Drawing.Size(331, 38);
            this.selectPlayerDropDown.TabIndex = 18;
            // 
            // selectPlayerLabel
            // 
            this.selectPlayerLabel.AutoSize = true;
            this.selectPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPlayerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectPlayerLabel.Location = new System.Drawing.Point(29, 159);
            this.selectPlayerLabel.Name = "selectPlayerLabel";
            this.selectPlayerLabel.Size = new System.Drawing.Size(166, 37);
            this.selectPlayerLabel.TabIndex = 17;
            this.selectPlayerLabel.Text = "Select Player";
            // 
            // newPlayerGroupBox
            // 
            this.newPlayerGroupBox.Controls.Add(this.createPlayerButton);
            this.newPlayerGroupBox.Controls.Add(this.cellPhoneValue);
            this.newPlayerGroupBox.Controls.Add(this.cellPhoneLabel);
            this.newPlayerGroupBox.Controls.Add(this.emailValue);
            this.newPlayerGroupBox.Controls.Add(this.emailLabel);
            this.newPlayerGroupBox.Controls.Add(this.lastNameValue);
            this.newPlayerGroupBox.Controls.Add(this.lastNameLabel);
            this.newPlayerGroupBox.Controls.Add(this.firstNameValue);
            this.newPlayerGroupBox.Controls.Add(this.firstNameLabel);
            this.newPlayerGroupBox.Location = new System.Drawing.Point(36, 320);
            this.newPlayerGroupBox.Name = "newPlayerGroupBox";
            this.newPlayerGroupBox.Size = new System.Drawing.Size(345, 245);
            this.newPlayerGroupBox.TabIndex = 20;
            this.newPlayerGroupBox.TabStop = false;
            this.newPlayerGroupBox.Text = "Add New Player";
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPlayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPlayerButton.Location = new System.Drawing.Point(69, 194);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(181, 44);
            this.createPlayerButton.TabIndex = 21;
            this.createPlayerButton.Text = "Create Player";
            this.createPlayerButton.UseVisualStyleBackColor = true;
            this.createPlayerButton.Click += new System.EventHandler(this.createPlayerButton_Click);
            // 
            // cellPhoneValue
            // 
            this.cellPhoneValue.Location = new System.Drawing.Point(125, 151);
            this.cellPhoneValue.Name = "cellPhoneValue";
            this.cellPhoneValue.Size = new System.Drawing.Size(206, 35);
            this.cellPhoneValue.TabIndex = 28;
            // 
            // cellPhoneLabel
            // 
            this.cellPhoneLabel.AutoSize = true;
            this.cellPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cellPhoneLabel.Location = new System.Drawing.Point(6, 154);
            this.cellPhoneLabel.Name = "cellPhoneLabel";
            this.cellPhoneLabel.Size = new System.Drawing.Size(117, 30);
            this.cellPhoneLabel.TabIndex = 27;
            this.cellPhoneLabel.Text = "Cell Phone:";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(125, 111);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(206, 35);
            this.emailValue.TabIndex = 26;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.emailLabel.Location = new System.Drawing.Point(6, 114);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(68, 30);
            this.emailLabel.TabIndex = 25;
            this.emailLabel.Text = "Email:";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(125, 71);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(206, 35);
            this.lastNameValue.TabIndex = 24;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lastNameLabel.Location = new System.Drawing.Point(6, 74);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(117, 30);
            this.lastNameLabel.TabIndex = 23;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(125, 31);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(206, 35);
            this.firstNameValue.TabIndex = 22;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstNameLabel.Location = new System.Drawing.Point(6, 34);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(124, 30);
            this.firstNameLabel.TabIndex = 21;
            this.firstNameLabel.Text = "First Name: ";
            // 
            // teamPlayerListBox
            // 
            this.teamPlayerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamPlayerListBox.FormattingEnabled = true;
            this.teamPlayerListBox.ItemHeight = 30;
            this.teamPlayerListBox.Location = new System.Drawing.Point(411, 109);
            this.teamPlayerListBox.Name = "teamPlayerListBox";
            this.teamPlayerListBox.Size = new System.Drawing.Size(342, 392);
            this.teamPlayerListBox.TabIndex = 21;
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removePlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removePlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePlayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePlayerButton.ForeColor = System.Drawing.Color.Red;
            this.removePlayerButton.Location = new System.Drawing.Point(494, 517);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(181, 38);
            this.removePlayerButton.TabIndex = 29;
            this.removePlayerButton.Text = "Remove Player";
            this.removePlayerButton.UseVisualStyleBackColor = true;
            // 
            // saveTeamButton
            // 
            this.saveTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.saveTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.saveTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.saveTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTeamButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.saveTeamButton.Location = new System.Drawing.Point(572, 32);
            this.saveTeamButton.Name = "saveTeamButton";
            this.saveTeamButton.Size = new System.Drawing.Size(181, 38);
            this.saveTeamButton.TabIndex = 30;
            this.saveTeamButton.Text = "Save Team";
            this.saveTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 577);
            this.Controls.Add(this.saveTeamButton);
            this.Controls.Add(this.removePlayerButton);
            this.Controls.Add(this.teamPlayerListBox);
            this.Controls.Add(this.newPlayerGroupBox);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.selectPlayerDropDown);
            this.Controls.Add(this.selectPlayerLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.newPlayerGroupBox.ResumeLayout(false);
            this.newPlayerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.ComboBox selectPlayerDropDown;
        private System.Windows.Forms.Label selectPlayerLabel;
        private System.Windows.Forms.GroupBox newPlayerGroupBox;
        private System.Windows.Forms.TextBox cellPhoneValue;
        private System.Windows.Forms.Label cellPhoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button createPlayerButton;
        private System.Windows.Forms.ListBox teamPlayerListBox;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.Button saveTeamButton;
    }
}