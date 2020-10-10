<?php 
$title = 'HatFact Order Page';
include_once('header.php');
if (isset($_POST['hidden_field'])) {
	//function include order_handle.php
	include_once('hat_insert_handle.php');
} 
//function include order_form.php
require_once('hat_insert_form.php');
include_once('footer.php');

?>