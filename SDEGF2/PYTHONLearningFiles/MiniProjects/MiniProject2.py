import operator
print("Skriv dit DK domain email nedenunder")
#Hvis email > 7 tegn og mindre end 30 tegn
email = input()
size = len(email)
#Hvis email indeholder kun et @
at = operator.countOf(email, "@")

#Hvis email > 7 tegn og mindre end 30 tegn
if (size > 7 and size < 30):
    # Hvis email indeholder kun et @
  if (at == 1):
      # Hvis emails sidste 3 tegn er .dk
      if (email.endswith(".dk")):
          # udskriv valid email
          print("email indput er validt")
          # ellers udskriv fejlbesked
      else: print("forkert email indput")
      # ellers udskriv fejlbesked
  else: print("forkert email indput")
  # ellers udskriv fejlbesked

else: print("forkert email indput")


# OLD CODE NOT USED AND EXAMPLES UNDERNEATH
#___________________________________________________________________________




#user_data=input("Skriv din .dk domain email adress here:")
#input_email = len(user_data)
#at = "@"

#if  7 < input_email < 30 :
 #   if at == 1:
    #    if user_data.endsWith(".dk"): print("Din email er valid og gemt!")
     #   else: print("Din email er incorrekt")
  #  else: print("Din email er incorrekt")
#else: print("Din email er incorrekt")

