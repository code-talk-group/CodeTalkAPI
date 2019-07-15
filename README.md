### CodeTalk Backend

### Swagger Documentation
	https://app.swaggerhub.com/apis-docs/Richard0923/CodeTalkAPI/0.1

### 1. Database
As a Developer I want a database that stores records of spoken code strings for the corresponding options presented to the user on the Client side.
**Tasks:**
1. Create a Default Snippets, User Snippets and Options Enumerables tables for the DB.
2. The Default Snippets table will store records of the base spoken code strings.
3. The User Snippets will store records of user’s customized spoken code snippet.
4. The Options enumerables will store key value pairs of base spoken code strings and a corresponding number to represent said string.

### 2. API HTTP Get Action
As a Developer I want to be able to retrieve records from the User Snippets table in the database to then return as an object to the Client to display.
**Tasks:**
1. Receive request for specific record(s) by ID from Client.
2. Return to Client an object containing the requested record(s)

### 3. API HTTP Post Action
As a developer I want to be able to store the code snippets from the Client side in the database and return a spoken code sentence/record back to the Client.
**Task:**
1. Receive code snippet with user input (i.e. data types, variable names, method names) from the Client side.
2. Find the corresponding spoken code string from the database table Default Snippet.
3. Create new record on db table User Snippet, that builds spoken code snippet from corresponding spoken code string and form inputs.
4. Return to Client the spoken code snippet/User Snippet record.

### 4. API HTTP Delete Action
As a developer I want the user to be able to delete their previously created code snippets.
**Tasks:**
1. Create a Delete method that takes in a request, containing a User Snippet record ID from the Client.
2. Finds the matching record on the User Snippet table or returns a not found message to Client.
3. Deletes the record from the table if found and saves the change.

### 5. API HTTP Put Action
As a developer I want the user to be able to edit their previously created spoken code snippet.
**Tasks:**
1. Create a Put method that takes in a request from Client that contains a User Snippet record ID and the desired changed customized spoken code snippet.
2. Finds the matching record on the User Snippet table or returns a not found message to Client.
3. Updates the customized spoken code snippet to what the user entered on the Client side and saves the changes to that record.

## Database Schema 
![screenshot](/Assets/CodeTalkAPI.jpg)
