<?php
//phpinfo();

$error_messages = array();

	function trim_escape($string) {
		return trim(mysql_real_escape_string($string));
	}

if(isset($_POST['day'])&&isset($_POST['month'])&&isset($_POST['year'])){
	$day = $_POST['day'];
	$month = $_POST['month'];
	$year = $_POST['year'];
}else{
	$error_messages[] = "You did not select an appropriate date <br />";
}

if(!empty($_POST['credit_no']) && is_numeric($_POST['credit_no'])){
	$credit_no = $_POST['credit_no'];
}else{
	$error_messages[] = "You did not enter your credit number or the numebr you entered is not numeric <br />";
}

if(!empty($_POST['security'])&& is_numeric($_POST['security'])){
	$security = $_POST['security'];
}else{
	$error_messages[] = "You did not enter your security code or it is not numeric <br />";
}

if(!empty($_POST['instructions'])){
	$instructions = $_POST['instructions'];
}else{
	$error_messages[] = "You did not enter any instructions <br />";
}

if(isset($_POST['hat_type'])){
	$hat_type = $_POST['hat_type'];
}else{
	$error_messages[] = "You did not select a hat type <br />";
}

if(isset($_POST['credit_type'])){
	$credit_type = $_POST['credit_type'];
}else{
	$error_messages[] = "You did not select a credit type <br />";
}

if(!empty($_POST['carrier'])){
	$carrier = $_POST['carrier'];
}else{
	$error_messages[] = "You did not select a shipping method <br />";
}

if(isset($_POST['shipping_method'])){
	$shipping_method = $_POST['shipping_method'];
}else{
	$error_messages[] = "You did not select a shipping method <br />";
}

		if (!empty($_POST['house'])) {
			$house = trim_escape($_POST['house']);
		} else {
			$error_messages[] = "Enter your house number <br />";
		}
		
		if (!empty($_POST['street'])) {
			$street = trim_escape($_POST['street']);
		} else {
			$error_messages[] = "Enter your street name <br />";
		}
		
		if (!empty($_POST['city'])) {
			$city = trim_escape($_POST['city']);
		} else {
			$error_messages[] = "Enter your city name <br />";
		}
		
		if (!empty($_POST['state'])) {
			$state = $_POST['state'];
		} else {
			$error_messages[] = "Enter your state name <br />";
		}
		
		if (!empty($_POST['zip'])) {
			$zip = trim_escape($_POST['zip']);
		} else {
			$error_messages[] = "Enter your zip code <br />";
		}


if(!ini_get('magic_quotes_gpc')){
	//We do not need to escape the data from the form
	$instructions = addslashes($instructions);
}

if(!empty($error_messages)){
	foreach($error_messages as $value){
		echo $value;
	}
}else{
	echo "Your hat type is : $hat_type <br />";
	echo "Your credit type is : $credit_type <br />";
	echo "Your credit no is : $credit_no <br />";
	echo "Your security is : $security <br />";
	echo "Your carier(s) is/are : ";
	foreach($shipping as $value){
		 echo "$value,";
	}
	echo "<br />";
	echo "Your shipping method is : $shipping_method <br />";
	echo "Your instructions is : $instructions <br />";
}

?>