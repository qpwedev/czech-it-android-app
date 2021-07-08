using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CzechIt {
    public partial class Stats : ContentPage {
        public Stats() {
            InitializeComponent();
            if (QuestionsClass.totalRight == 0) winrate.Text = $"Winrate: I don't know yet :)";
            else winrate.Text = $"Winrate: {(1 - (QuestionsClass.totalErrors / (QuestionsClass.totalRight))) * 100}%";
            score.Text = $"Score: {QuestionsClass.score}";
            questionstotal.Text = $"Total questions: {QuestionsClass.totalRight+QuestionsClass.totalSkips}";
            errorstotal.Text = $"Mistakes: {QuestionsClass.totalErrors}";
            skippedtotal.Text = $"Skipped: {QuestionsClass.totalSkips}";
        }
    }
}
