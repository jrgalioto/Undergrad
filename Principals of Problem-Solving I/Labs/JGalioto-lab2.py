again = 'y'
import string
while(again == 'y'):	
	story = 'Number_1 years ago prince Adjective_1 ProperNoun_1 stole one of the Noun_2 with Adjective_2. \n Princess GirlsName had one of the Noun_2 with Adjective_3. \n She divided it into Number_2 units to hide it from ProperNoun_1 before she was captured. \n Go find the Number_2 units ProperNoun_3 to Verb_1 her. '
	#print (story) 

	responses=[]
	responses+=[input('Enter a number: ').capitalize()]
	responses+=[input('Enter an noun: ').lower()]
	responses+=[input('Enter a male name: ').title()]
	responses+=[input('Enter a plural noun (dogs, cats, etc...): ').lower()]
	responses+=[input('Enter an noun: ').lower()]
	responses+=[input('Enter a female name: ').title()]
	responses+=[input('Enter an noun: ').lower()]
	responses+=[input('Enter a number: ')]
	responses+=[input('Enter your name: ').title()]
	responses+=[input('Enter a verb: ').lower()]
	print("\n")
	#print(responses)


	story=story.replace('Number_1',responses[0])
	story=story.replace('Adjective_1',responses[1])
	story=story.replace('ProperNoun_1',responses[2])
	story=story.replace('Noun_2',responses[3])
	story=story.replace('Adjective_2',responses[4])
	story=story.replace('GirlsName',responses[5])
	story=story.replace('Adjective_3',responses[6])
	story=story.replace('Number_2',responses[7])
	story=story.replace('ProperNoun_3',responses[8])
	story=story.replace('Verb_1',responses[9])

	print(story)
	print("\n")
	
	again = input('Play again? (y/n): ').lower()
	print("\n")

print('Done. Thank you for playing! ')	
