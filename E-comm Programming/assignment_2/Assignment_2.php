<!doctype html>
<html>
<head>
	<title>Assignment #2</title>
	<link rel="stylesheet" type="text/css" href="./styleSheet.css"/>
</head>
<body>

	<form action='./Assignment_2.php' method='POST' name='Assignment_2' id='Assignment_2' enctype="multipart/form-data">
		<fieldset><legend>Assignment #2</legend>

	<p>
		<label for='enter_text:'>Enter Text:</label><input type='text' name='enter_text' id='enter_text' maxlength='20' size='12' value='' tabindex='1' title="Enter some text here"
		required pattern="[A-Za-z]{2,20}" placeholder="">
	</p>
	
	<p>
		<label for='pass'>Password:</label><input type='pass' name='pass' id='pass' maxlength='50' size='30' value='' tabindex='7' title="Type in your password here"
		required placeholder="xxxxxx">
	</p>

	<p>
		<label for="comment">Comments</label>
		<p>
			<textarea rows="10" cols="50" name="comment" id="comment">Type Your Comment Here:</textarea>
		</p>
	</p>


	<p> 
		<fieldset><legend>Buttons</legend>
		<label for='select'>Radio Buttons:</label>
		
		<p>
			This One: <input type="radio" name="select" id="this" value="this">
			That One: <input type="radio" name="select" id="that" value="that">
			The Other One: <input type="radio" name="select" id="the_other" value="the_other">
		</p>
	</p>

		<p> 
		<label for='select'>Check Boxes:</label>
		
		<p>
			This One: <input type="checkbox" name="select" id="this" value="this">
			That One: <input type="checkbox" name="select" id="that" value="that">
			The Other One: <input type="checkbox" name="select" id="the_other" value="the_other">
		</p>
	</p>
		</fieldset>
	
	<p>
		<p>
			<label for='select_dropdown'>Select One</label>
			<select name="select_dropdown" id="select_dropdown" size="1">
				<option value="this_one">This one</option>
				<option value="that_one">That one</option>
				<option value="other_one">The other one</option>
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

</body>
</html>