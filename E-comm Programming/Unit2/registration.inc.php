<!doctype html>
<html>
<head>
	<title>Registration</title>
</head>
<body>
	<form action='./registration_handle.inc.php' method='POST' name='registration_form' id='registration_form' enctype="multipart/form-data">
		<fieldset><legend>Bio</legend>
			
		<p>
			<label for='first_name:'>First Name</label><input type='text' name='first_name' id='first_name' maxlength='20' size='12' value='Daniel' tabindex='1' title="Type in your first name here"
			required pattern="[A-Za-z]{2,20}" placeholder="First Name" />
		</p>
			
		<p>
			<label for='last_name'>Last Name:</label><input type='text' name='last_name' id='last_name' maxlength='20' size='12' value='Chroback' tabindex='1' title="Type in your last name here"
			required pattern="[A-Za-z]{2,20}" placeholder="Last Name" />
		</p>
			
		<p>
			<label for='email'>Email:</label><input type='email' name='email' id='email' maxlength='20' size='12' value='' tabindex='3' title='Type in Your Email Here' required required placeholder='email@you.com' />
		</p>
			
		<p>
			<label for='tel'>Phone:</label><input type='tel' name='tel' id='tel' maxlength='50' size='30' value='' tabindex='4' title="Type in your web site address here"
			required placeholder="xxx-xxx-xxxx" />				
		</p>
			
		<p>
			<label for='url'>Web Site:</label><input type='url' name='url' id='url' maxlength='50' size='30' value='' tabindex='6' title="Type in your web site address here"
			 pattern="[A-Za-z]{2,20}" placeholder="http://www.you.com " />		
		</p>
			
		<p>
			<label for='pass'>Password:</label><input type='pass' name='pass' id='pass' maxlength='50' size='30' value='' tabindex='7' title="Type in your password address here"
			required placeholder="xxxxxx" />
		</p>
			
		<p>
			<label for='re_pass'>Retype Password:</label><input type='re_pass' name='re_pass' id='re_pass' maxlength='50' size='30' value='' tabindex='8' title="Type in your password here again"
			required placeholder="xxxxxx" />
		</p>
			
		<p>
			<label for='date'>Date:</label><input type='date' name='date' id='date' maxlength='50' size='30' value='' tabindex='4' title="Type in today's date here"
			required pattern="[A-Za-z]{2,20}" placeholder="MM/DD/YYYY" />
		</p>
			
		<p>
			<label for='color'>Favorite Color:</label><input type='color' name='color' id='color' maxlength='20' size='10' value='' tabindex='9' title="Type in your favorite color"
			 pattern="[A-Za-z]{2,20}" placeholder=" " />
		</p>		

		<p>
			<label for='id'>User ID:</label><input type='id' name='id' id='id' maxlength='3' size='3' value='' max="999" min="0" step="2" tabindex='4' title="Type in your id here"
			required placeholder="000" />  
		</p>
			<!--password, button, checkbox, radio, file, hidden, image
				HTML5: url, email, search, tel, number, range, date, time, datetime, month, week, color-->
			
		</fieldset>

		<fieldset><legend>Preferences</legend>
			<p>
				<label for='about'>How did you hea about us?</label>
				Internet: <input type="checkbox" name="about[]" id="internet" value="internet" checked="checked"/>
				Friend: <input type="friend" name="about[]" id="friend" value="friend" checked="checked"/>
				Phone: <input type="checkbox" name="about[]" id="phone" value="phone" />
				News: <input type="checkbox" name="about[]" id="news" value="news" />
				Other: <input type="checkbox" name="about[]" id="other" value="other" />
			</p>

			<p> 
				<label for='payment'>Payment Method</label>
				Visa:: <input type="radio" name="payment" id="visa" value="visa" checked="checked"/>
				Master:: <input type="radio" name="payment" id="master" value="master" />
				Discover:: <input type="radio" name="payment" id="discover" value="discover" />
				AmEx:: <input type="radio" name="payment" id="amex" value="amex" />
			</p>
			
			<p> 
				<label for='age_category'>Age Range</label>
				<select name="age_category" id="age_category" size="1" />
					<option value="15-25">15 to 25</option>
					<option value="25-35" selected="selected"> 15 to 25</option>
					<option value="35-50">35 to 50</option>
				</selected> 
			</p>
			
			<p>
				<label for="comment">Comments</label>
				<textarea rows="10" cols="50" name="comment" id="comment">Type Your Comment Here:</textarea>
			</p>

			<p>
				<label for="file_upload">Upload</label>
				<input type="file" multiple="" name="file_upload" id="file_upload">
			</p>
			<input type="hidden" value="user_id" name="hidden_field" id="hidden_field">

		</fieldset>
		<fieldset>
			
			<p>
				<label>
					<input type="submit" name="Submit">
				<!--	<input type="image" src="Penguins.jpg" name="penguins"> -->
					<input type="reset" name="Reset">
				</label>
			</p> 
		</fieldset>

	</form>

</body>
</html>
 