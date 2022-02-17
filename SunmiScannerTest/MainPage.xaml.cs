using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Timers;
using Xamarin.Forms;

namespace SunmiScannerTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            KeyPressed += CustomPage_KeyPressed;

        }

        public event EventHandler<KeyEventArgs> KeyPressed;

        public void SendKeyPressed(object sender, KeyEventArgs e)
        {
            KeyPressed?.Invoke(sender, e);
        }

        private void CustomPage_KeyPressed(object sender, KeyEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Key pressed: " + e.Key);
        }
    }

    public class KeyEventArgs : EventArgs
    {
        public string Key { get; set; }
    }
}

