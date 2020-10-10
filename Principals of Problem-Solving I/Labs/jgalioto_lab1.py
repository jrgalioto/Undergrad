done = 'n'
while (done == 'n'):
	year = 2017	
	name = input ("Enter Your Name: ")
	print ('Hello', name, '!') 

	birth = int(input ("What year were your born? YYYY " ))
	age = year - birth

	if (30  > age > 0):
		print ('There is no way you are only' , age ,'!')
		print ('You look like shit!' )	
	elif (30 < age):
		print (age, 'Fuck! You are old!' )
	elif (0 >= age):
		print ('STFU' , name,'!')
	done = input('Are you done? n/y: ' )
	print('8======================================================D')
print('8======================================================D')

count = 0
num = 0
while (count <=3):
	print(num)
	print(num + 1)
	count += 1
print ('BOOM!')

print('8======================================================D')
print('8======================================================D')

num = 1
count = 0
while(count <= 19):
	print(num ** (num))
	num += 1
	count += 1

print('FIN!')