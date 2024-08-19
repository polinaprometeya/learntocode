
#print("Søren er "+ str(Alder["Søren"]) + " år gammel")
#print("Niels er "+ str(Alder["Niels"]) + " år gammel")
#print("Anders er "+ str(Alder["Anders"]) + " år gammel")
# resten af navne som ikke er brugt ["Peter","Mikkel","Flemming","Hans","Nikolaj"]

alder = {"Søren":30,"Niels":31,"Anders":32, }

print("Navn og alder af deltager er : ")
for key, value in alder.items():
    print(key, "er",  value, "år gammel")

#Man kan beskrive key og value på en anden måde så som ---> for navn, alder in alder.items(): -->  eller x og y

#the str(dict[]) skal bruges for at speceficere at det er alderen der skal udskrives.
#Så alternativ måde at gøre er ----> for i in Alder: print (i + " er: " + str(Alder[i])+ " år gammel")

