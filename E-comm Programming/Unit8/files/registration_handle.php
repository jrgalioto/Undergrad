<?php
//phpinfo();

$error_messages = array();

if(!empty($_POST['first_name'])){
	$first_name = $_POST['first_name'];
}else{
	$error_messages[] = "You did not enter your first name <br />";
}

if(!empty($_POST['last_name'])){
	$last_name = $_POST['last_name'];
}else{
	$error_messages[] = "You did not enter your last name <br />";
}

if(!empty($_POST['email'])){
	$email = $_POST['email'];
}else{
	$error_messages[] = "You did not enter your email <br />";
}

if(!empty($_POST['reemail'])){
	$reemail = $_POST['reemail'];
}else{
	$error_messages[] = "You did not reenter your email <br />";
}

if(!empty($_POST['user_id'])){
	$user_id = $_POST['user_id'];
}else{
	$error_messages[] = "You did not enter your user_id <br />";
}

if(!empty($_POST['password'])){
	$password = $_POST['password'];
}else{
	$error_messages[] = "You did not enter your password <br />";
}

if(!empty($_POST['repassword'])){
	$repassword = $_POST['repassword'];
}else{
	$error_messages[] = "You did not reenter your password <br />";
}

if(!ini_get('magic_quotes_gpc')){
	//We do not need to escape the data from the form
	$first_name = addslashes($first_name);
	$last_name = addslashes($_POST['last_name']);
	$email = addslashes($_POST['email']);
	$reemail = addslashes($_POST['reemail']);
	$user_id = addslashes($_POST['user_id']);
}

if(!empty($error_messages)){
	foreach($error_messages as $value){
		echo $value;
	}
}else{
	echo "Your first name is : $first_name <br />";
	echo "Your last name is : $last_name <br />";
	echo "Your email is : $email <br />";
	echo "Your reemail is : $reemail <br />";
	echo "Your user_id is : $user_id <br />";
	echo "Your password is : $password <br />";
	echo "Your repassword is : $repassword <br />";
}

?>