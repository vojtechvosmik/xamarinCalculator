using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
        }

        void NumberClicked(object sender, EventArgs args)
        {
            var button = sender as Button;
            var text = button.Text;
            this.Display.Text += text;
        }

        void ResultClicked(object sender, EventArgs args)
        {
            DataTable dt = new DataTable();
            int answer = (int)dt.Compute(this.Display.Text, "");
            this.Display.Text = answer.ToString();
        }

        void DeleteClicked(object sender, EventArgs args)
        {
            this.Display.Text = "";
        }
    }
}
