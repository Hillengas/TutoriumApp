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

        public function createQuestionTable()
        {
            //$this->connection->query("DELETE TABLE questions;");
            $this->connection->query("CREATE TABLE IF NOT EXISTS questions (answer INTEGER);");
        }

        
        /**
         * Liefert ein assozaitves Array aller in der Tabelle questions gespeicherten Einträge
         *
         * @return array
         */
        public function getCountAllAnswers()
        {
            $allquestions = $this->connection->query("SELECT COUNT(*) AS anzahl FROM questions GROUP BY answer;");

            $questions = [];

            while ($question = $allquestions->fetch_assoc()) 
            {
                array_push($questions, $question);
            }

            $allquestions->free();

            return $questions;
        }

        public function saveAnswerInDatabase($answer)
        {
            $this->connection->query("INSERT INTO questions (answer) VALUES ($answer);");
        }


        /**
         * Liefert eine Frage als dictionary zurück, bei der die ID passt
         *
         * @return array
         */
        public function getQuestionByID($id)
        {
            $question = $this->connection->query("SELECT * FROM questions AS q WHERE q.id = $id");

            $question_dictionary = $question->fetch_assoc();


            return $question_dictionary;
        }
    }
?>