num = 10
while(num >= 0):
    print(num ** 2)
    num -= 1

print("=====================================================================")


import random
print('Welcome to FightClub ')
again = 'y'
while(again == 'y'):
	tyler = random.randint(1,6)
	robert = random.randint(1,6)

	if int(tyler > robert):
		print('Tyler Durden Wins! ')
	if int(robert > tyler):
		print('Robert Paulson Wins!')
	if(tyler == robert):
		print("It's a draw. ")
	again = input('Play again? (y/n)')
print('Thank you for playing. ')			

   print('==================================================================')

   import random
print('Welcome to FightClub ')

tyler = random.randint(1,6)
robert = random.randint(1,6)

if int(tyler > robert):
	print('Tyler Durden Wins! ')
if int(robert > tyler):
	print('Robert Paulson Wins!')
if(tyler == robert):
	print("It's a draw. ")	