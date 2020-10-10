import string

again = True
count = 0
temp = ''


def bizarro(message):
	count = 0
	alphabet_lower = 'abcdefghijklmnopqrstuvwzyz'
	alphabet_upper = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'
	reverse_lower = 'zyxwvutsrqponmlkjihgfedcba'
	reverse_upper = 'ZYXWVUTSRQPONMLKJIHGFEDCBA'
	alphabet = alphabet_lower + alphabet_upper
	reverse = reverse_lower + reverse_upper
	temp = ''
	#iterate through characters in message
	while(count < len(message)):
		#get the index of the current letter in the alphabet
		target = alphabet.find(message[count])
		#if the current letter is found, it must be alphabetic
		if(message[count] in alphabet):

			#DEBUG print(message[count], ': index', target, ', reverse letter: ', reverse[target])

			#now use the reverse alphabet character at that the same index to appent to build temp
			temp += reverse[target]
			count += 1
		#the character was not found, so it must not be alphabetic!
		elif(message[count] not in alphabet):
			temp += message[count]
			count += 1
		else:
			#appendd the original(non-alphabetic) character instead
			temp += alphabet[target]
			count += 1
	print(temp)


print('============================LAB PART 1============================')
message = input('Type a message: ')
message = bizarro(message)
print('============================LAB PART 2============================')
message = ''
infile = open("C:\\Users\\jrgal\\Desktop\\message.txt","r")
for line in infile:
	message += line + '\n'
message = bizarro(message)

print('============================LAB BONUS 1============================')
message = input("Who is burried in Grant's tomb? : ")
message = bizarro(message)
while(again):
	keep_going = input('enter another message? y/n: ').lower()
	if(keep_going == 'y'):
		again = True
		message = input('Type a message: ')
		message = bizarro(message)
	elif(keep_going =='n'):
		again = False
	else:
		print('Enter a valid input. ')
		again = True
	file = open("C:\\Users\\jrgal\\Desktop\\response.txt","w")