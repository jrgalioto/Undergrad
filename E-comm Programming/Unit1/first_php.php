<!doctype html>
<html>
<head>
	<title>First PHP</title>
</head>
<body>
<?php
	
	/*phpinfo();
	$str = 'is printed here.'; 
	$str = 1000.54;
	if(is_object($str)) echo '$str is a not a string <br>';
	echo 'My first statement '.number_format($str,2) ; //this is a line
	echo '<br>';
	$myArray = array('one' => 1, 'two' => 'two', 'three' => array('three', 4));
	print_r($myArray);
	echo '<br>';
	echo($myArray[2][0]);
	$num1 = 3;
	$num2 = '4';
	//echo 'Output: '.($num2 % $num1).'<br>';
	if(($num2 != 4) || ($num1 >= 4) {
		echo 'Equals: '.$num2.'<br>';
	}
	else {
		echo 'Not Equals: '.$num2.'<br>';
	}
	*/
	echo basename($_SERVER['PHP_SELF']).'<br>';
	echo $_SERVER['HTTP_USER_AGENT'].'<br>';
	echo $_SERVER['SERVER_NAME'].'<br>';
	echo $_SERVER['REMOTE_ADDR'].'<br>';
	echo $_SERVER['REQUEST_METHOD'].'<br>';
	echo $_SERVER['HTTP_REFERRER'].'<br>';
	echo $_SERVER['SCRIPT_FILENAME'].'<br>';

?>
</body>
</html>