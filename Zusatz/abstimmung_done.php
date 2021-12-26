<!DOCTYPE html>
<html lang="en">
<head>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
    
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