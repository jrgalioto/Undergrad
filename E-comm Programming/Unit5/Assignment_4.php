<?php
 
 $title = 'Assignment 4';
 
require('./includes/mysql.inc.php');
include('./includes/header.inc.php');

if(!empty($_POST['form_submitted'])){
	require('./includes/Assignment_4_handle.inc.php');
}
	
require('./includes/Assignment_4.inc.php');

include('./includes/footer.inc.php');

?>
