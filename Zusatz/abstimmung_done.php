<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Stimme abgegeben</title>
</head>
<body>
    
    <?php
        if ($_POST['button'])
        {
            if (!empty($_POST['a'])) 
            {
                $file = fopen('answers.txt', 'a');
                fwrite($file, $_POST['a']);
                fwrite($file, ", ");
                fclose($file);

                echo "<p>Stimme abgegeben</p>";
                echo "<form action='index.php' method='POST'><input type='submit' name='button' value='Nächste Frage' class='btn btn-primary'/></form>";
            }
            else 
            {
                echo 'Sie haben keine Abstimmung getätigt.';
            }
        }
    ?>
</body>
</html>