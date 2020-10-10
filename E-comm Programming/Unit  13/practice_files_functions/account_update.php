<?php
$title = 'Account Update';
require('../../../secure_files/mysql.inc.php');
$errors_array = array();
require('./includes/functions.inc.php');

if(isset($_GET['hat_customers_id'])){
	include('./includes/header.inc.php');
	$hat_customers_id = $_GET['hat_customers_id'];
	require('./includes/account_retrieve.inc.php');
	require('./includes/account_update.inc.php');
}elseif(isset($_POST['hat_customers_id'])){
	$hat_customers_id = $_POST['hat_customers_id'];
	require('./includes/account_update_handle.inc.php');
}else{
	redirect('Unknown Access','account_info.php',2);
}
include('./includes/footer.inc.php');
?>