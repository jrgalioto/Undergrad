<?php

$errors_array = array();

if(!empty($_POST['enter_text'])&&is_string($_POST['enter_text'])){
	$enter_text = htmlspecialchars(add_slashes($_POST['enter_text']));
}else{
	$errors_array['enter_text'] = "Please enter a valid first name!";
}

if(!empty($_POST['pass'])){
	$pass = htmlspecialchars($_POST['pass']);
}else{
	$errors_array['pass'] = "Please enter a valid password!";
}

if(!empty($_POST['comment'])){
	$comment = htmlspecialchars(add_slashes($_POST['comment']));
}else{
	$errors_array['comment'] = "Please enter a valid comment!";
}

if(isset($_POST['select'])&&is_array($_POST['select'])){
	$select = $_POST['select'];
}else{
	$errors_array['select'] = "Please enter a valid select option!";
}

if(isset($_POST['radselect'])){
	$radselect = $_POST['radselect'];
}else{
	$errors_array['radselect'] = "Please enter a radio!";
}

if(isset($_POST['select_dropdown'])){
	$select_dropdown = $_POST['select_dropdown'];
}else{
	$errors_array['select_dropdown'] = "Please enter a valid age category!";
}
	
function add_slashes($data){
	if(get_magic_quotes_gpc()) $data = stripslashes($data);
	return addslashes($data);
}

function strip_slashes($data){
	return stripslashes($data);
}


if(count($errors_array) > 0){
	foreach($errors_array as $key => $var){
		echo $var."<br>";
	}
}else{
	echo "Text: ".strip_slashes($enter_text)." <br>
	Password: ".strip_slashes($pass)." <br>
	About: ";
	//foreach($about as $var){
//		echo $var.",";
	echo "<br>
	select: <br>";
	foreach($select as $var){
		echo $var.",";
	}
	echo "Age Category: $select_dropdown <br>
	Comment: ".strip_slashes($comment); 
}