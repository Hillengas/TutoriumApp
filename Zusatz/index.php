
<!DOCTYPE html>
<html lang="en">
<head>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>

    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tutorium</title>

    <style>
        .space
        {
            margin-bottom: 0.5em;
        }

        .button_color
        {
            color: rgb(255, 255, 255);
        }

        input[type="radio"] 
        {
            margin-right:10px;
        }
    </style>
</head>
<body>    
    <nav class="navbar navbar-expand-sm navbar-light bg-dark" style="margin-bottom: 1em;">
        <a class="navbar-brand">
            <span class="button_color">Tutorium</span>
        </a>
    </nav>

    <div class="row justify-content-sm-center">
        <div class="col-sm-6">
            <div class="card space">
                <img id="question_picture" src="question_picture.jpg?123" class="card-img-top" alt="Frage Bild">
                <div class="card-body">
                    <h5 class="card-title"><?php include('question_title.txt'); ?></h5>
                    <form id="questionForm" method="POST">
                        <?php
                            $questionsText_file = fopen("question_text.txt", "r");

                            if ($questionsText_file) 
                            {
                                $counter = 0;
                                $question_text = fgets($questionsText_file);
                                $question_text_list = explode('-', $question_text);

                                // remove empty-string element
                                array_shift($question_text_list);

                                foreach ($question_text_list as $question) 
                                {
                                    $counter++;

                                    echo "<input type='radio' id='$counter' name ='a' value='$counter'>";
                                    echo "<label for='$counter'>$question</label><br>";
                                }
                            
                                fclose($questionsText_file);

                                // Anzahl der Antworten speichern
                                $file = fopen('questions_count.txt', 'w');
                                fwrite($file, $counter);
                                fclose($file);
                            } 
                            else 
                            {
                                echo 'Fehler beim Auslesen der Frage!';
                            } 
                        ?>

                        <input id="submitButton" type="submit" name="button" value="Absenden" class="btn btn-primary" disabled/>
                    </form>
                </div>
            </div>
        </div>
        <div class="col-sm-4">
            <div class="card bg-dark text-white" style="margin-bottom: 0.5em;">
                <div class="card-body">
                    <h5 class="card-title">Abstimmungsergebnis</h5>
                    <div id="chart_div"></div>
                    <div id="anzahl_stimmen_div"></div>
                </div>
            </div>
        </div>
    </div>
    <!--<div id="lastModified">Test Section</div>-->

    <?php
        require_once(__DIR__ . '/Database.php');
        $db = new Database();
        $antworten = array();

        $myCounter = 0;
        $postSet = 0;

        if ($_POST['button'])
        {
            $postSet = 1;
        }

        $countEachAnswer = $db->getCountEachAnswer();
        foreach ($countEachAnswer as $answer)
        {
            $anzahl = $answer["anzahl"];
            $id = $answer["answerID"];
            $question = $db->getQuestionByID($id);

            $myCounter += $anzahl;

            $antworten[$question] = $anzahl;
        }
        
        $antworten_json = json_encode($antworten);
    ?>
    

    <script>
        document.getElementById("question_picture").src = "question_picture.jpg?" + performance.now();

        var questionForm = document.getElementById("questionForm");
        var submitButton = document.getElementById("submitButton");

        setInterval(function()
        {
            $.ajax({
                traditional: true,
                url:"data.php",
                method:"POST",
                data:{action:'getNewQuestionAvailable'},
                dataType:"JSON",
                success:function(newQuestionAvailable)
                {
                    if (newQuestionAvailable)
                    {
                        location.assign("index.php");
                    }
                }
            })
        }, 7000); 
        
        questionForm.addEventListener("click", function() 
        {
            postSet = <?php echo "$postSet" ; ?>;
            if (atLeastOneRadio() && !postSet)
            {
                document.getElementById("submitButton").disabled = false;
            }
        })

        submitButton.addEventListener("click", function()
        {
            <?php
                require_once(__DIR__ . "/Database.php");
                $db = new Database();

                if ($_POST['button'])
                {
                    if (!empty($_POST['a'])) 
                    {    
                        $answerID = $_POST['a'];
                        $db->saveAnswerInDatabase($answerID);
                    }
                }
            ?>
            
            document.getElementById("submitButton").disabled = true;
        })

        function atLeastOneRadio() 
        {
            return ($("input[name='a']:checked").length > 0);
        }

        // load current chart package
        google.charts.load("current", {
        packages: ["corechart", "line"]
        });

        // set callback function when api loaded
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() 
        {
            var dataTable = new google.visualization.DataTable();
            dataTable.addColumn('string', 'Antwort');
            dataTable.addColumn('number', 'Anzahl');

            var myCounter = <?php echo "$myCounter" ; ?>;
            var antworten = <?php echo ($antworten_json) ; ?>;

            document.getElementById("anzahl_stimmen_div").innerHTML = "Anzahl abgegebener Stimmen: " + myCounter;
             
            for (var key in antworten) 
            {
                dataTable.addRow([key, parseInt(antworten[key])]);
            }
            
            // Set chart options
            var options = {
                        'width':'100%',
                        'height':'100%'};

            // Instantiate and draw our chart, passing in some options.
            var chart = new google.visualization.BarChart(document.getElementById('chart_div'));
            chart.draw(dataTable, options);

            setInterval(function() 
            {
                // remove all rows
                //dataTable.removeRows(0, Object.keys(antworten).length);
                dataTable = new google.visualization.DataTable();
                dataTable.addColumn('string', 'Antwort');
                dataTable.addColumn('number', 'Anzahl');

                var counter = 0;

                $.ajax({
                    url:"data.php",
                    method:"POST",
                    data:{action:'fetch'},
                    dataType:"JSON",
                    success:function(data)
                    {
                        for (var key in data) 
                        {
                            counter += parseInt(data[key]);
                            dataTable.addRow([key, parseInt(data[key])]);
                        }
                        chart.draw(dataTable, options);
                        document.getElementById("anzahl_stimmen_div").innerHTML = "Anzahl abgegebener Stimmen: " + counter;
                    }
                })

            }, 2000);
        }
    </script>
</body>
</html>
