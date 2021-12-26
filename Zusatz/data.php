
<?php

if(isset($_POST["action"]))
{
    if($_POST["action"] == 'fetch')
    {
        require_once(__DIR__ . '/Database.php');
        $db = new Database();
        $antworten = array();
        
        $countEachAnswer = $db->getCountEachAnswer();
        foreach ($countEachAnswer as $answer)
        {
            $anzahl = $answer["anzahl"];
            $id = $answer["answerID"];
            $question = $db->getQuestionByID($id);

            $antworten[$question] = $anzahl;
        }

        echo json_encode($antworten);
    }
}
    

?>