*<?php

//mysqli_real_escape_string($link, $data);

/**************** Shipping and Billing Address Handle ******************************/
if(!empty($_POST['address_1'])){
	$address_1 = htmlspecialchars(add_slashes($_POST['address_1']));
}else{
	$errors_array['address_1'] = "Please enter a valid home address!";
}

if(!empty($_POST['address_2'])){
	$address_2 = htmlspecialchars(add_slashes($_POST['address_2']));
}else{
	$address_2 = null;
}

if(!empty($_POST['city'])){
	$city = htmlspecialchars(add_slashes($_POST['city']));
}else{
	$errors_array['city'] = "Please enter a valid City!";
}

if(isset($_POST['shirt_states_id'])){
	$shirt_states_id = $_POST['shirt_states_id'];
}else{
	$errors_array['shirt_states_id'] = "Please pick a state!";
}

if(!empty($_POST['zip'])){
	$zip = htmlspecialchars(add_slashes($_POST['zip']));
}else{
	$errors_array['zip'] = "Please enter a valid zip!";
}
/******************************************************************************/

/********************** Payment Method Handle ************************/
if(isset($_POST['credit_type'])){
	$credit_type = $_POST['credit_type'];
}else{
	$errors_array['credit_type'] = "Please pick a valid credit type!";
}

if(!empty($_POST['credit_no'])&&is_numeric(trim($_POST['credit_no']))){
	$credit_no = trim($_POST['credit_no']);
	$credit_no_four = substr($credit_no, -4);
}else{
	$errors_array['credit_no'] = "Please enter a valid credit no!";
}
/******************************************************************************/

/********************** Shipping Method Handle ************************/

if(isset($_POST['shirt_carriers_methods_id'])){
	$shirt_carriers_methods_id = $_POST['shirt_carriers_methods_id'];
}else{
	$errors_array['shirt_carriers_methods_id'] = 'Please pick a shipping method';
}
$select_shipping_fee = "SELECT fee from shirt_carriers_methods WHERE shirt_carriers_methods_id = $shirt_carriers_methods_id";
$exec_select_shipping_fee = @mysqli_query($link, $select_shipping_fee);
if(!$exec_select_shipping_fee){
	rollback("The following error occurred when retrieving shipping fee: ".mysqli_error($link));
}else{
	$one_record = mysqli_fetch_assoc($exec_select_shipping_fee);
	$fee = $one_record['fee'];
}

/******************************************************************************/

/********************** Product Handle ************************/

if(isset($_POST['quantity'])&&is_array($_POST['quantity'])){
	$quantity = $_POST['quantity'];
}else{
	$errors_array['quantity'] = "Please enter a quantity for at least a product type!";
}

foreach($quantity as $shirts_id=>$arr){
	foreach($arr as $price => $value){
		$order_total += ($price * $value);
		$shipping_fee += ($fee * $value);
	}
	$amount_charged = $order_total + $shipping_fee;
}

/******************************************************************************/

if(count($errors_array)==0){
	mysqli_query($link, 'AUTOCOMMIT = 0');
	$insert_shipping_addresses = "INSERT INTO shirt_shipping_addresses (address_1, address_2, city, shirt_states_id, zip, date_created) 
		VALUES ('$address_1', '$address_2', '$city', $shirt_states_id, '$zip', now())";
	$exec_insert_shipping_addresses = @mysqli_query($link, $insert_shipping_addresses);
	if(!$exec_insert_shipping_addresses){
		rollback("The following error occurred when inserting into shirt_shipping_addresses: ".mysqli_error($link));
	}else{
		$shirt_shipping_addresses_id = mysqli_insert_id($link);
		$insert_billing_addresses = "INSERT INTO shirt_billing_addresses (address_1, address_2, city, shirt_states_id, zip, date_created) 
		VALUES ('$address_1', '$address_2', '$city', $shirt_states_id, '$zip', now())";
		$exec_insert_billing_addresses = @mysqli_query($link, $insert_billing_addresses);
		if(!$exec_insert_billing_addresses){
			rollback("The following error occurred when inserting into shirt_billing_addresses: ".mysqli_error($link));
		}else{
			$shirt_billing_addresses_id = mysqli_insert_id($link);
			$insert_transactions = "INSERT into shirt_transactions (amount_charged, type, response_code, response_reason, response_text, date_created) VALUES ($amount_charged, 'credit', 'OK', '', 'Confirmed', now())";
			$exec_insert_transactions = @mysqli_query($link, $insert_transactions);
			if(!$exec_insert_transactions){
				rollback("The following error occurred when inserting into shirt_transactions: ".mysqli_error($link));
			}else{
				$shirt_transactions_id = mysqli_insert_id($link);
				$insert_orders = "INSERT into shirt_orders (shirt_customers_id, shirt_transactions_id, shirt_shipping_addresses_id, shirt_carriers_methods_id, shirt_billing_addresses_id, credit_no, credit_type, order_total, shipping_fee, order_date) VALUES($shirt_customers_id, $shirt_transactions_id, $shirt_shipping_addresses_id, $shirt_carriers_methods_id, $shirt_billing_addresses_id, '$credit_no_four', '$credit_type', $order_total, $shipping_fee, now())";
				$exec_insert_orders = @mysqli_query($link, $insert_orders);
				if(!$exec_insert_orders){
					rollback("The following error occurred when inserting into shirt_orders: ".mysqli_error($link));
				}else{
					$shirt_orders_id = mysqli_insert_id($link);
					foreach($quantity as $shirts_id=>$arr){
						foreach($arr as $price => $value){
							if(!empty($value)){
								$type_total = $price * $value;
								$insert_orders_shirts = "INSERT into shirt_orders_shirts (shirt_orders_id, shirts_id, quantity, price) VALUES ($shirt_orders_id, $shirts_id, $value, $type_total)";
								$exec_insert_orders_shirts = @mysqli_query($link, $insert_orders_shirts);
								if(!$exec_insert_orders_shirts){
									rollback('The following error ocurred when inserting into shirt orders'.mysqli_error($link));
								}else{
									$select_stock_quantity = "SELECT stock_quantity from shirts where shirts_id = $shirts_id";
									$exec_select_stock_quantity = @mysqli_query($link, $select_stock_quantity);
									if(!$exec_select_stock_quantity){
										rollback('The following error ocurred when selecting stock quantity'.mysqli_error($link));
									}else{
										$one_record = mysqli_fetch_assoc($exec_select_stock_quantity);
										$stock_quantity = $one_record['stock_quantity'];
										$updated_quantity = $stock_quantity - $value;
										$update_shirts = "UPDATE shirts SET stock_quantity = $updated_quantity WHERE shirts_id = $shirts_id";
										$exec_update_shirts = @mysqli_query($link, $update_shirts);
										if(!$exec_update_shirts){
											rollback('The following error ocurred when updating stock quantity'.mysqli_error($link));
										}
									}
								}
							}
						}
					}
					mysqli_query($link, 'COMMIT');
					redirect('Your orders were placed...You are now being redirected to order page ...', 'order.php', 2);
				}
			}
		}
	}
}




?>