namespace VSP_184knr_MyProject
{
    partial class LoginAndRegisterForm
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
            button_GoToLogin = new Button();
            button_GoToRegister = new Button();
            panel_LogIn = new Panel();
            button_LogIn = new Button();
            textBox_PasswordLogIn = new TextBox();
            label_PasswordLogIn = new Label();
            textBox_UsernameLogIn = new TextBox();
            label_UsernameLogIn = new Label();
            panel_Register = new Panel();
            textBox_Email = new TextBox();
            label_Email = new Label();
            textBox_Password = new TextBox();
            label_PasswordRegister = new Label();
            textBox_LastName = new TextBox();
            label_LastName = new Label();
            button_Register = new Button();
            textBox_Username = new TextBox();
            label_UsernameRegister = new Label();
            textBox_FirstName = new TextBox();
            label_FirstName = new Label();
            pictureBox_Close = new PictureBox();
            panel_register_bar = new Panel();
            panel_login_bar = new Panel();
            panel_LogIn.SuspendLayout();
            panel_Register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Close).BeginInit();
            SuspendLayout();
            // 
            // button_GoToLogin
            // 
            button_GoToLogin.Cursor = Cursors.Hand;
            button_GoToLogin.FlatAppearance.BorderColor = Color.FromArgb(49, 46, 46);
            button_GoToLogin.FlatAppearance.BorderSize = 0;
            button_GoToLogin.FlatStyle = FlatStyle.Flat;
            button_GoToLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button_GoToLogin.ForeColor = Color.White;
            button_GoToLogin.Location = new Point(0, 31);
            button_GoToLogin.Name = "button_GoToLogin";
            button_GoToLogin.Size = new Size(298, 128);
            button_GoToLogin.TabIndex = 0;
            button_GoToLogin.Text = "Login";
            button_GoToLogin.UseVisualStyleBackColor = true;
            button_GoToLogin.Click += Button_GoToLogin_Click;
            // 
            // button_GoToRegister
            // 
            button_GoToRegister.BackColor = Color.Black;
            button_GoToRegister.Cursor = Cursors.Hand;
            button_GoToRegister.FlatAppearance.BorderColor = Color.FromArgb(49, 46, 46);
            button_GoToRegister.FlatAppearance.BorderSize = 0;
            button_GoToRegister.FlatStyle = FlatStyle.Flat;
            button_GoToRegister.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button_GoToRegister.ForeColor = Color.White;
            button_GoToRegister.Location = new Point(317, 32);
            button_GoToRegister.Name = "button_GoToRegister";
            button_GoToRegister.Size = new Size(298, 127);
            button_GoToRegister.TabIndex = 2;
            button_GoToRegister.Text = "Register";
            button_GoToRegister.UseVisualStyleBackColor = false;
            button_GoToRegister.Click += Button_GoToRegister_Click;
            // 
            // panel_LogIn
            // 
            panel_LogIn.BackColor = Color.FromArgb(49, 46, 46);
            panel_LogIn.Controls.Add(button_LogIn);
            panel_LogIn.Controls.Add(textBox_PasswordLogIn);
            panel_LogIn.Controls.Add(label_PasswordLogIn);
            panel_LogIn.Controls.Add(textBox_UsernameLogIn);
            panel_LogIn.Controls.Add(label_UsernameLogIn);
            panel_LogIn.Location = new Point(8, 162);
            panel_LogIn.Name = "panel_LogIn";
            panel_LogIn.Size = new Size(603, 496);
            panel_LogIn.TabIndex = 3;
            // 
            // button_LogIn
            // 
            button_LogIn.BackColor = Color.FromArgb(248, 148, 6);
            button_LogIn.Cursor = Cursors.Hand;
            button_LogIn.FlatStyle = FlatStyle.Flat;
            button_LogIn.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button_LogIn.ForeColor = Color.White;
            button_LogIn.Location = new Point(57, 290);
            button_LogIn.Name = "button_LogIn";
            button_LogIn.Size = new Size(482, 76);
            button_LogIn.TabIndex = 4;
            button_LogIn.Text = "Login";
            button_LogIn.UseVisualStyleBackColor = false;
            button_LogIn.Click += Button_LogIn_Click;
            // 
            // textBox_PasswordLogIn
            // 
            textBox_PasswordLogIn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_PasswordLogIn.Location = new Point(193, 193);
            textBox_PasswordLogIn.Name = "textBox_PasswordLogIn";
            textBox_PasswordLogIn.Size = new Size(346, 35);
            textBox_PasswordLogIn.TabIndex = 3;
            textBox_PasswordLogIn.UseSystemPasswordChar = true;
            textBox_PasswordLogIn.TextChanged += TextBox_TextChanged;
            textBox_PasswordLogIn.Validating += TextBoxPassword_Validating;
            // 
            // label_PasswordLogIn
            // 
            label_PasswordLogIn.AutoSize = true;
            label_PasswordLogIn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_PasswordLogIn.ForeColor = Color.White;
            label_PasswordLogIn.Location = new Point(57, 199);
            label_PasswordLogIn.Name = "label_PasswordLogIn";
            label_PasswordLogIn.Size = new Size(126, 29);
            label_PasswordLogIn.TabIndex = 2;
            label_PasswordLogIn.Text = "Password:";
            // 
            // textBox_UsernameLogIn
            // 
            textBox_UsernameLogIn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_UsernameLogIn.Location = new Point(193, 113);
            textBox_UsernameLogIn.Name = "textBox_UsernameLogIn";
            textBox_UsernameLogIn.Size = new Size(346, 35);
            textBox_UsernameLogIn.TabIndex = 1;
            textBox_UsernameLogIn.TextChanged += TextBox_TextChanged;
            textBox_UsernameLogIn.Validating += TextBoxUsername_Validating;
            // 
            // label_UsernameLogIn
            // 
            label_UsernameLogIn.AutoSize = true;
            label_UsernameLogIn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_UsernameLogIn.ForeColor = Color.White;
            label_UsernameLogIn.Location = new Point(57, 116);
            label_UsernameLogIn.Name = "label_UsernameLogIn";
            label_UsernameLogIn.Size = new Size(130, 29);
            label_UsernameLogIn.TabIndex = 0;
            label_UsernameLogIn.Text = "Username:";
            // 
            // panel_Register
            // 
            panel_Register.BackColor = Color.FromArgb(49, 46, 46);
            panel_Register.Controls.Add(textBox_Email);
            panel_Register.Controls.Add(label_Email);
            panel_Register.Controls.Add(textBox_Password);
            panel_Register.Controls.Add(label_PasswordRegister);
            panel_Register.Controls.Add(textBox_LastName);
            panel_Register.Controls.Add(label_LastName);
            panel_Register.Controls.Add(button_Register);
            panel_Register.Controls.Add(textBox_Username);
            panel_Register.Controls.Add(label_UsernameRegister);
            panel_Register.Controls.Add(textBox_FirstName);
            panel_Register.Controls.Add(label_FirstName);
            panel_Register.Location = new Point(5, 165);
            panel_Register.Name = "panel_Register";
            panel_Register.Size = new Size(603, 496);
            panel_Register.TabIndex = 5;
            // 
            // textBox_Email
            // 
            textBox_Email.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Email.Location = new Point(193, 208);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(346, 35);
            textBox_Email.TabIndex = 10;
            textBox_Email.TextChanged += TextBox_TextChangedRegister;
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Email.ForeColor = Color.White;
            label_Email.Location = new Point(50, 211);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(80, 29);
            label_Email.TabIndex = 9;
            label_Email.Text = "Email:";
            // 
            // textBox_Password
            // 
            textBox_Password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Password.Location = new Point(193, 264);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(346, 35);
            textBox_Password.TabIndex = 8;
            textBox_Password.UseSystemPasswordChar = true;
            textBox_Password.TextChanged += TextBox_TextChangedRegister;
            textBox_Password.Validating += TextBoxPassword_Validating;
            // 
            // label_PasswordRegister
            // 
            label_PasswordRegister.AutoSize = true;
            label_PasswordRegister.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_PasswordRegister.ForeColor = Color.White;
            label_PasswordRegister.Location = new Point(54, 267);
            label_PasswordRegister.Name = "label_PasswordRegister";
            label_PasswordRegister.Size = new Size(126, 29);
            label_PasswordRegister.TabIndex = 7;
            label_PasswordRegister.Text = "Password:";
            // 
            // textBox_LastName
            // 
            textBox_LastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_LastName.Location = new Point(193, 96);
            textBox_LastName.Name = "textBox_LastName";
            textBox_LastName.Size = new Size(346, 35);
            textBox_LastName.TabIndex = 6;
            textBox_LastName.TextChanged += TextBox_TextChangedRegister;
            // 
            // label_LastName
            // 
            label_LastName.AutoSize = true;
            label_LastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_LastName.ForeColor = Color.White;
            label_LastName.Location = new Point(50, 99);
            label_LastName.Name = "label_LastName";
            label_LastName.Size = new Size(134, 29);
            label_LastName.TabIndex = 5;
            label_LastName.Text = "Last Name:";
            // 
            // button_Register
            // 
            button_Register.BackColor = Color.FromArgb(52, 152, 219);
            button_Register.Cursor = Cursors.Hand;
            button_Register.FlatStyle = FlatStyle.Flat;
            button_Register.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button_Register.ForeColor = Color.White;
            button_Register.Location = new Point(57, 358);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(482, 76);
            button_Register.TabIndex = 4;
            button_Register.Text = "Register";
            button_Register.UseVisualStyleBackColor = false;
            button_Register.Click += Button_Register_Click;
            // 
            // textBox_Username
            // 
            textBox_Username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Username.Location = new Point(193, 152);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(346, 35);
            textBox_Username.TabIndex = 3;
            textBox_Username.TextChanged += TextBox_TextChangedRegister;
            textBox_Username.Validating += TextBoxUsername_Validating;
            // 
            // label_UsernameRegister
            // 
            label_UsernameRegister.AutoSize = true;
            label_UsernameRegister.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_UsernameRegister.ForeColor = Color.White;
            label_UsernameRegister.Location = new Point(50, 155);
            label_UsernameRegister.Name = "label_UsernameRegister";
            label_UsernameRegister.Size = new Size(130, 29);
            label_UsernameRegister.TabIndex = 2;
            label_UsernameRegister.Text = "Username:";
            // 
            // textBox_FirstName
            // 
            textBox_FirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_FirstName.Location = new Point(193, 40);
            textBox_FirstName.Name = "textBox_FirstName";
            textBox_FirstName.Size = new Size(346, 35);
            textBox_FirstName.TabIndex = 1;
            textBox_FirstName.TextChanged += TextBox_TextChangedRegister;
            // 
            // label_FirstName
            // 
            label_FirstName.AutoSize = true;
            label_FirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_FirstName.ForeColor = Color.White;
            label_FirstName.Location = new Point(50, 43);
            label_FirstName.Name = "label_FirstName";
            label_FirstName.Size = new Size(137, 29);
            label_FirstName.TabIndex = 0;
            label_FirstName.Text = "First Name:";
            // 
            // pictureBox_Close
            // 
            pictureBox_Close.Cursor = Cursors.Hand;
            pictureBox_Close.Image = Properties.Resources.closeTab4;
            pictureBox_Close.Location = new Point(588, 10);
            pictureBox_Close.Name = "pictureBox_Close";
            pictureBox_Close.Size = new Size(16, 16);
            pictureBox_Close.TabIndex = 4;
            pictureBox_Close.TabStop = false;
            pictureBox_Close.Click += PictureBox_Close_Click;
            // 
            // panel_register_bar
            // 
            panel_register_bar.BackColor = Color.FromArgb(49, 46, 46);
            panel_register_bar.Location = new Point(317, 155);
            panel_register_bar.Name = "panel_register_bar";
            panel_register_bar.Size = new Size(298, 4);
            panel_register_bar.TabIndex = 11;
            // 
            // panel_login_bar
            // 
            panel_login_bar.BackColor = Color.Yellow;
            panel_login_bar.Location = new Point(0, 155);
            panel_login_bar.Name = "panel_login_bar";
            panel_login_bar.Size = new Size(298, 4);
            panel_login_bar.TabIndex = 12;
            // 
            // LoginAndRegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 46, 46);
            ClientSize = new Size(620, 670);
            Controls.Add(panel_LogIn);
            Controls.Add(panel_login_bar);
            Controls.Add(panel_register_bar);
            Controls.Add(pictureBox_Close);
            Controls.Add(button_GoToRegister);
            Controls.Add(button_GoToLogin);
            Controls.Add(panel_Register);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(620, 670);
            MinimumSize = new Size(616, 658);
            Name = "LoginAndRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            //Load += LoginAndRegisterForm_Load;
            panel_LogIn.ResumeLayout(false);
            panel_LogIn.PerformLayout();
            panel_Register.ResumeLayout(false);
            panel_Register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Close).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_GoToLogin;
        private Button button_GoToRegister;
        private Panel panel_LogIn;
        private TextBox textBox_UsernameLogIn;
        private Label label_UsernameLogIn;
        private Button button_LogIn;
        private TextBox textBox_PasswordLogIn;
        private Label label_PasswordLogIn;
        private PictureBox pictureBox_Close;
        private Panel panel_Register;
        private Button button_Register;
        private TextBox textBox_Username;
        private Label label_UsernameRegister;
        private TextBox textBox_FirstName;
        private Label label_FirstName;
        private TextBox textBox_Email;
        private Label label_Email;
        private TextBox textBox_Password;
        private Label label_PasswordRegister;
        private TextBox textBox_LastName;
        private Label label_LastName;
        private Panel panel_register_bar;
        private Panel panel_login_bar;
    }
}