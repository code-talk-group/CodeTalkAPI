# CodeTalk Backend 

## User Stories 
### 1. Render Infomation to the MVC

  As a Developer I want to be able to recieve code snippets from the MVC side and 
  translate the snippets into a sentence.
  
  Tasks:
1. Recieve information from the MVC side. 
2. Be able to translate the information recieved using the databases stored info.
3. Send the information to the MVC side. 

### 2. Database

  As a Developer I want a database that has stored the information for translating the information for that table.

  Task:
  1. Determine tables for the databases. 
  2. Have those tables save the translated sentence for that code snippets allowed.
  3. Be able to grab that information.

### 3. Setup Api for MVC

As a developer i want to setup the routes and mapping for our api so that the MVC so we can do HTTP actions.

Task:
1. Create an API with proper routes .
2. Be able to conduct http actions(Get, Post).

### 4. User table 
As a developer I want to have a table that can store user's output and any edits made

Task:
1. Store users output inside a table.
2. Recieve any edits made to that output given and replace the with the users edit inside the users DB.


## Database Schema 
![screenshot](/Assets/CodeTalkDB.jpg)
?