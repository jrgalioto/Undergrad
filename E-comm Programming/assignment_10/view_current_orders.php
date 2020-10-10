<?php
$title = 'Not Shipped Orders';
require('./includes/mysql.inc.php');
$shirt_customers_id = 1;
$errors_array = array();
require('./includes/functions.inc.php');

if(isset($_GET['shirt_orders_id'])){
	$shirt_orders_id = $_GET['shirt_orders_id'];
	require('./includes/cancel_orders.inc.php');
}else{
	include('./includes/header.inc.php');
	require('./includes/view_current_orders.inc.php');
}
include('./includes/footer.inc.php');
?>