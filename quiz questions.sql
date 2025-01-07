DROP TABLE IF EXISTS QuizQuestions;
-- Create the Quiz Questions table
CREATE TABLE QuizQuestions (
    Id INT PRIMARY KEY IDENTITY,
    Question NVARCHAR(255),
    Options NVARCHAR(255),
    CorrectAnswer NVARCHAR(255),
    Marks INT,
    TimeLimit INT,
    Topic NVARCHAR(50),
    Difficulty NVARCHAR(50)
);

-- Insert sample data into the QuizQuestions table
INSERT INTO QuizQuestions (Question, Options, CorrectAnswer, Marks, TimeLimit, Topic, Difficulty)
VALUES
    ('What is the capital of France?', 'A) Berlin, B) Madrid, C) Paris, D) Rome', 'C) Paris', 5, 30, 'Geography', 'Easy'),
    ('Who developed the theory of relativity?', 'A) Isaac Newton, B) Albert Einstein, C) Galileo Galilei, D) Nikola Tesla', 'B) Albert Einstein', 5, 30, 'Science', 'Medium'),
    ('Which year did World War II end?', 'A) 1940, B) 1945, C) 1950, D) 1960', 'B) 1945', 5, 30, 'History', 'Easy'),
    ('What is the chemical symbol for water?', 'A) H2O, B) O2, C) CO2, D) H2', 'A) H2O', 5, 30, 'Science', 'Easy'),
    ('Who was the first president of the United States?', 'A) Abraham Lincoln, B) George Washington, C) Thomas Jefferson, D) John Adams', 'B) George Washington', 5, 30, 'History', 'Easy'),
    ('What is the largest planet in our solar system?', 'A) Earth, B) Mars, C) Jupiter, D) Saturn', 'C) Jupiter', 5, 30, 'Science', 'Medium'),
    ('Which element has the atomic number 1?', 'A) Helium, B) Oxygen, C) Hydrogen, D) Carbon', 'C) Hydrogen', 5, 30, 'Science', 'Easy'),
    ('What is the largest continent by area?', 'A) Africa, B) Asia, C) Europe, D) North America', 'B) Asia', 5, 30, 'Geography', 'Medium'),
    ('Who painted the Mona Lisa?', 'A) Vincent van Gogh, B) Leonardo da Vinci, C) Pablo Picasso, D) Michelangelo', 'B) Leonardo da Vinci', 5, 30, 'Art', 'Medium'),
    ('What is the smallest country in the world?', 'A) Monaco, B) Vatican City, C) San Marino, D) Liechtenstein', 'B) Vatican City', 5, 30, 'Geography', 'Easy');

	select * from   QuizQuestions;