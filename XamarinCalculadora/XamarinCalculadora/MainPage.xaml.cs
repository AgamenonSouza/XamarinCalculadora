using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinCalculadora
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int currentState = 1;
        string mathOperator;
        double fistNumber, secondNumber;



        public MainPage()
        {
            InitializeComponent();
            on_Clicked(new object(), new EventArgs());

        }

        private void on_Clicked(object sender, EventArgs e)
        {
            fistNumber = 0;
            secondNumber = 0;
            currentState = 1;
            this.resultText.Text = "0";

        }

        void onSelectedNumber(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if (this.resultText.Text == "0" || currentState < 0)
            {
                this.resultText.Text = "";
                if (currentState < 0)
                    currentState *= -1;
            }
            this.resultText.Text += pressed;

            double number;
            if(double.TryParse(this.resultText.Text,out number))
            {
                this.resultText.Text = number.ToString("N0");
                if (currentState == 1)
                {
                    fistNumber = number;
                }
                else
                {
                    secondNumber = number;
                }
            }

        }
    }
}
