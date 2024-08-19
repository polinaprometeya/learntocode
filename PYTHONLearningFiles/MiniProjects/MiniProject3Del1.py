Bruger_data=input("Skriv dit binær nummer så som 10001000 her: ")
binær_nummer = list(Bruger_data)
value = 0
#Starter ved nul og køre rangen ud, pop tag en værdig og fjerner den også

#tjekke om input er givet i rigtig længde, man men kan også tjekke om input er korrekt
if len(binær_nummer)==8:
	for i in range(0,8):
		list_værdig = binær_nummer.pop()
		#så man kan ignorere 0er
		if list_værdig == '1':
			#matematisk omregne tal 2^i
			value = value + pow(2, i)
	print("Dit decimal nummer er:", value)




# OLD CODE NOT USED AND EXAMPLES UNDERNEATH
#___________________________________________________________________________

#print("vil du prøve igen? y/n")
#igen = input()

#def decimalToBinary(Bruger_data):
#if Bruger_data >= 1:
#resultat = decimalToBinary(Bruger_datal // 2) + str(Bruger_datal % 2)
#print("Din binær nummer er:" resultat , end = '')
# printing remainder from each function call

#var = input()
#n = len(var)
#sum = 0
#for i in range(0,n):
    #print(int(var[i])*2**(n-i-1))
    #sum += int(var[i])*2**(n-i-1)
#print(sum)


#def binær_til_decimal (binær_streng):
   # binær=binær_input.zfill(8)
  #  print(binær)
   # decimal=int(binær_streng,2)
  #  return decimal
#binær_input =input("blah" )
#try:
   # decimal_resultat =binær_til_decimal(binær_input)
   # print(decimal_resultat)
#except ValueError:
  #  print("blah")


# Can it be done manually?
# print("Skriv en binær tal for at oversætte den til decimal")
# binær = input()
# number = str(binær)
# længde = len(str(binær))
# a = number[0]
# b = number[1]
# c = number[2]
# d = number[3]
# e = number[4]
# f = number[5]
# g = number[6]
# h = number[7]
# sum = int(a*128)+int(b*64)+int(c*32)+int(d*16)+int(e*8)+int(f*4)+int(g*2)+int(h*1)
# if (længde == 8):
# print ("dit digital tal er", sum )
# else:
#  print("Der er sket en fejl")