<?php


if(isset($_POST['shirt_categories_id'])){
	$shirt_categories_id = $_POST['shirt_categories_id'];
}else{
	$errors_array['shirt_categories_id'] = "Please pick a style!";
}

if(isset($_POST['shirt_colors_id'])){
	$shirt_colors_id = $_POST['shirt_colors_id'];
}else{
	$errors_array['shirt_colors_id'] = "Please pick a color!";
}


if(isset($_POST['shirt_sizes_id'])){
	$shirt_sizes_id = $_POST['shirt_sizes_id'];
}else{
	$errors_array['shirt_sizes_id'] = "Please pick a size!";
}

if(isset($_POST['shirt_carriers_methods_id'])){
	$shirt_Carriers_methods_id = $_POST['shirt_Carriers_methods_id'];
}else{
	$errors_array['shirt_carriers_methods_id'] = "Please pick a carrier!";
}

if(!empty($_POST['Quantity'])){
	$city = htmlspecialchars(add_slashes($_POST['Quantity']));
}else{
	$errors_array['Quantity'] = "Please enter a valid Quantity!";
}



if(count($errors_array)==0){
	mysqli_query($link, 'AUTOCOMMIT = 0');
	$insert_into_shirt_orders = "INSERT INTO shirt_orders (shirt_categories_id, shirt_colors_id, shirt_sizes_id, shirt_Carriers_methods_id, Quantity) VALUES
	('$shirt_categories_id', '$shirt_colors_id', '$shirt_sizes_id', '$shirt_Carriers_methods_id', '$Quantity')";
	$exec_insert_into_shirt_orders = @mysqli_query($link, $insert_into_shirt_orders);
	if(!$exec_insert_into_shirt_customers){
		rollback("The following error occurred when inserting into shirt_orders: ".mysqli_error($link));
	}else{
		mysqli_query($link, 'COMMIT');
		header('refresh:2; url=./includes/order.inc.php');
		exit('Your order has been places. You are now being redirected to login page..');
	}
}




?>