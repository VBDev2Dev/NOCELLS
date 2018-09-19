# NOCELLS
DO NOT use cells for data access when using a datagridview.

## Use

1. Debug project
1. Click generate people to generate fake data
1. Click the other buttons and look at the Immediate window in visual studio
1. Double click on any row header
1. Try selecting multiple rows and clicking the Get Selected Info or Missing Columns buttons.

## Things to note:
- I only added some of the columns that link to properties on the Person class.  If I were to use cell access code, I could only access the values in the properties that are in the columns
- See how double clicking a row header lets me read some data that is not in the columns.
- Notice how changing the data updates the grid ( Change Color button)

# NEVER EVER EVER use cells to get data from a datagridview, EVER!!!!!!!!!!