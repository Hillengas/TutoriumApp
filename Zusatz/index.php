
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
    </style>
</head>
<body>

    <nav class="navbar navbar-expand-sm navbar-light bg-dark" style="margin-bottom: 1em;">
        <ul class="nav navbar-nav">
            <li class="nav-item">
                <a class="nav-link button_color" href="#" style="color: white;">Menüpunkt 1</a>
            </li>
            <li class="nav-item">
                <a class="nav-link button_color" href="#" style="color: white;">Menüpunkt 2</a>
            </li>
            <li class="nav-item dropdown">
                <a href="#" class="nav-link dropdown-toggle" data-toggle="dropdown" style="color: white;">Menüpunkt 3</a>
                <div class="dropdown-menu">
                    <a href="#" class="dropdown-item">1</a>
                    <a href="#" class="dropdown-item">2</a>
                    <a href="#" class="dropdown-item">3</a>
                </div>
            </li>
        </ul>
    </nav>

    <div class="row justify-content-sm-center">
        <div class="col-sm-6">
            <div class="card space">
                <img src="question_picture.jpg" class="card-img-top" alt="Frage Bild">
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
        <div class="col-sm-2">
            <div class="card bg-dark text-white" style="margin-bottom: 0.5em;">
                <div class="card-body">
                    <h5 class="card-title">Abstimmungsergebnis</h5>
                    
                </div>
            </div>
        </div>
    </div>
    <p id="demo">Hier sollte der adasdasdasdasasad stehen DEMO</p>
    <div id="chart_div"></div>

    <script>
        var questionForm = document.getElementById("questionForm");
        var submitButton = document.getElementById("submitButton");
        
        // TODO: check if new page is loaded (e.g. every 10 seconds), so if new data is available (eventuell via ID)

        questionForm.addEventListener("click", function() 
        {
            if (atLeastOneRadio())
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
                    else 
                    {
                        //echo 'Fehler bei der Abstimmung!';
                    }
                }
            ?>
            
            //document.getElementById("submitButton").disabled = true;
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
            dataTable.addColumn('string', 'Topping');
            dataTable.addColumn('number', 'Slices');

            <?php
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

                $antworten_json = json_encode($antworten);
            ?>;
 
            var antworten = <?php echo($antworten_json)?>;
             
            for (var key in antworten) 
            {
                dataTable.addRow([key, parseInt(antworten[key])]);
            }
            
            // Set chart options
            var options = {'title':'How Much Pizza I Ate Last Night',
                        'width':500,
                        'height':300};

            // Instantiate and draw our chart, passing in some options.
            var chart = new google.visualization.BarChart(document.getElementById('chart_div'));
            chart.draw(dataTable, options);

            var index = 0;
            setInterval(function() 
            {
                // remove all rows
                dataTable.removeRows(0, Object.keys(antworten).length);

                $.ajax({
                    url:"data.php",
                    method:"POST",
                    data:{action:'fetch'},
                    dataType:"JSON",
                    success:function(data)
                    {
                        //dataTable.addRow(['test', 123]);
                        for (var key in data) 
                        {
                            dataTable.addRow([key, parseInt(data[key])]);
                        }
                        chart.draw(dataTable, options);
                    }
                })

                
                
                



                

                /*for (var key in antworten2) 
                {
                    //alert(antworten2[key]);
                    data.addRow([key, parseInt(antworten2[key])]);
                }*/

                

                index++;
            }, 4000);
            
        }
    </script>
</body>
</html>
