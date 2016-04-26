import sqlite3

peopleValues=(
    ('Ron','Obvious',42),
    ('Luigi','Vercotti',43),
    ('Arthur','Belling',28)
    )

with sqlite3.connect('test_database.db')as connection:
    c=connection.cursor()
    c.execute("DROP TABLE IF EXISTS People")
    c.execute("CREATE TABLE People(FirstName TEXT,LastName TEXT,Age INT)")
    c.executemany("INSERT INTO People VALUES(?,?,?)",peopleValues)
    # select all first and last names from people over age 30
    c.execute("SELECT FirstName,LastName FROM People WHERE Age > 30")
    for row in c.fetchall():
        print row

# The u is referring to unicode meaning those items could contain unusual characters.
# Python 3 stores strings in unicode by default, but if you want Python 2 to act like
# this with strings you can include this line at the beginning of your script:
# from__future__import unicode_literals

c.execute("SELECT FirstName,LastName FROM People WHERE Age > 30")

while True:
    row=c.fetchone()
    if row is None:
        break
    print row



