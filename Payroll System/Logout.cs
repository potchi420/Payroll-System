using Payroll_System;

public static class Logout
{
    public static void Execute(Form currentForm)
    {
        Connector.SessionData.Clear();

        Login login = new Login();
        login.Show();
        currentForm.Hide();
    }
}