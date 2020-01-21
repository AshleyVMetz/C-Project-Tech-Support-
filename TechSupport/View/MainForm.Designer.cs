namespace TechSupport.View
{
    partial class MainForm
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
            this.userNameLabelMain = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.LinkLabel();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.searchIncidentButton = new System.Windows.Forms.Button();
            this.dataGridViewIncidents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncidents)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabelMain
            // 
            this.userNameLabelMain.AutoSize = true;
            this.userNameLabelMain.Location = new System.Drawing.Point(533, 31);
            this.userNameLabelMain.Name = "userNameLabelMain";
            this.userNameLabelMain.Size = new System.Drawing.Size(73, 17);
            this.userNameLabelMain.TabIndex = 0;
            this.userNameLabelMain.Text = "userName";
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Location = new System.Drawing.Point(533, 66);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(52, 17);
            this.logout.TabIndex = 1;
            this.logout.TabStop = true;
            this.logout.Text = "Logout";
            this.logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_LinkClicked);
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.Location = new System.Drawing.Point(60, 25);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(223, 23);
            this.addIncidentButton.TabIndex = 2;
            this.addIncidentButton.Text = "Add Incident";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.addIncidentButton_Click);
            // 
            // searchIncidentButton
            // 
            this.searchIncidentButton.Location = new System.Drawing.Point(60, 66);
            this.searchIncidentButton.Name = "searchIncidentButton";
            this.searchIncidentButton.Size = new System.Drawing.Size(223, 45);
            this.searchIncidentButton.TabIndex = 3;
            this.searchIncidentButton.Text = "Search Incident";
            this.searchIncidentButton.UseVisualStyleBackColor = true;
            this.searchIncidentButton.Click += new System.EventHandler(this.searchIncidentButton_Click);
            // 
            // dataGridViewIncidents
            // 
            this.dataGridViewIncidents.AllowUserToAddRows = false;
            this.dataGridViewIncidents.AllowUserToDeleteRows = false;
            this.dataGridViewIncidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncidents.Location = new System.Drawing.Point(60, 138);
            this.dataGridViewIncidents.Name = "dataGridViewIncidents";
            this.dataGridViewIncidents.ReadOnly = true;
            this.dataGridViewIncidents.RowHeadersWidth = 51;
            this.dataGridViewIncidents.RowTemplate.Height = 24;
            this.dataGridViewIncidents.Size = new System.Drawing.Size(580, 241);
            this.dataGridViewIncidents.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewIncidents);
            this.Controls.Add(this.searchIncidentButton);
            this.Controls.Add(this.addIncidentButton);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.userNameLabelMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncidents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabelMain;
        private System.Windows.Forms.LinkLabel logout;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Button searchIncidentButton;
        private System.Windows.Forms.DataGridView dataGridViewIncidents;
    }
}