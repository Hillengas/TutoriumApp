<!DOCTYPE html>
<html>

<head>
  <meta charset="UTF-8">
  <meta name="description" content="Tutorial">
  <meta name="keywords" content="HTML,CSS,XML,JavaScript">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>

<body>
<iframe src="index.txt" width=400 height=200 frameborder=0 ></iframe>
<iframe src="index.jpg" width=400 height=200 frameborder=0 ></iframe>


<form action="" method="POST">
<input type="radio" id="1" name="a" value="1">
<label for="1">A</label><br>
<input type="radio" id="2" name="a" value="2">
<label for="2">B</label><br>
<input type="radio" id="3" name="a" value="3">
<label for="3">C</label><br>
<input type="radio" id="4" name="a" value="4">
<label for="4">D</label><br>
<input type="radio" id="5" name="a" value="5">
<label for="5">E</label><br>

<input type="submit" name="button" value="Absenden"/>

</form>

<?php

if ($_POST['button']){
if (!empty($_POST['a'])) {
 $file = fopen('answers.txt', 'a');
 fwrite($file, $_POST['a']);
 fwrite($file, ", ");
 fclose($file);
}
else {
echo 'You did not enter a Value. Please enter a Value into this form.';
}
}
?>

</body>
</html>
