<?php
//phpinfo();

$error_messages = array();

if(isset($_POST['hat_type'])){
	$hat_type = $_POST['hat_type'];
}else{
	$error_messages[] = "You did not select a hat type <br />";
}

if(isset($_POST['hat_quantity'])){
	$hat_quantity = $_POST['hat_quantity'];
}else{
	$error_messages[] = "You did not select the hat quantity <br />";
}

if(!empty($_POST['price'])){
	$price = $_POST['price'];
}else{
	$error_messages[] = "You did not select the price of the hat <br />";
}

if(!empty($error_messages)){
	foreach($error_messages as $value){
		echo $value;
	}
}else{
	echo "Your hat type is : $hat_type <br />";
	echo "Hat quantity is : $hat_quantity <br />";
	echo "Hat price is : $price <br />";
}

?>