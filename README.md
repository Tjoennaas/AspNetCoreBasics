
Project in progress, this project is an easy aspnet This project is a simple ASP.NET Core Web API created to practice basic endpoint design, CRUD operations, and error handling.



 Create a new ASP.NET Core Web API project.

2 Add the following endpoints:

GET /ping → returns { "message": "pong" }

GET /time → returns the current date and time

//-----------------------------------------//

Extend the API with a Message resource

POST /api/messages → receives a message (text) and stores it in memory. Return 201 Created

GET /api/messages → returns all stored messages

DELETE /api/messages/{id} → deletes a message by ID

Return 200 OK when the operation succeeds.
Return 404 Not Found if a message with the given ID doesn’t exist.
