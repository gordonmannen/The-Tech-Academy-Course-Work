# Our epic programmer dict from before
epic_programmer_dict = {
    'Tim Berners-Lee'  : 'tbl@gmail.com',
    'Guido van Rossum'  : 'gvr@gmail.com',
    'Linus Torvalds'  : 'lt@gmail.com',
    'Larry Page'  : 'lp@gmail.com',
    'Sergey Brin'  : 'sb@gmail.com',
    'Gordon Mannen'  : 'gpm@gmail.com',
    'Dan Tower'  : 'dt@gmail.com',
    }

print epic_programmer_dict

# Our epic programmer dict from before
epic_programmer_dict = {
    'Tim Berners-Lee'  : ['tbl@gmail.com', 111],
    'Guido van Rossum'  : ['gvr@gmail.com', 222],
    'Linus Torvalds'  : ['lt@gmail.com', 333],
    'Larry Page'  : ['lp@gmail.com', 444],
    'Sergey Brin'  : ['sb@gmail.com', 555],
    'Gordon Mannen'  : ['gpm@gmail.com', 666],
    'Dan Tower'  : ['dt@gmail.com', 777],
    }

print epic_programmer_dict

print epic_programmer_dict['Tim Berners-Lee']

print epic_programmer_dict['Tim Berners-Lee'][1]

programmer = epic_programmer_dict['Tim Berners-Lee']
print programmer[1]

personsName = raw_input('Please enter a name:  ')
print personsName

# Looks up the name in the epic dictionary
try:
    # Tries the following lines of texts, and if
    # there are no errors then it runs
    personsInfo = epic_programmer_dict[personsName]
    print personsInfo

except:
    # If there are errors, then this code gets run.
    print 'No information found for that name'

# Our epic programmer dict from before
epic_programmer_dict_1 = {
    'tim berners-lee'  : ['tbl@gmail.com', 111],
    'guido van rossum'  : ['gvr@gmail.com', 222],
    'linus torvalds'  : ['lt@gmail.com', 333],
    'larry page'  : ['lp@gmail.com', 444],
    'sergey brin'  : ['sb@gmail.com', 555],
    'gordon mannen'  : ['gpm@gmail.com', 666],
    'dan tower'  : ['dt@gmail.com', 777],
    }

print epic_programmer_dict_1

personsName = raw_input('Please enter a name:  ').lower()
print personsName

# Looks up the name in the epic dictionary
try:
    # Tries the following lines of texts, and if
    # there are no errors then it runs
    personsInfo = epic_programmer_dict_1[personsName]
    print personsInfo

except:
    # If there are errors, then this code gets run.
    print 'No information found for that name'

# Looks up the name in the epic dictionary
try:
    # Tries the following lines of texts, and if
    # there are no errors then it runs
    personsInfo = epic_programmer_dict_1[personsName]
    print 'Name:  ' + personsName.title()
    print 'Email:  ' + personsInfo[0]
    print 'Number:  ' + str(personsInfo[1])

except:
    # If there are errors then this code gets run.
    print 'No information found for that name'

# Our epic programmer dict from before
epic_programmer_dict_2 = {
    'tim berners-lee'  : ['tbl@gmail.com', 111],
    'guido van rossum'  : ['gvr@gmail.com', 222],
    'linus torvalds'  : ['lt@gmail.com', 333],
    'larry page'  : ['lp@gmail.com', 444],
    'sergey brin'  : ['sb@gmail.com', 555],
    'gordon mannen'  : ['gpm@gmail.com', 666],
    'dan tower'  : ['dt@gmail.com', 777],
    }

def searchPeople(personsName):
    # Looks up the name in the epic dictionary
    try:
        # Tries the following lines of texts,
        # and if there aren't any errors
        # then it runs
        personsInfo = epic_programmer_dict_2[personsName]
        print 'Name:  ' + personsName.title()
        print 'Email:  ' + personsInfo[0]
        print 'Number:  ' + str(personsInfo[1])
    except:
        # If there are errors, then this code gets run.
        print 'No information found for that name'

userWantsMore = True
while userWantsMore == True:
    # Asks user to input persons name
    personsName = raw_input('Please enter a name:  ').lower()

    # Run our new function searchPeople with what was typed in
    searchPeople(personsName)
    userWantsMore = False

    # See if user wants to search again
    searchAgain = raw_input('Search again? (y/n)')

    # Look at what they reply and act accordingly
    if searchAgain == 'y':
        # userWantsMore stays as true so loop repeats
        userWantsMore = True
    elif searchAgain == 'n':
        # userWantsMore turns to False to stop loop
        userWantsMore = False

    else:
        # user inputs an invalid response, so we quit anyway
        print "I don't understand what you mean, quitting"
        userWantsMore = False

    





