import sqlite3
# get person data from user and insert into a tuple
firstName=raw_input("Enter your first name:")
lastName=raw_input("Enter your last name:")
age=int(raw_input("Enter your age:"))

personData=(firstName,lastName,age)
# execute insert statement for supplied person data
with sqlite3.connect('test_database.db')as connection:
        c=connection.cursor()
        c.execute("INSERT INTO People VALUES(?,?,?)",personData)

# If you just wanted to update a particular detail for a person
# c.execute("UPDATE People SET Age=?WHERE FirstName=? AND LastName?",
# (45,'Luigi','Vercotti'))

c.execute("UPDATE People SET Age=? WHERE FirstName=? AND LastName=?", (45,'Luigi','Vercotti'))
