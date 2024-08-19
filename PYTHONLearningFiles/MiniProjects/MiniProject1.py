import random
from random import randint

tal = randint(1, 100)
print("Gæt et tal fra 1-100")
Gæt = int(input())
count = 0
while count <10:
    if (Gæt <0 or Gæt>100): print("Dit nummer er et uden for det angivne interval på 1-100")
    elif(abs( Gæt - tal)>50): print("Du er meget langt fra")
    elif(abs(Gæt - tal)>19 and abs(Gæt - tal)<49): print("Du er ikke helt ved siden af")
    elif(Gæt == tal): print("Det rigtigt! Du gættede talet i", count, "forsøg")
    else: print("Tampen brænder!")

    Igen = eval(str(input("Vil du prøve igen? Svar ja/nej")))
    if Igen == "ja":
        Gæt = int(input("Gæt et tal fra 1-100"))
    if Igen == "nej":
        break
    count = count + 1
print("Så er spillet slut.")
#while loop + amount of tries left, 10 in total