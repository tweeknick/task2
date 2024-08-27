using System;


namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkPal_Click(object sender, EventArgs e)
        {
            try
            {
                string fromUser = txtBox.Text;
                PalindromeChecker palindromeChecker = new PalindromeChecker(fromUser);

                if (palindromeChecker.IsPalindrome())
                {
                    label.Text = $"\"{fromUser}\" є паліндромом.";
                }
                else
                {
                    label.Text = $"\"{fromUser}\" не є паліндромом.";
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

