using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CzechIt {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }
        private async void TaskOneClicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new TaskOne());
        }

        private async void TaskTwoClicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new TaskTwo());
        }

        private async void TaskThreeClicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new TaskThree());
        }

        private async void StatsClicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new Stats());
        }

        private async void AboutClicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new About());
        }
    }
}
