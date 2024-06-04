using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace VSP_184knr_MyProject
{
    public partial class WorkoutSignUpForm : Form
    {
        private readonly WorkoutDatabaseOperations databaseOperations;
        private readonly UserOperations userOperations;

        private string selectedDayAndHour;
        private string username;

        public WorkoutSignUpForm(string username)
        {
            InitializeComponent();
            buttonSignUpForAWorkout.Enabled = false;
            this.username = username;

            //Създаваме инстанции на двата класа: WorkoutDatabaseOperations и UserOperations.
            databaseOperations = new WorkoutDatabaseOperations();
            userOperations = new UserOperations();

            foreach (Control control in groupBoxWorkoutType.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.CheckedChanged += RadioButtonWorkoutType_CheckedChanged;
                }
            }
        }

        //Метод, който е обработчик на събитието CheckedChanged, което се извиква при промяна в състоянието на някой радио бутон в групата groupBoxWorkoutType.
        private void RadioButtonWorkoutType_CheckedChanged(object sender, EventArgs e)
        {
            //Този ред изчиства всички контроли в groupBoxDayAndTime, като това се извършва преди да се добавят нови конторли.
            groupBoxDayAndTime.Controls.Clear();

            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //Извличаме текста на чекнатия радио бутон и го запазваме в променливата workoutType.
                string workoutType = radioButton.Text; 
                LoadWorkoutSchedule(workoutType);
            }
        }

        // Метод, който зарежда графикът за подадения вид тренировка и динамично създава радио бутони.
        private void LoadWorkoutSchedule(string workoutType)
        {
            //Тук извличаме графика от БД.
            DataTable schedule = databaseOperations.GetWorkoutScheduleFromDatabase(workoutType);

            groupBoxDayAndTime.Controls.Clear();

            //Инициализираме позицията на радио бутоните в groupBoxDayAndTime.
            int initialYPercentage = 6;
            int initialY = (int)(this.Height * initialYPercentage / 100.0);

            int yOffsetPercentage = 6;
            int yOffset = (int)(this.Height * yOffsetPercentage / 100.0);

            //Чрез цикъл се обхожда всеки ред в таблицата с графика за тренировки и създава радио бутон за всеки един такъв.
            foreach (DataRow row in schedule.Rows)
            {
                string day = row["Day_of_Week"].ToString();
                string time = row["Start_Time"].ToString();

                var radioButton = new RadioButton
                {
                    Text = $"{day} at {time}",
                    Tag = $"{day} at {time}",
                    AutoSize = true,
                    Location = new Point(6, initialY), 
                };

                radioButton.CheckedChanged += RadioButtonDayAndTime_CheckedChanged;
                groupBoxDayAndTime.Controls.Add(radioButton);

                initialY += yOffset; 
            }

            //Ако има контроли в groupBoxDayAndTime, фокусът се установява върху първия контрол.
            if (groupBoxDayAndTime.Controls.Count > 0)
            {
                groupBoxDayAndTime.Controls[0].Focus();
                selectedDayAndHour = groupBoxDayAndTime.Controls[0].Tag?.ToString();
                
                //Бутонът за записване зза тренировка се активира.
                buttonSignUpForAWorkout.Enabled = true;
            }
            else
            {
                selectedDayAndHour = null;
                buttonSignUpForAWorkout.Enabled = false;
            }
        }

        //Метод, който отчита промени в състоянието на радио бутоните за дни и часове и активира бутона за записване за тренировка,
        //когато потребителят е избрал конкретен ден и час.
        private void RadioButtonDayAndTime_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                selectedDayAndHour = radioButton.Tag?.ToString();
                buttonSignUpForAWorkout.Enabled = true;
            }
        }

        //Този метод се извиква, когато щракнем върху бутона SignUp и принтира текст в richTextBox.
        private void ButtonSignUpForAWorkout_Click(object sender, EventArgs e)
        {
            //Правим проверка дали е селектиран ден и час.
            if (!string.IsNullOrEmpty(selectedDayAndHour))
            {
                //Чрез извикания метод се връща избрания радио бутон, тоест вида на избраната тренировка.
                string workoutType = GetSelectedRadioButtonText(groupBoxWorkoutType);

                DataTable workoutDetails = databaseOperations.GetWorkoutDetails(workoutType, selectedDayAndHour);
                DataTable trainerDetails = databaseOperations.GetTrainerDetails(workoutType, selectedDayAndHour);

                //Проверка дали успешно са извлечени детайлите за тренировката и треньора.
                if (workoutDetails != null && workoutDetails.Rows.Count > 0 &&
                    trainerDetails != null && trainerDetails.Rows.Count > 0)
                {

                    //Тук извличаме стойностите от получените DataTables.
                    string trainerName = trainerDetails.Rows[0]["Trainer_Name"].ToString();
                    string room = workoutDetails.Rows[0]["Room"].ToString();
                    string price = workoutDetails.Rows[0]["Price"].ToString();

                    string message = $"{userOperations.GetUserName(username)}, you are signed up for {workoutType} on {selectedDayAndHour}. " +
                                     $"The training will be held by {trainerName} in {room}. The price is {price} leva.";

                    //Текстът от горното съобщение се отпечатва в richTextBox_Output.
                    richTextBox_Output.Text = message;

                    //Извиква се методът InsertUserRegistration, с който в БД ще се впише нов запис с регистрацията на потребителя за тренировка.
                    userOperations.InsertUserRegistration(username, workoutType, selectedDayAndHour);
                }
            }
        }

        //Този метод извлича информацията, от избрания от нас, радио бутон в съответната група.
        private string GetSelectedRadioButtonText(GroupBox groupBox)
        {
            //Тук се проверява дали избраният бутон е радио бутон, и дали е чекнат.
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }

            return string.Empty;
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
