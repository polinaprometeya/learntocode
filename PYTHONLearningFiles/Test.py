def get_non_negative_int(prompt):
    while True:
        try:
            value = int(input(prompt))
        except ValueError:
            print("Sorry, I didn't understand that.")
            continue

        if value < 0:
            print("Sorry, your response must not be negative.")
            continue
        else:
            break
    return value




while True:
    game()
    if input("Do you want to play again? (y/n): ") == "n":
        break

while (guess != removed_item) and (retry != "No"):
   retry = input("Would you like to try again? Y/N")
   if retry == "Y":
      guess = input('what is the missing item?')
   else:
      break



import random
number=random.randint(1,1000)
count=1
guess= eval(input("Enter your guess between 1 and 1000 "))

while guess !=number:
count+=1

 if guess > number + 10:
  print("Too high!")
 elif guess < number - 10:
  print("Too low!")
 elif guess > number:
  print("Getting warm but still high!")
 elif guess < number:
  print("Getting warm but still Low!")

 guess = eval(input("Try again "))
print("You rock! You guessed the number in" , count , "tries!")

while guess == number:
 count=1
 again=str(input("Do you want to play again, type Y/N "))
if again == Y:
guess= eval(input("Enter your guess between 1 and 1000 "))

if again == N:
break