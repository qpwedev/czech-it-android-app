using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CzechIt {
    public partial class TaskOne : ContentPage {
        string rightAnswer;

        public TaskOne() {
            InitializeComponent();
            DisplayQuestion(RequestQuestion());
        }

        public static string[] RequestQuestion() {
            string[] lines;
            string[] splitedLine = new string[7];

            lines = QuestionsClass.Text.Split('\n');


            int rand_num = new Random().Next(1, 39);
            foreach (string line in lines) {
                splitedLine = line.Split(';');
                if (splitedLine[0] == rand_num.ToString()) {
                    return splitedLine;
                }
            }
            return splitedLine;
        }

        public void DisplayQuestion(string[] question) {
            rightAnswer = question[3];
            questionXaml.Text = question[2];

            string[] answers = { question[3], question[4], question[5], question[6] };

            for (int i = 0; i < answers.Length - 1; i++) {
                int j = new Random().Next(i, answers.Length);
                var temp = answers[i];
                answers[i] = answers[j];
                answers[j] = temp;
            }

            first.Text = answers[0];
            second.Text = answers[1];
            third.Text = answers[2];
            fourth.Text = answers[3];
            scoreXaml.Text = $"Score: {QuestionsClass.score}";

        }


        async void FirstClicked(object sender, EventArgs e) {
            if (rightAnswer == first.Text) {
                ++QuestionsClass.totalRight;
                DisplayQuestion(RequestQuestion());
                scoreXaml.Text = $"Score: {++QuestionsClass.score}";
            }
            else {
                QuestionsClass.totalErrors++;
                if (QuestionsClass.score > 0) {
                    await DisplayAlert("Wrong answer", "Score is reduced by 1", "I will try again :)))");
                    scoreXaml.Text = $"Score: {--QuestionsClass.score}";
                }
                else {
                    scoreXaml.Text = $"Score: {QuestionsClass.score}";
                    await DisplayAlert("Wrong answer", "Score is 0", "I will try again :)))");
                }
            }

        }

        async void SecondClicked(object sender, EventArgs e) {
            if (rightAnswer == second.Text) {
                ++QuestionsClass.totalRight;
                DisplayQuestion(RequestQuestion());
                scoreXaml.Text = $"Score: {++QuestionsClass.score}";
            }
            else {
                QuestionsClass.totalErrors++;
                if (QuestionsClass.score > 0) {
                    await DisplayAlert("Wrong answer", "Score is reduced by 1", "I will try again :)))");
                    scoreXaml.Text = $"Score: {--QuestionsClass.score}";
                }
                else { scoreXaml.Text = $"Score: {QuestionsClass.score}";
                    await DisplayAlert("Wrong answer", "Score is 0", "I will try again :)))");
                }
            }
        }

        async void ThirdClicked(object sender, EventArgs e) {
            if (rightAnswer == third.Text) {
                ++QuestionsClass.totalRight;
                DisplayQuestion(RequestQuestion());
                scoreXaml.Text = $"Score: {++QuestionsClass.score}";
            }
            else {
                QuestionsClass.totalErrors++;
                if (QuestionsClass.score > 0) {
                    await DisplayAlert("Wrong answer", "Score is reduced by 1", "I will try again :)))");
                    scoreXaml.Text = $"Score: {--QuestionsClass.score}";
                }
                else { scoreXaml.Text = $"Score: {QuestionsClass.score}";
                    await DisplayAlert("Wrong answer", "Score is 0", "I will try again :)))");
                }
            }
        }

        async void FouthClicked(object sender, EventArgs e) {
            if (rightAnswer == fourth.Text) {
                ++QuestionsClass.totalRight;
                DisplayQuestion(RequestQuestion());
                scoreXaml.Text = $"Score: {++QuestionsClass.score}";
            }
            else {
                QuestionsClass.totalErrors++;
                if (QuestionsClass.score > 0) {
                    await DisplayAlert("Wrong answer", "Score is reduced by 1", "I will try again :)))");
                    scoreXaml.Text = $"Score: {--QuestionsClass.score}";
                }
                else { scoreXaml.Text = $"Score: {QuestionsClass.score}";
                    await DisplayAlert("Wrong answer", "Score is 0", "I will try again :)))");
                }
            }
        }

        async void ResetClicked(object sender, EventArgs e) {
            await DisplayAlert("Restart was successful", "Score is reset to zero", "Ok");
            QuestionsClass.score = 0;
            scoreXaml.Text = $"Score: {QuestionsClass.score}";
        }

        void SkipClicked(object sender, EventArgs e) {
            QuestionsClass.totalSkips++;
            DisplayQuestion(RequestQuestion());
        }

        async void RightAClicked(object sender, EventArgs e) {
            QuestionsClass.totalSkips++;
            await DisplayAlert($"Right answer is {rightAnswer}", "Please, try it again by yourself in the future :))", "Ok");
            DisplayQuestion(RequestQuestion());
        }
    }
}
