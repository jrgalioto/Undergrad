<?php
mysqli_query($link, "SET AUTOCOMMIT = 0");
$select_hats = "SELECT hats_id, quantity from hat_orders_hats WHERE hat_orders_id = $hat_orders_id";
$exec_select_hats = @mysqli_query($link, $select_hats);
if(!$exec_select_hats){
	rollback('Ordered hats could not be retrieved becase '.mysqli_error($link));
}else{
	while($one_record = mysqli_fetch_assoc($exec_select_hats)){
		$quantity = $one_record['quantity'];
		$hats_id = $one_record['hats_id'];
		$update_hats = "UPDATE hats set stock_quantity = (stock_quantity+$quantity) WHERE hats_id = $hats_id";
		$exec_update_hats = @mysqli_query($link, $update_hats);
		if(!$exec_select_hats){
			rollback('Update was not successful becase '.mysqli_error($link));
		}
	}
	$delete_order = "DELETE hat_shipping_addresses.*, hat_billing_addresses.*, hat_transactions.* FROM hat_orders 
	INNER JOIN hat_billing_addresses USING (hat_billing_addresses_id)
	INNER JOIN hat_shipping_addresses USING (hat_shipping_addresses_id)
	INNER JOIN hat_transactions USING (hat_transactions_id)
	WHERE hat_orders_id = $hat_orders_id";
	$exec_delete_order = @mysqli_query($link, $delete_order);
	if(!$exec_delete_order){
		rollback('Delete was not successful becase '.mysqli_error($link));
	}else{
		mysqli_query($link, "COMMIT");
		redirect('successfully deleted...', 'view_current_orders.php', 1);
	}	
}
?>