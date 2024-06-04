using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VSP_184knr_MyProject
{
    public partial class LoginAndRegisterForm : Form
    {
        private DatabaseHandler databaseHandler;
        private LoginPanel loginPanel;
        private RegisterPanel registerPanel;
        private DumpFileReader dumpFileReader;

        public LoginAndRegisterForm()
        {
            InitializeComponent();

            //Тук инициализираме обекти, свързани с БД и Login/Register.
            databaseHandler = new DatabaseHandler();
            loginPanel = new LoginPanel(databaseHandler);
            registerPanel = new RegisterPanel(databaseHandler);
            dumpFileReader = new DumpFileReader();

            button_LogIn.Enabled = false;
            button_Register.Enabled = false;

            this.textBox_UsernameLogIn.Tag = false;
            this.textBox_PasswordLogIn.Tag = false;

            this.textBox_FirstName.Tag = false;
            this.textBox_LastName.Tag = false;
            this.textBox_Username.Tag = false;
            this.textBox_Email.Tag = false;
            this.textBox_Password.Tag = false;

            //Тук съответните текстови полета са свързани с различни обработчици на събития.
            this.textBox_UsernameLogIn.Validating += new CancelEventHandler(TextBoxUsername_Validating);
            this.textBox_PasswordLogIn.Validating += new CancelEventHandler(TextBoxPassword_Validating);
            this.textBox_Username.Validating += new CancelEventHandler(TextBoxUsername_Validating);
            this.textBox_Password.Validating += new CancelEventHandler(TextBoxPassword_Validating);

            this.textBox_FirstName.TextChanged += new EventHandler(TextBox_TextChangedRegister);
            this.textBox_LastName.TextChanged += new EventHandler(TextBox_TextChangedRegister);
            this.textBox_Username.TextChanged += new EventHandler(TextBox_TextChangedRegister);
            this.textBox_Email.TextChanged += new EventHandler(TextBox_TextChangedRegister);
            this.textBox_Password.TextChanged += new EventHandler(TextBox_TextChangedRegister);

            dumpFileReader = new DumpFileReader();
        }

        Color selectColor = Color.FromArgb(49, 46, 46);

        //Със следните два метода: Button_GoToLogin_Click и Button_GoToRegister_Click, имплементираме превключването помежду им,
        //като част от интерфейса.
        private void Button_GoToLogin_Click(object sender, EventArgs e)
        {
            panel_LogIn.BringToFront();
            panel_login_bar.BackColor = Color.Yellow;
            panel_register_bar.BackColor = selectColor;
            button_GoToLogin.BackColor = selectColor;
            button_GoToRegister.BackColor = Color.Black;
        }

        private void Button_GoToRegister_Click(object sender, EventArgs e)
        {
            panel_Register.BringToFront();
            panel_register_bar.BackColor = Color.Yellow;
            panel_login_bar.BackColor = selectColor;
            button_GoToRegister.BackColor = selectColor;
            button_GoToLogin.BackColor = Color.Black;
        }

        private void Button_LogIn_Click(object sender, EventArgs e)
        {
            string username = textBox_UsernameLogIn.Text;
            string password = textBox_PasswordLogIn.Text;

            //Проверка за това дали въведените данни са валидни, чрез извикване на метода IsValidLogin.
            if (loginPanel.IsValidLogin(username, password))
            {
                //При успешно влизане в с-мата се изписва съобщение и след което текущата форма се скрива.
                MessageBox.Show("Login successful!");
                this.Hide();

                //След скриването се създава нова форма WorkoutSignUpForm, със зададеното потребителско име.
                WorkoutSignUpForm workoutSignUpForm = new WorkoutSignUpForm(username);
                workoutSignUpForm.ShowDialog();

                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong username and/or password!");
            }
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            //Извличаме информацията, попълнена от потребителя, въведена в текстовите полета.
            string firstName = textBox_FirstName.Text;
            string lastName = textBox_LastName.Text;
            string username = textBox_Username.Text;
            string email = textBox_Email.Text;
            string password = textBox_Password.Text;

            //При опит за регистрация с дадено потр. име и имейл се проверява дали такова/такива вече не съществуват.
            //Ако съществува едно от двете или и двете, се появява съответното съобщение.
            if (registerPanel.IsUsernameTaken(username) && registerPanel.IsEmailTaken(email))
            {
                MessageBox.Show("This username and email are already taken. Please use another ones.");
                return;
            }

            if (registerPanel.IsUsernameTaken(username))
            {
                MessageBox.Show("This username is already taken. Please choose another one.");
                return;
            }

            if (registerPanel.IsEmailTaken(email))
            {
                MessageBox.Show("This email is already registered. Please use another one.");
                return;
            }

            //Тук се извиква методът, който служи за хеширане на паролата.
            string hashPass = HashPassword(password);
            
            //Извиква се метод, който вкарва нов запис, за новорегистриралия се, в БД.
            registerPanel.InsertUserIntoDatabase(firstName, lastName, username, email, hashPass);

            MessageBox.Show("Registration successful!");
        }

        //Метод за хеширане на парола.
        private string HashPassword(string password)
        {
           byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
           return Convert.ToBase64String(passwordBytes);
        }

        //Метод за валидация, при опит за вход в с-мата.
        private void ValidateLogIn()
        {
            //Бутонът се активира само ако всички условия са изпълнени (тоест са true).
            this.button_LogIn.Enabled =
                ((bool)(this.textBox_UsernameLogIn.Tag)
                && (bool)(this.textBox_PasswordLogIn.Tag));
        }

        //Този метод работи на същия принцип както горния.
        private void ValidateRegister()
        {
            this.button_Register.Enabled =
                ((bool)(this.textBox_FirstName.Tag)
                && (bool)(this.textBox_LastName.Tag)
                && (bool)(this.textBox_Username.Tag)
                && (bool)(this.textBox_Email.Tag)
                && (bool)(this.textBox_Password.Tag));
        }

        //Метод, който се извиква при промяна на текста в текстовите полета (този метод е събитие).
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            //Проверява се дали дължината на текста в полето е по-малка от 4, ако е: цветът на полето става в червен цвят
            //и таг св-вото на полето става false.
            if (tb.Text.Length < 4)
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.Tag = true;
                tb.BackColor = SystemColors.Window;
            }

            //Тези два метода се извикват, тъй като чрез тях се проверява валидацията на формите за вход и регистрация.
            ValidateLogIn();
            ValidateRegister();
        }

        //В тези два метода се валидира текста, въведен в текстовите полета, дали е по-малък от 4 символа.
        private void TextBoxPassword_Validating(Object sender, CancelEventArgs e)
        {
            TextLengthValidator((TextBox)sender);
        }

        private void TextBoxUsername_Validating(object sender, CancelEventArgs e)
        {
            TextLengthValidator((TextBox)sender);
        }

        //Валидация на текстовите полета, чрез проверка на дължината на текста в тях. Работи на същия принцип като TextBox_TextChanged.
        private void TextLengthValidator(TextBox tb)
        {
            if (tb.Text.Length < 4)
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.Tag = true;
                tb.BackColor = SystemColors.Window;
            }

            ValidateLogIn();
            ValidateRegister();
        }

        //Метод, който се фокусира върху изисквания формат за имейл. В случая, единственият приеман е gmail.com. 
        private bool IsValidEmailFormat(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }

        private void TextBox_TextChangedRegister(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb == textBox_FirstName || tb == textBox_LastName)
            {
                //Проверка дали първата буква от името и фамилията са с главна буква.
                if (tb.Text.Length == 0 || !char.IsUpper(tb.Text[0]) || tb.Text.Any(char.IsDigit))
                {
                    tb.Tag = false;
                    tb.BackColor = Color.Red;
                }
                else
                {
                    //Правим първата буква главна, а останалите - малки
                    tb.Text = char.ToUpper(tb.Text[0]) + tb.Text.Substring(1).ToLower();

                    tb.Tag = true;
                    tb.BackColor = SystemColors.Window;
                }

                //Цикъл, който обхожда всеки един символ и сверява дали е буква, ако не е: текстовото поле светва в червено.
                foreach (char c in tb.Text)
                {
                    if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я')))
                    {
                        tb.Tag = false;
                        tb.BackColor = Color.Red;
                    }
                }
                ValidateRegister();
            }
            //Проверка за имейл формата, ако не е изскваният формат, полето светва в червено.
            else if (tb == textBox_Email)
            {
                string email = tb.Text;

                if (!IsValidEmailFormat(email))
                {
                    tb.Tag = false;
                    tb.BackColor = Color.Red;
                }
                else
                {
                    tb.Tag = true;
                    tb.BackColor = SystemColors.Window;
                }

                ValidateRegister();
            }
            //Проверка за дължината на потр. име и парола, приема го/ги само ако е/са 4 или повече от 4 знака.
            else if (tb == textBox_Username || tb == textBox_Password)
            {
                if (tb.Text.Length < 4)
                {
                    tb.Tag = false;
                    tb.BackColor = Color.Red;
                }
                else
                {
                    tb.Tag = true;
                    tb.BackColor = SystemColors.Window;
                }

                ValidateRegister();
            }
        }

        private void PictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}