import random
import string

def symbol_repl(card_str):
        return card_str.replace('S','\u2660').replace('H','\u2665').replace('C','\u2663').replace('D','\u2666')

def create_deck():
        deck =[]
        suits = ['C','D','H','S']
        card_val = ['A','K','Q','J','T','9','8','7','6','5','4','3','2']
        for suit in suits:
                for card in card_val:
                        deck += [card + suit]
        return deck

def eval(hand):
        score = 0
        ace_count = 0 
        card_val = {'A':11,'K':10,'Q':10,'J':10,'T':10,'9':9,'8':8,'7':7,'6':6,'5':5,'4':4,'3':3,'2':2}
        for card in hand:
            score += card_val[card[0]]
            if(card[0] == 'A'):
                ace_count += 1
            while(score > 21) and (ace_count > 0):
                score -= 10
                ace_count -=1
        return score

                
again = 'y'
while(again == 'y'):
	cardnum = 0
            
	deck = create_deck()

	random.shuffle(deck)
	#print("Shuffled deck: ", deck)
	#print('first item: ' + deck[0])

	dealer_hand = []
	player1_hand = []

#TODO: Deal cards out from the deck to make hands

#TODO: make sure you don't select the same card
# cardnum = random.randint(0,(len(list)-1))
# print('choosing list index: ', cardnum)


# Thank you to Chris who contributed more to
# the writing of this code than my actual partner,
# Who I do not believe wrote as much as a comma or colon.


	player1_hand += [symbol_repl(deck[cardnum])]
	cardnum += 1
	dealer_hand += [symbol_repl(deck[cardnum])]
	cardnum += 1
	player1_hand += [symbol_repl(deck[cardnum])]
	cardnum += 1
	dealer_hand += [symbol_repl(deck[cardnum])]
	cardnum += 1

	print('your cards:', player1_hand[0],player1_hand[1])
	print('dealer cards: ??', dealer_hand[1])
	print ('You have ',eval(player1_hand))
	if(eval(player1_hand) == 21 and eval(dealer_hand) == 21):
	    print('Draw! ')
	    again = input("Play another hand? (y/n):").lower()

	elif(eval(player1_hand) == 21):
	    print('BLACKJACK! ')
	    again = input("Play another hand? (y/n):").lower()

	elif(eval(dealer_hand) == 21):
	    print('House has Blackjack. You lose! ')
	    again = input("Play another hand? (y/n):").lower()

	print("\n")

	#player hand    
	checker = True
	while(checker):
	    if(eval(player1_hand) < 21):
	        hit = input('Would you like another card? (y/n) ').lower()
	        if hit == 'y':
	            player1_hand += [symbol_repl(deck[cardnum])]
	            cardnum += 1
	            print('Your cards: ',player1_hand[::])
	            print('You now have ',eval(player1_hand))                
	            checker = True
	        elif hit == 'n':
	            print('You stand at ',eval(player1_hand))
	            checker = False
	    elif(eval(player1_hand) > 21):
	        print('Player busts! You Lose! ')
	        checker = False
	print("\n")

	#dealer hand
	checker1 = True
	while(checker1) and eval(player1_hand) <= 21:
	    if(eval(dealer_hand) < 17):
	        dealer_hand += [symbol_repl(deck[cardnum])]
	        cardnum += 1
	        checker1 = True
	    elif(eval(dealer_hand) >= 17) and (eval(dealer_hand) <= 21):
	#evaluate
	        if(eval(dealer_hand) < eval(player1_hand)):
	            print('Dealer has ',eval(dealer_hand))
	            print('You have ',eval(player1_hand))
	            print('You Win! ')
	            checker1 = False
	        elif(eval(dealer_hand) > eval(player1_hand)) and (eval(player1_hand) < 21):
	            print('Dealer has ',eval(dealer_hand))
	            print('You have ',eval(player1_hand))
	            print('You Lose! ')
	            checker1 = False
	        elif(eval(dealer_hand) == eval(player1_hand)):
	            print('Dealer has ',eval(dealer_hand))
	            print('You have ',eval(player1_hand))
	            print('DRAW! ')
	            checker1 = False
            elif(eval(dealer_hand) > 21 and eval(player1_hand) > 21):
            	print('Draw! ')
            	checker1 = False
	    elif(eval(dealer_hand) > 21):
		        print('House busts at ',eval(dealer_hand))
		        print('You win! ')
		        checker1 = False     

	again = input("Play another hand? (y/n):").lower()
	print("\n")
print("Chickenshit!")
print('You should at least thank Chris for fixing the ace counter since Jim is a fucking retard!' )
print("\n") 
