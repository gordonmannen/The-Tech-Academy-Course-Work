dictionary_name = {'item_1':1,'item_2':2, 'item_3':3}
print dictionary_name['item_1']

epic_programmer_dict = {'Tim Berners-Lee' : 'tbl@gmail.com',
                        'Guido van Rossum' : 'gvr@gmail.com',
                        'Linus Torvalds' : 'lt@gmail.com',}

print epic_programmer_dict
print epic_programmer_dict['Tim Berners-Lee']

# Adds a different email address
epic_programmer_dict['Tim Berners-Lee'] = 'tim@gmail.com'
print 'New email for Tim:' + epic_programmer_dict['Tim Berners-Lee']

# Add Larry Page and his email to the dictionary
epic_programmer_dict['Larry Page'] = 'lp@gmail.com'

print epic_programmer_dict

epic_programmer_dict['Sergey Brin'] = 'sb@gmail.com'
epic_programmer_dict['Gordon Mannen'] = 'gpm@gmail.com'
epic_programmer_dict['Dan Tower'] = 'dt@gmail.com'

print epic_programmer_dict

# If you want to delete an item in the dictionary use
# del epic_programmer_dict['Sergey Brin'] - as an example.


