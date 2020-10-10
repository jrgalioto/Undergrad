import random
import string

score = 0

def draw_gallows(incorrect):
	if(incorrect==0):
		print("\n")
		print("\n")
		print("\n")
		print("\n")
		print("\n")
		print("\n")
		print("\n")
	elif(incorrect==1):
		print("\n")
		print("\n")
		print("\n")
		print("\n")
		print("\n")
		print("\n")
		print("  =======")
	elif(incorrect==2):
		print("\n")
		print("     |")
		print("     |")
		print("     |")
		print("     |")
		print("    /|\\")
		print("  =======")
	elif(incorrect==3):
		print(" _____")
		print(" |   |")
		print("     |")
		print("     |")
		print("     |")
		print("    /|\\")
		print("  =======")
	elif(incorrect==4):
		print(" _____")
		print(" |   |")
		print(" 0   |")
		print("     |")
		print("     |")
		print("    /|\\")
		print("  =======")
	elif(incorrect==5):
		print(" _____")
		print(" |   |")
		print(" 0   |")
		print("/|   |")
		print("     |")
		print("    /|\\")
		print("  =======")
	elif(incorrect==6):
		print(" _____")
		print(" |   |")
		print(" 0   |")
		print("/|\\  |")
		print("     |")
		print("    /|\\")
		print("  =======")
	elif(incorrect==7):
		print(" _____")
		print(" |   |")
		print(" 0   |")
		print("/|\\  |")
		print("/    |")
		print("    /|\\")
		print("  =======")
	else:
		print(" _____")
		print(" |   |")
		print(" 0   |")
		print("/|\\  |")
		print("/ \\  |")
		print("    /|\\")
		print("  =======")
		print("\n" + ("YOU LOSE!!!  " * 19))
	return incorrect
'''
def win(new_blanks,score):
	for ch in new_blanks:
		if(chr in string.ascii_uppercase):
			score -= 1
	return new_blanks,score
'''
again = True
## Game loop ##
while(again):

	word_list = []
	guesses = []
	incorrect = 0

	infile = open("C:\\Users\\Vinkl\\Documents\\data.csv","r")
	for line in infile:
		row = line.split(',')
		row[0] = row[0].strip()
		row[1] = row[1].strip()
		word_list.append({'word':row[0],'hint':row[1]})

	item = random.choice(word_list)

	score = len(item['word'])

	print(item)

	print('Your hint is:', item['hint'])

	blanks = ('_' * (len(item['word'])))

	for ch in blanks:
		print(ch, end = ' ') 
	print('\n')

	new_blanks = ''



	#Turn Loop

	while(incorrect < 10 or score > 0):
		guess = input('What letter do you want to guess?: ').upper()
		jim = True
		while(jim == True):
			if(len(guess) != 1):
				print('Please input only ONE letter')
				guess = input('What letter do you want to guess?: ').upper()
			elif(guess not in string.ascii_uppercase):
				print('Please input only one LETTER')
				guess = input('What letter do you want to guess?: ').upper()
			elif(guess in guesses):
				print('Please input a letter you have not inputted already')
				guess = input('What letter do you want to guess?: ').upper()
			else:
				jim = False
			
		
		current = 0
		new_blanks = ''

		if(guess not in item['word']):
			incorrect += 1
		else:
				while(current < len(item['word'])):
					if(item['word'][current] == guess):
						new_blanks += guess
						current += 1
					else:
						new_blanks += blanks[current]
						current += 1
		blanks = new_blanks
		for ch in blanks:
			print(ch, end = ' ') 
		print('\n')
		print('Your guesses are',guesses)
		#print(blanks)
		draw_gallows(incorrect)
		if(blanks == item['word']):
			print('You win '*17)
			break
	answer = input('Do you want to play again? y/n: ').lower()
	if(answer == 'n'):
		again = False
	else:
		again = True

