import datetime

print("Please fill out the time you started working and the time you stopped. Full hour and minute count as such: 07:34")

rightnow = datetime.datetime.now()

print ("Current date and time = %s" % rightnow)

work_hourstart = input(%H)
work_minutstart = input(%M)

work_hourend= input(%H)
work_minutend= input(%M)

start_time = abs(work_hourstart+work_minutstart)

print(start_time)
