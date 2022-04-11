namespace PakTestWin
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
            this.btnClickMe = new System.Windows.Forms.Button();
            this.lblPathWoW = new System.Windows.Forms.Label();
            this.openWoWExe = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCharacter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textRealm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnFindPath = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.groupSettings = new System.Windows.Forms.GroupBox();
            this.btnActorAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listActors = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openConfig = new System.Windows.Forms.OpenFileDialog();
            this.btnActorRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(6, 26);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(125, 29);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "choose WoW";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // lblPathWoW
            // 
            this.lblPathWoW.AutoSize = true;
            this.lblPathWoW.Location = new System.Drawing.Point(137, 30);
            this.lblPathWoW.Name = "lblPathWoW";
            this.lblPathWoW.Size = new System.Drawing.Size(50, 20);
            this.lblPathWoW.TabIndex = 1;
            this.lblPathWoW.Text = "label1";
            // 
            // openWoWExe
            // 
            this.openWoWExe.FileName = "openWoWExe";
            this.openWoWExe.Title = "Select wow.exe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textCharacter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textRealm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.textUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(253, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "character";
            // 
            // textCharacter
            // 
            this.textCharacter.Location = new System.Drawing.Point(85, 122);
            this.textCharacter.Name = "textCharacter";
            this.textCharacter.Size = new System.Drawing.Size(169, 27);
            this.textCharacter.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "realm";
            // 
            // textRealm
            // 
            this.textRealm.Location = new System.Drawing.Point(85, 89);
            this.textRealm.Name = "textRealm";
            this.textRealm.Size = new System.Drawing.Size(169, 27);
            this.textRealm.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(85, 56);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(169, 27);
            this.textPassword.TabIndex = 2;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(85, 23);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(169, 27);
            this.textUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "username";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 312);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 29);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnFindPath
            // 
            this.btnFindPath.Location = new System.Drawing.Point(12, 12);
            this.btnFindPath.Name = "btnFindPath";
            this.btnFindPath.Size = new System.Drawing.Size(94, 29);
            this.btnFindPath.TabIndex = 4;
            this.btnFindPath.Text = "Find Path";
            this.btnFindPath.UseVisualStyleBackColor = true;
            this.btnFindPath.Click += new System.EventHandler(this.btnFindPath_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(112, 16);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(105, 20);
            this.labelPath.TabIndex = 5;
            this.labelPath.Text = "path to profile";
            // 
            // groupSettings
            // 
            this.groupSettings.Controls.Add(this.btnActorRemove);
            this.groupSettings.Controls.Add(this.btnActorAdd);
            this.groupSettings.Controls.Add(this.label5);
            this.groupSettings.Controls.Add(this.listActors);
            this.groupSettings.Controls.Add(this.btnClickMe);
            this.groupSettings.Controls.Add(this.lblPathWoW);
            this.groupSettings.Controls.Add(this.groupBox1);
            this.groupSettings.Location = new System.Drawing.Point(12, 47);
            this.groupSettings.Name = "groupSettings";
            this.groupSettings.Size = new System.Drawing.Size(776, 265);
            this.groupSettings.TabIndex = 6;
            this.groupSettings.TabStop = false;
            this.groupSettings.Text = "Settings";
            // 
            // btnActorAdd
            // 
            this.btnActorAdd.Location = new System.Drawing.Point(101, 65);
            this.btnActorAdd.Name = "btnActorAdd";
            this.btnActorAdd.Size = new System.Drawing.Size(26, 29);
            this.btnActorAdd.TabIndex = 5;
            this.btnActorAdd.Text = "+";
            this.btnActorAdd.UseVisualStyleBackColor = true;
            this.btnActorAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Actor";
            // 
            // listActors
            // 
            this.listActors.FormattingEnabled = true;
            this.listActors.ItemHeight = 20;
            this.listActors.Location = new System.Drawing.Point(6, 102);
            this.listActors.Name = "listActors";
            this.listActors.Size = new System.Drawing.Size(150, 144);
            this.listActors.TabIndex = 3;
            this.listActors.SelectedIndexChanged += new System.EventHandler(this.listActors_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "saveJSON";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openConfig
            // 
            this.openConfig.FileName = "openConfig";
            // 
            // btnActorRemove
            // 
            this.btnActorRemove.Location = new System.Drawing.Point(130, 66);
            this.btnActorRemove.Name = "btnActorRemove";
            this.btnActorRemove.Size = new System.Drawing.Size(26, 29);
            this.btnActorRemove.TabIndex = 6;
            this.btnActorRemove.Text = "-";
            this.btnActorRemove.UseVisualStyleBackColor = true;
            this.btnActorRemove.Click += new System.EventHandler(this.btnActorRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupSettings);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.btnFindPath);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupSettings.ResumeLayout(false);
            this.groupSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClickMe;
        private Label lblPathWoW;
        private OpenFileDialog openWoWExe;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textRealm;
        private Label label2;
        private TextBox textPassword;
        private TextBox textUsername;
        private Label label1;
        private Label label4;
        private TextBox textCharacter;
        private Button btnConnect;
        private Button btnFindPath;
        private Label labelPath;
        private GroupBox groupSettings;
        private Button btnActorAdd;
        private Label label5;
        private ListBox listActors;
        private Button button2;
        private OpenFileDialog openConfig;
        private Button btnActorRemove;
    }
}