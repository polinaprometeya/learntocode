from random import randint

alder = randint(-100,200)
print ("Din random alder er", alder)

if (alder <0 or alder>130):
    print("Det alder er ugyldig")
elif (alder <= 18):
    print("Du få ungdomsrabat")
elif (alder >18  and alder<65):
    print("Du få ingen rabat")
else :
    print("Du får pensionsrabat")
