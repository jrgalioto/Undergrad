<?php
$title = 'Prior Orders';
require('./includes/mysql.inc.php');
$errors_array = array();
$shirt_customers_id = 1;
require('./includes/functions.inc.php');

include('./includes/header.inc.php');
require('./includes/view_previous_orders.inc.php');

include('./includes/footer.inc.php');
?>