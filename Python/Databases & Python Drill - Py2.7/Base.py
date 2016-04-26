#import sqlite3

#connection=sqlite3.connect("test_database.db")

#c=connection.cursor()

#c.execute("CREATE TABLE People(FirstName TEXT,LastName TEXT, Age INT)")

#c.execute("INSERT INTO People VALUES('Ron', 'Obvious', 42)")

#connection.commit()

# If you wanted to create a database in temporary RAM, there is a special way to do so.
# Use > connection=sqlite3.connect(':memory:')
# To drop table > c.execute("DROP TABLE IF EXISTS People")
# To close the database connection > connection.close()
# When working with db connection, to simplify > with sqlite3.connect("test_database.db") as connection:
# perform any SQL operations using connection here is what above line means

# benefits 1) Cleaner, more efficient code, 2) No longer need to commit change they are saved
# automatically, 3) though still need to commit a change if you want to see the result
# of the change immediately before closing the db connection.

import sqlite3

with sqlite3.connect("test_database.db") as connection:

    c=connection.cursor()

    c.executescript("""

    DROP TABLE IF EXISTS People;

    CREATE TABLE People(FirstName TEXT, LastName TEXT, Age INT);

    """)

    peopleValues=(
        ('Ron', 'Obvious', 42),
        ('Luigi', 'Vercotti', 43),
        ('Arthur', 'Belling', 28))

    c.executemany("INSERT INTO People VALUES(?,?,?)",peopleValues)

# get person data from user
firstName=raw_input("Enter your first name:")
lastName=raw_input("Enter your last name:")
age=int(raw_input("Enter your age:"))

# execute insert statement for supplied person data
with sqlite3.connect('test_database.db')as connection:
    c=connection.cursor()
    line="INSERT INTO People Values("'+firstName+'","'+lastName+'","+str(age)+")"
    c.execute(line)

    
