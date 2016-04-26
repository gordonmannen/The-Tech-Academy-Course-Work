# Create the list of epic programmers
epic_programmer_list = ["Tim Berners-Lee",
                        "Guido van Rossum",
                        "Linus Torvalds",
                        "Larry Page",
                        "Sergey Brin",
                        "Gordon Mannen :)",]

# print to console
# print "Epic programmers:  " + epic_programmer_list
# the above won't work, so commented out

# print to console
print "An epic programmer:  " + epic_programmer_list[0]

print "An epic programmer:  " + epic_programmer_list[1]
print "An epic programmer:  " + epic_programmer_list[2]
print "An epic programmer:  " + epic_programmer_list[3]
print "An epic programmer:  " + epic_programmer_list[4]
print "An epic programmer:  " + epic_programmer_list[5]

epic_programmer_list.append("Dan Tower")

# Add this line to show the appended programmer in the console
print "An epic programmer:  " + epic_programmer_list[6]

# Looping through each item in epic_programmer_list
for programmer in epic_programmer_list:
    # Print the programmers' name to console
    print programmer

for programmer in epic_programmer_list:
    print "An epic programmer:  " + programmer

# Create list of numbers
number_list = [1,2,3,4,5]

# Loop each number in number_list
for x in number_list:
    # Print each number to the power of 2
    print x**2

# Create list of numbers
number_list = [1,2,3,4,5]
empty_number_list = []

# Loop each number in number_list
for x in number_list:
    # Append each number to the power of 2
    # to the empty_number list
    empty_number_list.append(x**2)

print empty_number_list
