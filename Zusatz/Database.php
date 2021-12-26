<?php
    class Database
    {

        private $connection;

        /**
         * Database constructor.
         *
         * Baut die Verbindung zur Datenbank auf
         */
        public function __construct()
        {
            $host = "localhost";
            $user = "tutorium";
            $password = "94PvHewwWZ8Mqj5t";  // Password Datebankzugriff: 94PvHewwWZ8Mqj5t
            $database = "tutorium_mysql";

            $this->connection = new mysqli($host, $user, $password, $database);
        }

        /**
         * Schließt die Verbindung zur Datenbank
         */
        public function __destruct()
        {
            $this->connection->close();
        }

        public function createAnswersTable()
        {
            //$this->connection->query("DELETE TABLE Questions;");
            //$this->connection->query("DELETE TABLE Answers;");
            $this->connection->query("CREATE TABLE IF NOT EXISTS Answers (answerID INTEGER);");
        }

        public function createQuestionsTable()
        {
            $this->connection->query("CREATE TABLE IF NOT EXISTS Questions (id INTEGER, question TEXT);");
        }

        public function deleteAllElementsFromQuestionsTable()
        {
            $this->connection->query("DELETE FROM Questions;");
        }

        public function deleteAllElementsFromAnswersTable()
        {
            $this->connection->query("DELETE FROM Answers;");
        }

        
        /**
         * Liefert ein assozaitves Array aller in der Tabelle questions gespeicherten Einträge
         *
         * @return array
         */
        public function getCountEachAnswer()
        {
            $allquestions = $this->connection->query("SELECT answerID, COUNT(*) AS anzahl FROM Answers GROUP BY answerID;");

            $questions = [];

            while ($question = $allquestions->fetch_assoc()) 
            {
                array_push($questions, $question);
            }

            $allquestions->free();

            return $questions;
        }

        /**
         * Fügt eine gegebene ANtowrt der Tabelle answers hinzu
         */
        public function saveAnswerInDatabase($answerID)
        {
            $this->connection->query("INSERT INTO Answers (answerID) VALUES ($answerID);");
        }


        /**
         * Liefert eine Frage als dictionary zurück, bei der die ID passt
         *
         * @return array
         */
        public function getQuestionByID($id)
        {
            $question_sql = $this->connection->query("SELECT name FROM Questions WHERE id = $id");

            $myQuestion = [];

            while ($question = $question_sql->fetch_assoc()) 
            {
                array_push($myQuestion, $question);
            }

            return $myQuestion[0]["name"];
        }
    }
?>