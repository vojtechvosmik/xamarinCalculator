using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace calc.iOS
{
    public class Application
    {

        static void Main(string[] args)
        {
            UIApplication.Main(args, null, "AppDelegate");
            setupViews();
        }

        private static void setupViews()
        {
            
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            var button = sender as Button;
            var text = button.Text;
            Console.WriteLine(text);
        }
    }
}
