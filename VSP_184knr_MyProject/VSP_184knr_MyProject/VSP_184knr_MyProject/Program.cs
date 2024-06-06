namespace VSP_184knr_MyProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginAndRegisterForm());
        }
    }
}