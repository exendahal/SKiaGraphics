using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SKiaTest
{
    public partial class MainPage : ContentPage
    {
        public ICommand TapCommand { get; set; }
        public MainPage()
        {
            BindingContext = this;
            InitializeComponent();
            List<GeneralModel> data = new List<GeneralModel>();
            data.Add(new GeneralModel() { Title = "Kundali", Description = "Click here see kundali chart", TargetType = typeof(Kundali) });
            data.Add(new GeneralModel() { Title = "Basic Lines", Description = "Click here view basic lines", TargetType = typeof(Kundali) });
            data.Add(new GeneralModel() { Title = "Graphs", Description = "Click here to view baisic graphs", TargetType = typeof(Kundali) });
            data.Add(new GeneralModel() { Title = "Other", Description = "Click here to view other graphics", TargetType = typeof(Kundali) });

            list.ItemsSource = data;

            TapCommand = new Command<GeneralModel>(async items =>
            {
               
                await Navigation.PushAsync((Page)Activator.CreateInstance(items.TargetType));
               


            });
        }

       
    }
}
