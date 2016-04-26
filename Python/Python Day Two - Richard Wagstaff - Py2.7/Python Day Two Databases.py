import sqlite3

# Connect to database 'simpsons.db'
conn = sqlite3.connect('simpsons.db')

# If instead you wanted to drop the whole table
# you would use this to delete the table
# conn.execute("DROP TABLE SIMPSON_INFO")

# Get data from database
cursor = conn.execute("SELECT * from SIMPSON_INFO")
print cursor

# Get data from cursor
rows = cursor.fetchall()
print rows

# Create table named SIMPSON_INFO
#conn.execute("CREATE TABLE SIMPSON_INFO( \
#    ID INTEGER PRIMARY KEY AUTOINCREMENT, \
#    NAME TEXT, \
#    GENDER TEXT, \
#    AGE INT, \
#    OCCUPATION TEXT \
#    );")

# Add Bart Simpson to table
#conn.execute("INSERT INTO SIMPSON_INFO \
#    (NAME, GENDER, AGE, OCCUPATION) VALUES \
#    ('Bart Simpson', 'Male', 10, 'Student')");

# Save changes
# conn.commit()

# Print number of changes to database
changes = conn.total_changes
print "Number of changes:", changes

# Add Homer & Lisa Simpson to table
#conn.execute("INSERT INTO SIMPSON_INFO \
#    (NAME, GENDER, AGE, OCCUPATION) VALUES \
#    ('Homer Simpson', 'Male', 40, 'Nuclear Plant')");

# conn.execute("INSERT INTO SIMPSON_INFO \
#    (NAME, GENDER, AGE, OCCUPATION) VALUES \
#    ('Lisa Simpson', 'Female', 8, 'Student')");

# Save changes
conn.commit()

# Get data from database
cursor = conn.execute("SELECT * from SIMPSON_INFO where NAME='Homer Simpson'")
print cursor

# Get data from cursor
rows = cursor.fetchall()
print rows

# Get data from database
cursor = conn.execute("SELECT * from SIMPSON_INFO where GENDER='Female'")
print cursor

# Get data from cursor
rows = cursor.fetchall()
print rows

# Get data from database
cursor = conn.execute("SELECT * from SIMPSON_INFO where OCCUPATION='Student'")
print cursor

# Get data from cursor
rows = cursor.fetchall()
print rows

# Connect to database 'simpsons.db'
conn = sqlite3.connect('simpsons.db')

# Delete rows with ID = 3
# conn.execute("DELETE from SIMPSON_INFO where ID=3")

# Make Homer Simpsons age 41
# conn.execute("UPDATE SIMPSON_INFO \
# set AGE=41 where NAME='Homer Simpson'")


# Save changes
conn.commit()

# Print number of changes
changes = conn.total_changes
print "Number of changes: ",changes


# Get data from database
cursor = conn.execute("SELECT * from SIMPSON_INFO")

# Extract data from cursor
rows = cursor.fetchall()
print rows

