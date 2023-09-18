using System.Configuration;

namespace LightDarkApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			ChangeTheme("UIMode");
		}

		private void ChangeTheme(string key)
		{
			Color one = Color.FromArgb(47, 54, 64);
			Color two = Color.FromArgb(245, 246, 250);

			try
			{
				var uiMode = ConfigurationManager.AppSettings[key];
				if (uiMode == "light")
				{
					button1.Text = "Enable Dark theme";
					label1.Text = "Light theme is enabled now";
					this.ForeColor = one;
					this.BackColor = two;
					ConfigurationManager.AppSettings[key] = "dark";
				}
				else
				{
					button1.Text = "Enable Light theme";
					label1.Text = "Dark theme is enabled now";
					this.ForeColor = two;
					this.BackColor = one;
					ConfigurationManager.AppSettings[key] = "light";
				}
			}
			catch (Exception ex)
			{

				throw (new Exception("Error in InitializeUI", ex));
			}
		}


		private void button1_Click(object sender, EventArgs e)
		{
			ChangeTheme("UIMode");
		}

	}
}