using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp9
{
    public partial class MainWindow : Window
    {
        // List to hold all quiz questions
        private List<QuizQuestion> allQuizQuestions;

        public MainWindow()
        {
            InitializeComponent();
            LoadQuizQuestions();
        }

        // This method loads the quiz questions into the DataGrid
        private void LoadQuizQuestions()
        {
            // Sample quiz questions
            allQuizQuestions = new List<QuizQuestion>
            {
                new QuizQuestion
                {
                    Question = "What is the capital of France?",
                    Options = "A) Paris, B) London, C) Berlin, D) Madrid",
                    CorrectAnswer = "A) Paris",
                    Marks = 5,
                    TimeLimit = 30,
                    Topic = "Geography",
                    Difficulty = "Easy"
                },
                new QuizQuestion
                {
                    Question = "Which is the largest planet in our solar system?",
                    Options = "A) Earth, B) Mars, C) Jupiter, D) Saturn",
                    CorrectAnswer = "C) Jupiter",
                    Marks = 10,
                    TimeLimit = 40,
                    Topic = "Science",
                    Difficulty = "Medium"
                },
                new QuizQuestion
                {
                    Question = "Who was the first president of the United States?",
                    Options = "A) George Washington, B) Abraham Lincoln, C) Thomas Jefferson, D) John Adams",
                    CorrectAnswer = "A) George Washington",
                    Marks = 5,
                    TimeLimit = 30,
                    Topic = "History",
                    Difficulty = "Easy"
                },
                new QuizQuestion
                {
                    Question = "What is the chemical symbol for water?",
                    Options = "A) O2, B) CO2, C) H2O, D) N2",
                    CorrectAnswer = "C) H2O",
                    Marks = 5,
                    TimeLimit = 20,
                    Topic = "Science",
                    Difficulty = "Easy"
                },
                new QuizQuestion
                {
                    Question = "Which country has the most population?",
                    Options = "A) USA, B) India, C) China, D) Russia",
                    CorrectAnswer = "C) China",
                    Marks = 5,
                    TimeLimit = 25,
                    Topic = "Geography",
                    Difficulty = "Medium"
                }
            };

            // Initially load all quiz questions
            QuizDataGrid.ItemsSource = allQuizQuestions;
        }

        // Filter questions based on the selected topic
        private void TopicComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            FilterQuestions();
        }

        // Filter questions based on the selected difficulty level
        private void DifficultyComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            FilterQuestions();
        }

        // Method to filter the quiz questions based on selected topic and difficulty level
        private void FilterQuestions()
        {
            var filteredQuestions = allQuizQuestions.AsEnumerable();

            // Filter by topic
            if (TopicComboBox.SelectedIndex > 0)
            {
                var selectedTopic = ((ComboBoxItem)TopicComboBox.SelectedItem).Content.ToString();
                filteredQuestions = filteredQuestions.Where(q => q.Topic == selectedTopic);
            }

            // Filter by difficulty
            if (DifficultyComboBox.SelectedIndex > 0)
            {
                var selectedDifficulty = ((ComboBoxItem)DifficultyComboBox.SelectedItem).Content.ToString();
                filteredQuestions = filteredQuestions.Where(q => q.Difficulty == selectedDifficulty);
            }

            // Set the filtered list to the DataGrid
            QuizDataGrid.ItemsSource = filteredQuestions.ToList();
        }
    }

    // Class representing a quiz question
    public class QuizQuestion
    {
        public string Question { get; set; }
        public string Options { get; set; }
        public string CorrectAnswer { get; set; }
        public int Marks { get; set; }
        public int TimeLimit { get; set; }
        public string Topic { get; set; }
        public string Difficulty { get; set; }
    }
}
