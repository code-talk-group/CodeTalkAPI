# CodeTalk Backend 

## User Stories 
### 1. Render Infomation to the Client

  As a Developer I want to be able to recieve code snippets from the Client side and 
  send the snippets back as a sentence.
  
  Tasks:
1. Get information back from the Client side. 
2. Find the corresponding snippet from the database.
3. Then output the stored sentence for that snippet. 

### 2. Setup Database

  As a Developer I want a database that has saved sentences for the options given.

  Task:
  1. Create a Default Snippets, User Snippets and an Options Enum table for the DB. 
  2. Have the Default snippets table store the base sentences for the output.
  3. Have the User Snippets save client's sentences.
  4. Have the options table be an Enum of the code options stored.


### 3. Setup Api  Get Method 

As a developer I want to be able to Get the clients input using the API 

Task:
1. Create an API with proper routes so that the client can send information to the server.
2. When the Get action is called it should find the default sentence for that option.
3. Then be able to add the input variables from the api to the default sentence and send that back to the client.


### 4. Setup API  Post Method 

As a developer I want to be able to store the Sentences given to me from the client.

Task:
1. Create a post method that generates the new sentence.
2. Stores the user sentence into the User snippets table.
3. Make sure to have a unique identifier so that we can show the client the saved sentence.

### 5. Setup API Delete Method 

As a developer I want the user to be able to delete only there saved snippets 

Task:
1. Create a Delete method that takes in a unique identifier.
2. Finds the resource by that unique identifier.
3. Deletes that resource for the table.

### 6. Setup API Put Method 

As a developer I want the user to be able to edit there saved sentence.

Task:
1. Create a Put method that takes in a unique identifier.
2. Finds the resource 
3. Updates the new sentence for that resource 

## Database Schema 
![screenshot](/Assets/CodeTalkDB.jpg)
?