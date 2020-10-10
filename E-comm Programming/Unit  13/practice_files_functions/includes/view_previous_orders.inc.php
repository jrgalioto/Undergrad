<?php
$toggle = isset($_GET['toggle'])?$_GET['toggle']:TRUE;
$order_by = isset($_GET['order_by'])?$_GET['order_by']:'category';
$asc_desc = ($toggle)?'ASC':'DESC';

$select_previous_orders = "SELECT hat_orders_hats.hat_orders_id, CONCAT_WS(' ',hat_shipping_addresses.address_1, hat_shipping_addresses.address_2, hat_shipping_addresses.city, state, hat_shipping_addresses.zip) as 'Shipping Address', CONCAT_WS(' ',hat_billing_addresses.address_1, hat_billing_addresses.address_2, hat_billing_addresses.city, state, hat_billing_addresses.zip) as 'Billing Address', GROUP_CONCAT(category SEPARATOR '<br><hr>') as category, GROUP_CONCAT(size SEPARATOR '<br><hr>') as size, GROUP_CONCAT(keyword SEPARATOR '<br><hr>') as keyword, GROUP_CONCAT(hat_orders_hats.quantity SEPARATOR '<br><hr>') as quantity, GROUP_CONCAT(hat_orders_hats.price SEPARATOR '<br><hr>') as price, credit_no, credit_type, order_total, shipping_fee, order_date, shipping_date
	FROM hat_customers
	INNER JOIN hat_states USING (hat_states_id)
	INNER JOIN hat_orders USING (hat_customers_id)
	INNER JOIN hat_shipping_addresses USING (hat_shipping_addresses_id)
	INNER JOIN hat_billing_addresses USING (hat_billing_addresses_id)
	INNER JOIN hat_orders_hats USING (hat_orders_id)
	INNER JOIN hats USING (hats_id)
	INNER JOIN hat_categories USING (hat_categories_id)
	INNER JOIN hat_sizes USING (hat_sizes_id)
	INNER JOIN hat_colors USING (hat_colors_id)
	WHERE hat_customers_id = $hat_customers_id
	GROUP BY hat_orders_hats.hat_orders_id
	ORDER BY $order_by $asc_desc";

$exec_select_previous_orders = @mysqli_query($link, $select_previous_orders);
if(!$exec_select_previous_orders){
	rollback('Previous orders could not be retrieved becase '.mysqli_error($link));
}elseif(mysqli_num_rows($exec_select_previous_orders) > 0){
	echo "<table class='product_info_table'>
		<tr class='header'>
			<th><a href='".$_SERVER['PHP_SELF']."?order_by=hat_shipping_addresses.address_1&toggle=".!$toggle."'>Shipping Address</a></th>
			<th><a href='".$_SERVER['PHP_SELF']."?order_by=hat_billing_addresses.address_1&toggle=".!$toggle."'>Billing Address</a></th>
			<th><a href='".$_SERVER['PHP_SELF']."?order_by=category&toggle=".!$toggle."'>Category</a></th>
			<th><a href='".$_SERVER['PHP_SELF']."?order_by=size&toggle=".!$toggle."'>Size</a></th>
			<th><a href='".$_SERVER['PHP_SELF']."?order_by=keyword&toggle=".!$toggle."'>Color</a></th>
			<th><a href='".$_SERVER['PHP_SELF']."?order_by=hat_orders_hats.quantity&toggle=".!$toggle."'>Quantity</a></th>
			<th><a href='".$_SERVER['PHP_SELF']."?order_by=hat_orders_hats.price&toggle=".!$toggle."'>Price</a></th>
			<th><a href='".$_SERVER['PHP_SELF']."?order_by=credit_no&toggle=".!$toggle."'>Credit No</a></th>
			<th><a href='".$_SERVER['PHP_SELF']."?order_by=credit_type&toggle=".!$toggle."'>Credit Type</a></th>
			<th><a href='".$_SERVER['PHP_SELF']."?order_by=order_total&toggle=".!$toggle."'>Order Total</a></th>
			<th><a href='".$_SERVER['PHP_SELF']."?order_by=shipping_fee&toggle=".!$toggle."'>Shipping Fee</a></th>
			<th><a href='".$_SERVER['PHP_SELF']."?order_by=order_date&toggle=".!$toggle."'>Order Date</a></th>
			<th><a href='".$_SERVER['PHP_SELF']."?order_by=shipping_date&toggle=".!$toggle."'>Shipping Date</a></th>
		</tr>";
	while($one_record = mysqli_fetch_assoc($exec_select_previous_orders)){
		echo "<tr>
			<td>{$one_record['Shipping Address']}</td>
			<td>{$one_record['Billing Address']}</td>
			<td>{$one_record['category']}</td>
			<td>{$one_record['size']}</td>
			<td>{$one_record['keyword']}</td>
			<td>{$one_record['quantity']}</td>
			<td>\${$one_record['price']}</td>
			<td>{$one_record['credit_no']}</td>
			<td>{$one_record['credit_type']}</td>
			<td>\${$one_record['order_total']}</td>
			<td>\${$one_record['shipping_fee']}</td>
			<td>{$one_record['order_date']}</td>
			<td>{$one_record['shipping_date']}</td>
		</tr>";
	}
	echo "<tr><td colspan='12'>Number of Prior Orders:</td><td>".mysqli_num_rows($exec_select_previous_orders)."</td></tr></table>";
	mysqli_free_result($exec_select_previous_orders);
}else{
	echo "No Prior Orders to Show";
}
?>