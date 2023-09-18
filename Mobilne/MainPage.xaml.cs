namespace mobilnaGruszka;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        string mail1 = mail.Text;
        string check = "@";
       
		if(mail1.Contains(check))
		{
            if (string.IsNullOrEmpty(pass1.Text) || string.IsNullOrEmpty(pass2.Text))
            {
                result1.Text = "Proszę podać hasło.";
            }
            else
            {
                if (pass1.Text == pass2.Text)
                {
                    result1.Text = $"Witaj {mail1}";
                }
                else
                {
                    result1.Text = "Hasła się różnią.";
                }
            }
        }
        else
        {
            result1.Text = "E-mail jest niepoprawny.";
        }
		
	}

    void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
    {
        double value = args.NewValue;
        Convert.ToInt32(value);
        slideValue.Text = String.Format("The Slider value is {0}", value);
    }
}

