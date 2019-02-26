using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1 ()
        {
            InitializeComponent();
        }

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            DateTime d = datePicker.Date;
            DisplayAlert("date", d.ToString(), "ok");
        }
    }
}