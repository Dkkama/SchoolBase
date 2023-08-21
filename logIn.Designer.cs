namespace SchoolBase
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
            LogIn = new GroupBox();
            wrongUser = new Label();
            panelMove = new Panel();
            linkLabelForgotten = new LinkLabel();
            labelCookies = new Label();
            checkBoxRemember = new CheckBox();
            buttonLogIn = new Button();
            textBoxPassword = new TextBox();
            textBoxName = new TextBox();
            labelPassword = new Label();
            labelName = new Label();
            LogIn.SuspendLayout();
            panelMove.SuspendLayout();
            SuspendLayout();
            // 
            // LogIn
            // 
            LogIn.Controls.Add(wrongUser);
            LogIn.Controls.Add(panelMove);
            LogIn.Controls.Add(textBoxPassword);
            LogIn.Controls.Add(textBoxName);
            LogIn.Controls.Add(labelPassword);
            LogIn.Controls.Add(labelName);
            LogIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogIn.Location = new Point(687, 377);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(974, 545);
            LogIn.TabIndex = 0;
            LogIn.TabStop = false;
            // 
            // wrongUser
            // 
            wrongUser.AutoSize = true;
            wrongUser.ForeColor = Color.Brown;
            wrongUser.Location = new Point(247, 63);
            wrongUser.Name = "wrongUser";
            wrongUser.Size = new Size(532, 32);
            wrongUser.TabIndex = 6;
            wrongUser.Text = "Wrong username or password, please try again :(";
            wrongUser.Visible = false;
            // 
            // panelMove
            // 
            panelMove.Controls.Add(linkLabelForgotten);
            panelMove.Controls.Add(labelCookies);
            panelMove.Controls.Add(checkBoxRemember);
            panelMove.Controls.Add(buttonLogIn);
            panelMove.Location = new Point(217, 210);
            panelMove.Name = "panelMove";
            panelMove.Size = new Size(594, 221);
            panelMove.TabIndex = 9;
            // 
            // linkLabelForgotten
            // 
            linkLabelForgotten.ActiveLinkColor = Color.FromArgb(64, 64, 64);
            linkLabelForgotten.AutoSize = true;
            linkLabelForgotten.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelForgotten.LinkColor = Color.DimGray;
            linkLabelForgotten.Location = new Point(92, 141);
            linkLabelForgotten.Name = "linkLabelForgotten";
            linkLabelForgotten.Size = new Size(432, 32);
            linkLabelForgotten.TabIndex = 5;
            linkLabelForgotten.TabStop = true;
            linkLabelForgotten.Text = "Forgotten your username or password?";
            linkLabelForgotten.VisitedLinkColor = Color.DimGray;
            // 
            // labelCookies
            // 
            labelCookies.AutoSize = true;
            labelCookies.Location = new Point(75, 175);
            labelCookies.Name = "labelCookies";
            labelCookies.Size = new Size(458, 32);
            labelCookies.TabIndex = 4;
            labelCookies.Text = "Cookies must be enabled in your browser";
            // 
            // checkBoxRemember
            // 
            checkBoxRemember.AutoSize = true;
            checkBoxRemember.Location = new Point(168, 10);
            checkBoxRemember.Name = "checkBoxRemember";
            checkBoxRemember.Size = new Size(275, 36);
            checkBoxRemember.TabIndex = 1;
            checkBoxRemember.Text = " Remember username";
            checkBoxRemember.UseVisualStyleBackColor = true;
            checkBoxRemember.CheckedChanged += checkBoxRemember_CheckedChanged;
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(218, 61);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(169, 52);
            buttonLogIn.TabIndex = 0;
            buttonLogIn.Text = "Log in";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(477, 175);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(215, 39);
            textBoxPassword.TabIndex = 7;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(477, 122);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(215, 39);
            textBoxName.TabIndex = 6;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(339, 175);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(116, 32);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(339, 125);
            labelName.Name = "labelName";
            labelName.Size = new Size(133, 32);
            labelName.TabIndex = 2;
            labelName.Text = "User name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1711, 1033);
            Controls.Add(LogIn);
            Name = "Form1";
            Text = "Form1";
            LogIn.ResumeLayout(false);
            LogIn.PerformLayout();
            panelMove.ResumeLayout(false);
            panelMove.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox LogIn;
        private TextBox textBoxPassword;
        private TextBox textBoxName;
        private LinkLabel linkLabelForgotten;
        private Label labelCookies;
        private Label labelPassword;
        private Label labelName;
        private CheckBox checkBoxRemember;
        private Button buttonLogIn;
        private Panel panelMove;
        private Label wrongUser;
    }
}
