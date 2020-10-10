databases
	persist data 
	relational databases
		tables - records
		fields - columns
		key
	data hierarchy
	SQL
	ADO.Net
		XML - data itself
	Terminology 
		Data source
			data- database, text file, array, etc
		Binding Source
			Communication layer	
		Table Adapter
			retrieval and updates
		Dataset
			copy of the data, disconnected, temporary
		Bind to controls
			Grid view
			Details - label, text box, combo box


Web Application
	Windows Forms
	Web Forms - ASP.net
	Client/ Server
		Server - IIS, Web Server
		Client - Browser, mobile device, etc
	HTTP - stateless
		cookies, viewstate, queryString, Sessions, Application State
	Three tier
		Presentation - WebForm
			HTML, CSS, JAVASCRIPT, ASP.NET
				ASP.Net - Labels, Textbox, Dropdownbox, Radio, Check
		Webform
			file.aspx
				HTML, CSS, JS, ASP.Net
			file.ASPX>VB
				business logic, events, page load, button click
				VB.Net
		Differences Win vs Web
			webform
				not absolute positioning (with css)
				ID Property
				page load - init happens every time
				postback
					every subsequent visit to the page
					-isPostBack = FALSE the first visit

			winform
				absolute position
				controls - NAME property
				form_load - init, happens once
		cust down on postbacks
			validate the client side as much as possible
			validate controls
				requiredfield validators
				requiredexpressionsvalidator
				rangevalidator
				summaryvalidator

Classes
	object oriented programming language - OOP
	what is an object
		noun
			characteristics - adjectives
				properties
			behaviors - verbs
				methods - sub or function
	OOP
		encapsulation
			data hiding, combinging our characteristics with our verbs
			only show properties and methods that we need to
		polymorphism
			overloading
				same name but different argument list
			overriding
				same name but does something different in the derived class 
		inheritance
			build new class from existing classreusing code, we know workd
			"is a" relationship
				person - employee, student, faculty
				base/parent - derive/child
			derived class - inherits from the base class
		abstract vs concrete
			abstract - generic, we cant impliment
				shape, doesnt impliment all the logic neccessary
			concrete - specific, we can impliment
				triangle, circle