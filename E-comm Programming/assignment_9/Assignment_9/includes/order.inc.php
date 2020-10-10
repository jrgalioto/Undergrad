<form action='<? echo $_SERVER['PHP_SELF']; ?>' method='POST' name='registration_form' id='registration_form' enctype='multipart/form-data'>
	<fieldset><legend>Registration</legend>
		<?php
			create_form_field('Address 1:', 'text', 'address_1', 'address_1', ['maxlength'=>'100', 'Size'=>'50', 'tabindex'=>'6', 'title'=>'Home Address', 'required'=>'required', 'pattern'=>'[A-Za-z0-9_\.\#\' \-:=]{2,100}', 'placeholder'=>'100 Market Street'], $errors_array);
			create_form_field('Address 2:', 'text', 'address_2', 'address_2', ['maxlength'=>'100', 'Size'=>'50', 'tabindex'=>'7', 'title'=>'Home Address', 'pattern'=>'[A-Za-z0-9_\.\#\' \-:=]{0,100}', 'placeholder'=>'Suite #9'], $errors_array);
			create_form_field('City:', 'text', 'city', 'city', ['maxlength'=>'50', 'Size'=>'20', 'tabindex'=>'8', 'title'=>'City', 'pattern'=>'[A-Za-z]{2,50}', 'placeholder'=>'Youngstown'], $errors_array);
			

			/***************** Create function call for state drop down menu ********************************/
			$select_states = "SELECT shirt_states_id, state, abbr from shirt_states";
			$exec_select_states = @mysqli_query($link, $select_states);
			if(!$exec_select_states){
				exit("The following error occurred: ".mysqli_error($link));
				mysqli_close($link);
			}else{
				$multi_array = array();
				while($one_record = mysqli_fetch_assoc($exec_select_states)){
					$multi_array[] = $one_record;
				}
				create_drop_down_from_query('State: ', 'shirt_states_id', 'shirt_states_id', $multi_array, ['tabindex'=>'9', 'title'=>'State'], $errors_array);
			}
			/***************** End function call for state drop down menu ********************************/


			create_form_field('Zip:', 'text', 'zip', 'zip', ['maxlength'=>'5', 'Size'=>'5', 'tabindex'=>'10', 'title'=>'Zip Code', 'placeholder'=>'44555'], $errors_array);
			create_form_field('Date Created:', 'date', 'date_created', 'date_created', ['tabindex'=>'11', 'title'=>'Today Date', 'placeholder'=>'YYYY/MM/DD'], $errors_array);
			
			
			/***************** Create function call for shirt category drop down menu ********************************/
			$select_categories = "SELECT shirt_categories_id, category, description from shirt_categories";
			$exec_select_categories = @mysqli_query($link, $select_categories);
			if(!$exec_select_categories){
				exit("The following error occurred: ".mysqli_error($link));
				mysqli_close($link);
			}else{
				$multi_array = array();
				while($one_record = mysqli_fetch_assoc($exec_select_categories)){
					$multi_array[] = $one_record;
				}
				create_drop_down_from_query('Style: ', 'shirt_categories_id', 'shirt_categories_id', $multi_array, ['tabindex'=>'6', 'title'=>'Style'], $errors_array);
			}
			/***************** End function call for category drop down menu ********************************/

			
			/***************** Create function call for shirt color drop down menu ********************************/
			$select_color = "SELECT shirt_colors_id, keyword, code from shirt_colors";
			$exec_select_color = @mysqli_query($link, $select_color);
			if(!$exec_select_color){
				exit("The following error occurred: ".mysqli_error($link));
				mysqli_close($link);
			}else{
				$multi_array = array();
				while($one_record = mysqli_fetch_assoc($exec_select_color)){
					$multi_array[] = $one_record;
				}
				create_drop_down_from_query('Color: ', 'shirt_colors_id', 'shirt_colors_id', $multi_array, ['tabindex'=>'18', 'title'=>'Color'], $errors_array);
			}
			/***************** End function call for color drop down menu ******************************


			/***************** Create function call for shirt Sizes drop down menu ********************************/
			$select_Size = "SELECT shirt_Sizes_id, keyword, code from shirt_Sizes";
			$exec_select_Size = @mysqli_query($link, $select_SizesSize);
			if(!$exec_select_categories){
				exit("The following error occurred: ".mysqli_error($link));
				mysqli_close($link);
			}else{
				$multi_array = array();
				while($one_record = mysqli_fetch_assoc($exec_select_SizesSize)){
					$multi_array[] = $one_record;
				}
				create_drop_down_from_query('Size: ', 'shirt_Sizes_id', 'Sizes', $multi_array, ['tabindex'=>'9', 'title'=>'Sizes'], $errors_array);
			}
			/***************** End function call for Size drop down menu ********************************/

			

			/***************** Create function call for shirt Carrierss drop down menu ********************************/
			$select_Carriers = "SELECT shirt_Carriers_methods_id, carrier, fee from shirt_Carriers_methods";
			$exec_select_Carriers = @mysqli_query($link, $select_CarrierssCarriers);
			if(!$exec_select_categories){
				exit("The following error occurred: ".mysqli_error($link));
				mysqli_close($link);
			}else{
				$multi_array = array();
				while($one_record = mysqli_fetch_assoc($exec_select_CarrierssCarriers)){
					$multi_array[] = $one_record;
				}
				create_drop_down_from_query('Carriers: ', 'shirt_Carriers_methods_id', 'Carrierss', $multi_array, ['tabindex'=>'7', 'title'=>'Carriers'], $errors_array);
			}
			/***************** End function call for Carriers drop down menu ********************************/

	create_form_field('Quantity:', 'text', 'Quantity', 'Quantity', ['maxlength'=>'5', 'Size'=>'5', 'tabindex'=>'10', 'title'=>'Quantity Code', 'placeholder'=>'0'], $errors_array);



		?>
	</fieldset>
	<fieldset>
	<p>
		<label>
			<input type='hidden' value='form_submitted' name='form_submitted' id='form_submitted' />
			<input type='submit' value='Submit' />
			<!--<input type='image' src='./Penguins.jpg' name='penguins' id='penguins' />-->
			<input type='reset' value='Reset' />
		</label>
	</p>
	</fieldset>

</form>

