namespace Exec2_Message
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			label1.Text = String.Empty;
			label2.Text = String.Empty;
			FormBorderStyle = FormBorderStyle.Fixed3D;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ShowTimeNow();
			ShowTime();
		}
		private void ShowTime()
		{
			DateTime Goal = DateTime.Now;
			if (Goal.Hour >= 0 && Goal.Hour < 12)
				label2.Text = "早安";
			else if (Goal.Hour >= 12 && Goal.Hour < 18)
				label2.Text = "午安";
			else if (Goal.Hour >= 18 && Goal.Hour < 24)
				label2.Text = "晚安";
		}
		private void ShowTimeNow()
		{
			DateTime Goal = DateTime.Now;
			label1.Text = $"{Goal.ToString("yyyy/MM/dd_hh:mm:ss")}";
		}
	}
}