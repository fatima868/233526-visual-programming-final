using System.Collections.Generic;
using System.Windows;

namespace QuizApp
{
    public partial class MainWindow : Window
    {
        // Sample list of quiz questions
        public List<QuizQuestion> QuizQuestions { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Initialize the quiz questions
            QuizQuestions = new List<QuizQuestion>
            {
                new QuizQuestion { QuestionText = "What is the capital of France?", Options = "A) Berlin, B) Madrid, C) Paris, D) Rome", CorrectAnswer = "C) Paris", Marks = 5, TimeLimit = 30 },
                new QuizQuestion { QuestionText = "Who developed the theory of relativity?", Options = "A) Isaac Newton, B) Albert Einstein, C) Galileo Galilei, D) Nikola Tesla", CorrectAnswer = "B) Albert Einstein", Marks = 5, TimeLimit = 30 },
                new QuizQuestion { QuestionText = "What is the chemical symbol for water?", Options = "A) H2O, B) O2, C) CO2, D) H2", CorrectAnswer = "A) H2O", Marks = 5, TimeLimit = 30 }
            };

            // Bind the list to the DataGrid
            QuizDataGrid.ItemsSource = QuizQuestions;
        }

        // Add button click handler
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // For simplicity, add a new question (you can implement a dialog to get user input)
            QuizQuestions.Add(new QuizQuestion { QuestionText = "What is 2 + 2?", Options = "A) 3, B) 4, C) 5, D) 6", CorrectAnswer = "B) 4", Marks = 5, TimeLimit = 30 });
            QuizDataGrid.Items.Refresh();
        }

        // Edit button click handler (for demonstration, it will modify the first question)
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (QuizQuestions.Count > 0)
            {
                QuizQuestions[0].QuestionText = "What is 3 + 3?";
                QuizQuestions[0].CorrectAnswer = "B) 6";
                QuizDataGrid.Items.Refresh();
            }
        }

        // Delete button click handler (for demonstration, it will remove the first question)
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (QuizQuestions.Count > 0)
            {
                QuizQuestions.RemoveAt(0);
                QuizDataGrid.Items.Refresh();
            }
        }
    }

    // Define a class for the quiz question
    public class QuizQuestion
    {
        public string QuestionText { get; set; }
        public string Options { get; set; }
        public string CorrectAnswer { get; set; }
        public int Marks { get; set; }
        public int TimeLimit { get; set; }
    }
}
