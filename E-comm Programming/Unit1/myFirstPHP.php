<!doctype html>
<html>
<head>
	<title>First PHP</title>
</head>
<body>
<?php
	//This is my first PHP document, which displays some data in the web browser

	$myName = 'Jim Galioto';
	$randomNumber = 53870;
	$userAgent = $_SERVER['HTTP_USER_AGENT'];
	$fileName = basename($_SERVER['SCRIPT_FILENAME']);
	$ipAddress = $_SERVER['REMOTE_ADDR'];

	echo 'My name is: '.$myName.'<br>';
	echo 'Random number is: '.$randomNumber.'<br>';
	echo 'Web browser is: '.($userAgent).'<br>';
	echo 'File name is: '.$fileName.'<br>';
	echo 'IP Address is: '.$ipAddress.'<br>';
?>
</body>
</html>