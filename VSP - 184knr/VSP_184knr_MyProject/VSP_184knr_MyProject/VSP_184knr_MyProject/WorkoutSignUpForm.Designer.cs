namespace VSP_184knr_MyProject
{
    partial class WorkoutSignUpForm
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
            label_SignUpForAWorkout = new Label();
            panel1 = new Panel();
            groupBoxWorkoutType = new GroupBox();
            radioButton_Pilates = new RadioButton();
            radioButton_Dance = new RadioButton();
            radioButton_HIIT = new RadioButton();
            radioButton_Yoga = new RadioButton();
            radioButton_Strength = new RadioButton();
            radioButton_Cardio = new RadioButton();
            richTextBox_Output = new RichTextBox();
            buttonSignUpForAWorkout = new Button();
            pictureBox1 = new PictureBox();
            groupBoxDayAndTime = new GroupBox();
            groupBoxWorkoutType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_SignUpForAWorkout
            // 
            label_SignUpForAWorkout.AutoSize = true;
            label_SignUpForAWorkout.BackColor = Color.FromArgb(49, 46, 46);
            label_SignUpForAWorkout.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label_SignUpForAWorkout.ForeColor = Color.White;
            label_SignUpForAWorkout.Location = new Point(175, 9);
            label_SignUpForAWorkout.Name = "label_SignUpForAWorkout";
            label_SignUpForAWorkout.Size = new Size(301, 32);
            label_SignUpForAWorkout.TabIndex = 0;
            label_SignUpForAWorkout.Text = "Sign up for a workout";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Location = new Point(175, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 4);
            panel1.TabIndex = 1;
            // 
            // groupBoxWorkoutType
            // 
            groupBoxWorkoutType.Controls.Add(radioButton_Pilates);
            groupBoxWorkoutType.Controls.Add(radioButton_Dance);
            groupBoxWorkoutType.Controls.Add(radioButton_HIIT);
            groupBoxWorkoutType.Controls.Add(radioButton_Yoga);
            groupBoxWorkoutType.Controls.Add(radioButton_Strength);
            groupBoxWorkoutType.Controls.Add(radioButton_Cardio);
            groupBoxWorkoutType.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxWorkoutType.ForeColor = Color.FromArgb(248, 148, 6);
            groupBoxWorkoutType.Location = new Point(12, 111);
            groupBoxWorkoutType.Name = "groupBoxWorkoutType";
            groupBoxWorkoutType.Size = new Size(213, 280);
            groupBoxWorkoutType.TabIndex = 2;
            groupBoxWorkoutType.TabStop = false;
            groupBoxWorkoutType.Text = "Workout type";
            // 
            // radioButton_Pilates
            // 
            radioButton_Pilates.AutoSize = true;
            radioButton_Pilates.Location = new Point(6, 222);
            radioButton_Pilates.Name = "radioButton_Pilates";
            radioButton_Pilates.Size = new Size(103, 30);
            radioButton_Pilates.TabIndex = 12;
            radioButton_Pilates.TabStop = true;
            radioButton_Pilates.Text = "Pilates";
            radioButton_Pilates.UseVisualStyleBackColor = true;
            radioButton_Pilates.CheckedChanged += RadioButtonWorkoutType_CheckedChanged;
            // 
            // radioButton_Dance
            // 
            radioButton_Dance.AutoSize = true;
            radioButton_Dance.Location = new Point(6, 186);
            radioButton_Dance.Name = "radioButton_Dance";
            radioButton_Dance.Size = new Size(100, 30);
            radioButton_Dance.TabIndex = 11;
            radioButton_Dance.TabStop = true;
            radioButton_Dance.Text = "Dance";
            radioButton_Dance.UseVisualStyleBackColor = true;
            radioButton_Dance.CheckedChanged += RadioButtonWorkoutType_CheckedChanged;
            // 
            // radioButton_HIIT
            // 
            radioButton_HIIT.AutoSize = true;
            radioButton_HIIT.Location = new Point(6, 150);
            radioButton_HIIT.Name = "radioButton_HIIT";
            radioButton_HIIT.Size = new Size(77, 30);
            radioButton_HIIT.TabIndex = 10;
            radioButton_HIIT.TabStop = true;
            radioButton_HIIT.Text = "HIIT";
            radioButton_HIIT.UseVisualStyleBackColor = true;
            radioButton_HIIT.CheckedChanged += RadioButtonWorkoutType_CheckedChanged;
            // 
            // radioButton_Yoga
            // 
            radioButton_Yoga.AutoSize = true;
            radioButton_Yoga.Location = new Point(6, 114);
            radioButton_Yoga.Name = "radioButton_Yoga";
            radioButton_Yoga.Size = new Size(89, 30);
            radioButton_Yoga.TabIndex = 9;
            radioButton_Yoga.TabStop = true;
            radioButton_Yoga.Text = "Yoga";
            radioButton_Yoga.UseVisualStyleBackColor = true;
            radioButton_Yoga.CheckedChanged += RadioButtonWorkoutType_CheckedChanged;
            // 
            // radioButton_Strength
            // 
            radioButton_Strength.AutoSize = true;
            radioButton_Strength.Location = new Point(6, 78);
            radioButton_Strength.Name = "radioButton_Strength";
            radioButton_Strength.Size = new Size(119, 30);
            radioButton_Strength.TabIndex = 8;
            radioButton_Strength.TabStop = true;
            radioButton_Strength.Text = "Strength";
            radioButton_Strength.UseVisualStyleBackColor = true;
            radioButton_Strength.CheckedChanged += RadioButtonWorkoutType_CheckedChanged;
            // 
            // radioButton_Cardio
            // 
            radioButton_Cardio.AutoSize = true;
            radioButton_Cardio.Location = new Point(6, 42);
            radioButton_Cardio.Name = "radioButton_Cardio";
            radioButton_Cardio.Size = new Size(101, 30);
            radioButton_Cardio.TabIndex = 7;
            radioButton_Cardio.TabStop = true;
            radioButton_Cardio.Text = "Cardio";
            radioButton_Cardio.UseVisualStyleBackColor = true;
            radioButton_Cardio.CheckedChanged += RadioButtonWorkoutType_CheckedChanged;
            // 
            // richTextBox_Output
            // 
            richTextBox_Output.BackColor = SystemColors.Control;
            richTextBox_Output.Dock = DockStyle.Bottom;
            richTextBox_Output.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox_Output.Location = new Point(0, 433);
            richTextBox_Output.Name = "richTextBox_Output";
            richTextBox_Output.ReadOnly = true;
            richTextBox_Output.Size = new Size(671, 242);
            richTextBox_Output.TabIndex = 4;
            richTextBox_Output.Text = "";
            // 
            // buttonSignUpForAWorkout
            // 
            buttonSignUpForAWorkout.BackColor = Color.FromArgb(40, 40, 40);
            buttonSignUpForAWorkout.Cursor = Cursors.Hand;
            buttonSignUpForAWorkout.FlatAppearance.BorderColor = Color.Yellow;
            buttonSignUpForAWorkout.FlatStyle = FlatStyle.Flat;
            buttonSignUpForAWorkout.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSignUpForAWorkout.ForeColor = Color.White;
            buttonSignUpForAWorkout.Location = new Point(547, 71);
            buttonSignUpForAWorkout.Name = "buttonSignUpForAWorkout";
            buttonSignUpForAWorkout.Size = new Size(112, 41);
            buttonSignUpForAWorkout.TabIndex = 5;
            buttonSignUpForAWorkout.Text = "Sign up";
            buttonSignUpForAWorkout.UseVisualStyleBackColor = false;
            buttonSignUpForAWorkout.Click += ButtonSignUpForAWorkout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.closeTab5;
            pictureBox1.Location = new Point(643, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 16);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBoxClose_Click;
            // 
            // groupBoxDayAndTime
            // 
            groupBoxDayAndTime.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxDayAndTime.ForeColor = Color.FromArgb(52, 152, 219);
            groupBoxDayAndTime.Location = new Point(258, 111);
            groupBoxDayAndTime.Name = "groupBoxDayAndTime";
            groupBoxDayAndTime.Size = new Size(283, 280);
            groupBoxDayAndTime.TabIndex = 7;
            groupBoxDayAndTime.TabStop = false;
            groupBoxDayAndTime.Text = "Day and time";
            // 
            // WorkoutSignUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 46, 46);
            ClientSize = new Size(671, 675);
            Controls.Add(groupBoxDayAndTime);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSignUpForAWorkout);
            Controls.Add(richTextBox_Output);
            Controls.Add(groupBoxWorkoutType);
            Controls.Add(panel1);
            Controls.Add(label_SignUpForAWorkout);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(671, 675);
            MinimumSize = new Size(671, 675);
            Name = "WorkoutSignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkoutSignUpForm";
            groupBoxWorkoutType.ResumeLayout(false);
            groupBoxWorkoutType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_SignUpForAWorkout;
        private Panel panel1;
        internal GroupBox groupBoxWorkoutType;
        private RichTextBox richTextBox_Output;
        private Button buttonSignUpForAWorkout;
        private PictureBox pictureBox1;
        private RadioButton radioButton_Pilates;
        private RadioButton radioButton_Dance;
        private RadioButton radioButton_HIIT;
        private RadioButton radioButton_Yoga;
        private RadioButton radioButton_Strength;
        private RadioButton radioButton_Cardio;
        internal GroupBox groupBoxDayAndTime;
    }
}