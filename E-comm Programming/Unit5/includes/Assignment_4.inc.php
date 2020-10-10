<form action='./includes/Assignment_4_handle.inc.php' method='POST' name='registration_form' id='registration_form' enctype="multipart/form-data">

		<fieldset><legend>Assignment #4</legend>
			<?php 
	
				create_form_field('Enter Text', 'text', 'enter_text', "enter_text",['placeholder' => 'TEXT']);
	
				create_form_field('Password:', 'password', 'pass', 'pass', ['maxlength'=>'15', 'size'=>'10', 'tabindex'=>'6', 'title'=>'Type in Your Password', 'required'=>'required', 'placeholder'=>'xxxxxxxx']);

				ccreate_form_field('Comments:', 'textarea', 'comment', 'comment', ['rows'=>'10', 'cols'=>'50', 'placeholder'=>'Type your comment here:']);
		
			?>
	<p> 
		<fieldset><legend>Buttons</legend>
		<label for='select'>Radio Buttons:</label>
		
		<p>
			This One: <input type="radio" name="select" id="this" value="this">
			<?php if(isset($select) && ($select == 'this')) echo "checked='checked'"; ?>
			That One: <input type="radio" name="select" id="that" value="that">
			<?php if(isset($select) && ($select == 'that')) echo "checked='checked'"; ?>
			The Other One: <input type="radio" name="select" id="the_other" value="the_other">
			<?php if(isset($select) && ($select == 'the_other')) echo "checked='checked'"; ?>
		</p>
	</p>
 	
		<p> 
		<label for='select'>Check Boxes:</label>
		
		<p>
			This One: <input type="checkbox" name="select[]" id="this" value="this">
			<?php if(isset($select) && in_array('this',$select)) echo "checked='checked'"; ?>
			That One: <input type="checkbox" name="select[]" id="that" value="that">
			<?php if(isset($select) && in_array('that',$select)) echo "checked='checked'"; ?>
			The Other One: <input type="checkbox" name="select[]" id="the_other" value="the_other">
			<?php if(isset($select) && in_array('the_other',$select)) echo "checked='checked'"; ?>
		</p>

	</p>
		</fieldset>
	
	<p>
		<p>
			<label for='select_dropdown'>Select One</label>
			<select name="select_dropdown" id="select_dropdown" size="1">
				<option value="this_one">This one</option>
				<?php if(isset($select_dropdown) && ($select_dropdown == 'that_one')) echo "selected='selected'"; ?>
				<option value="that_one">That one</option>
				<?php if(isset($select_dropdown) && ($select_dropdown == 'that_one')) echo "selected='selected'"; ?>
				<option value="other_one">The other one</option>
				<?php if(isset($select_dropdown) && ($select_dropdown == 'other_one')) echo "selected='selected'"; ?>
			</select>
		</p>
	</p>
	
	<p>
		<label>
			<input type="submit" name="Submit">
		</label>
		<label>
			<input type="reset" name="Reset">
		</label>
	</p>
