----------------------------
# RestaurantManagementSystem
----------------------------
## Developed with Code-First, SOC and dependency-injection in the design.

### This is a backend-project that was made for a school assignment.
### Its purpose is to be able to manage and do CRUD-operations for a restaurant with its:
- Customers
- Bookings
- Tables
- Menus
- Dishes

Please put your connection-string in the env file. There is an examplefile provided.

Here is a detailed diagram of the database.
------------------------------------------------------------------
![ER-Diagram-RestaurantManagementSystem](https://github.com/user-attachments/assets/1137b662-f772-4fff-8ac5-1a70a5f4477f)

------------------------------------------------------------------
------------------------------------------------------------------
------------------------------------------------------------------
# A detailed list of all the avaible responses and results.
------------------------------------------------------------------

# Booking 

        [Route("api/booking")]

        [HttpPost("create")]
        
1. **200 OK**  
   - The booking was successfully created.

2. **400 Bad Request**  
   - The request data is invalid (e.g., missing or incorrect fields).
   - The customer or table ID provided does not exist.

3. **409 Conflict**  
   - The table does not have enough seats for the guests.
   - There is an overlapping booking for the table at the requested time.

4. **500 Internal Server Error**  
   - An unexpected error occurred on the server.

---------
        [HttpGet("{bookingId}")]

1. **200 OK**  
   - The booking was found and successfully returned.
  
         {
          "customerId": 3,
          "firstName": "Jonny",
          "lastName": "Svensson",
          "reservationDateTime": "2024-09-06T07:56:24.071",
          "endDateTime": "2024-09-06T09:56:24.071",
          "tables": [
            {
              "tableId": 2,
              "tableNumber": 9,
              "seats": 2
            }
          ]
          }

2. **404 Not Found**  
   - No booking exists with the provided `bookingId`.

---------

        [HttpGet("bookings")]

1. **200 OK**  
   - All bookings were successfully retrieved and returned.

          [
            {
              "bookingId": 2,
              "customerId": 3,
              "firstName": "Jonny",
              "lastName": "Svensson",
              "reservationDateTime": "2024-09-06T07:56:24.071",
              "endDateTime": "2024-09-06T09:56:24.071",
              "tables": [
                {
                  "tableId": 2,
                  "tableNumber": 9,
                  "seats": 2
                }
              ]
            },
            {
              "bookingId": 3,
              "customerId": 1,
              "firstName": "Frank",
              "lastName": "Leo",
              "reservationDateTime": "2024-09-08T09:50:41.209",
              "endDateTime": "2024-09-08T11:50:41.209",
              "tables": [
                {
                  "tableId": 2,
                  "tableNumber": 9,
                  "seats": 2
                }
              ]
            }
          ]
  
---------

        [HttpGet("by-date/{date}")]

1. **200 OK**  
   - Bookings for the specified date were successfully retrieved and returned.
  
          [
            {
              "bookingId": 2,
              "customerId": 3,
              "firstName": "Jonny",
              "lastName": "Svensson",
              "reservationDateTime": "2024-09-06T07:56:24.071",
              "endDateTime": "2024-09-06T09:56:24.071",
              "tables": [
                {
                  "tableId": 2,
                  "tableNumber": 9,
                  "seats": 2
                }
              ]
            }
          ]

2. **404 Not Found**  
   - No bookings were found for the specified date.

---------

        [HttpPut("update/{bookingId}")]

1. **200 OK**  
   - The booking was successfully updated.

2. **400 Bad Request**  
   - The request data is invalid (e.g., missing or incorrect fields).

3. **404 Not Found**  
   - The booking or table with the specified ID was not found.

4. **409 Conflict**  
   - There is an overlapping booking at the requested time.
   - The selected table does not have enough seats for the number of guests.

5. **500 Internal Server Error**  
   - An unexpected error occurred on the server.

---------

        [HttpDelete("delete/{bookingId}")]

1. **204 No Content**  
   - The booking was successfully deleted.

2. **404 Not Found**  
   - No booking with the specified `bookingId` was found.


----------------------------------

# Customer
    [Route("api/customer")]

        [HttpPost("create")]
1. **200 OK**  
   - The customer profile was successfully created.

2. **400 Bad Request**  
   - The request data is invalid (e.g., missing or incorrect fields).
   - An argument exception occurred, such as invalid input data.

3. **500 Internal Server Error**  
   - An unexpected error occurred while saving the customer profile.

---------

        [HttpGet("{customerId}")]

1. **200 OK**  
   - The customer profile was successfully retrieved and returned.
                
                {
                  "firstName": "Frank",
                  "lastName": "Leo",
                  "email": "Frank.Leo@gmail.com",
                  "phoneNumber": "1234567890"
                }

2. **404 Not Found**  
   - No customer was found with the specified `customerId`.

3. **500 Internal Server Error**  
   - An unexpected error occurred while retrieving the customer profile.

---------

        [HttpGet]
        [Route("customers")]

1. **200 OK**  
   - All customer profiles were successfully retrieved and returned.
  
                [
                  {
                    "customerId": 1,
                    "firstName": "Frank",
                    "lastName": "Leo",
                    "email": "Frank.Leo@gmail.com",
                    "phoneNumber": "1234567890"
                  },
                  {
                    "customerId": 3,
                    "firstName": "Jonny",
                    "lastName": "Svensson",
                    "email": "jonnys-email@example.com",
                    "phoneNumber": "+46702222222"
                  }
                ]

2. **404 Not Found**  
   - No customer profiles were found in the database.

3. **500 Internal Server Error**  
   - An unexpected error occurred while retrieving the customer profiles.
  

---------

        [HttpPut("update/{customerId}")]

1. **204 No Content**  
   - The customer profile was successfully updated.

2. **400 Bad Request**  
   - The request data is invalid (e.g., missing or incorrect fields).
   - An argument exception occurred, such as invalid input data.

3. **404 Not Found**  
   - No customer was found with the specified `customerId`.

4. **500 Internal Server Error**  
   - An unexpected error occurred during the update operation.

---------

        [HttpDelete("delete/{customerId}")]

1. **204 No Content**  
   - The customer profile was successfully deleted.

2. **400 Bad Request**  
   - The request data is invalid (e.g., missing or incorrect fields).
   - An argument exception occurred, such as a mismatch in the provided email.

3. **404 Not Found**  
   - No customer was found with the specified `customerId` and matching email.

4. **500 Internal Server Error**  
   - An unexpected error occurred during the deletion operation.

---------
# Customer
    [Route("api/table")]
----------

        [HttpPost]
        [Route("create")]

1. **204 No Content**  
   - The table was successfully created.

2. **400 Bad Request**  
   - The request data is invalid (e.g., missing or incorrect fields).

3. **500 Internal Server Error**  
   - An unexpected error occurred while creating the table.

---------

        [HttpGet]
        [Route("{tableId}")]

1. **200 OK**  
   - The table information was successfully retrieved and returned.

                {
                  "tableId": 1,
                  "tableNumber": 1,
                  "seats": 8
                }

2. **404 Not Found**  
   - No table with the specified `tableId` was found.

3. **500 Internal Server Error**  
   - An unexpected error occurred while retrieving the table information.

---------

        [HttpGet]
        [Route("tables")]

1. **200 OK**  
   - All tables were successfully retrieved and returned.

                [
                  {
                    "tableId": 1,
                    "tableNumber": 1,
                    "seats": 8
                  },
                  {
                    "tableId": 2,
                    "tableNumber": 9,
                    "seats": 2
                  }
                ]

2. **404 Not Found**  
   - No tables were found in the database.

3. **500 Internal Server Error**  
   - An unexpected error occurred while retrieving the tables.

---------

        [HttpPut("update/{tableId}")]

1. **204 No Content**  
   - The table was successfully updated.

2. **400 Bad Request**  
   - The request data is invalid (e.g., missing or incorrect fields).

3. **404 Not Found**  
   - No table with the specified `tableId` was found.

4. **500 Internal Server Error**  
   - An unexpected error occurred while updating the table.

---------

        [HttpDelete("delete/{tableId}")]

1. **204 No Content**  
   - The table was successfully deleted.

2. **400 Bad Request**  
   - The request data is invalid (e.g., missing or incorrect fields).

3. **404 Not Found**  
   - No table with the specified `tableId` and matching table number was found.

4. **500 Internal Server Error**  
   - An unexpected error occurred while deleting the table.
  
---------
# Menus
    [Route("api/menu")]
---------

        [HttpPost("create")]

1. **200 OK**  
   - The menu was successfully created.

2. **400 Bad Request**  
   - The request data is invalid (e.g., missing or incorrect fields).

3. **500 Internal Server Error**  
   - An unexpected error occurred while creating the menu.

---------

        [HttpGet("{menuId}")]

1. **200 OK**  
   - The menu details were successfully retrieved and returned.

                {
                  "menuName": "TuesdayMenu",
                  "dishes": []
                }

2. **404 Not Found**  
   - No menu with the specified `menuId` was found.

3. **500 Internal Server Error**  
   - An unexpected error occurred while retrieving the menu details.

---------

        [HttpGet]
        [Route("menus")]

1. **200 OK**  
   - All menus were successfully retrieved and returned.

                [
                  {
                    "menuId": 2,
                    "menuName": "TuesdayMenu",
                    "dishes": []
                  },
                  {
                    "menuId": 3,
                    "menuName": "MondayMenu",
                    "dishes": []
                  }
                ]

2. **500 Internal Server Error**  
   - An unexpected error occurred while retrieving the list of menus.

---------

        [HttpPut("update/{menuId}")]

1. **204 No Content**  
   - The menu was successfully updated.

2. **400 Bad Request**  
   - The request data is invalid (e.g., missing or incorrect fields).

3. **404 Not Found**  
   - No menu with the specified `menuId` was found.

4. **500 Internal Server Error**  
   - An unexpected error occurred while updating the menu.

---------

        [HttpDelete("delete/{menuId}")]

1. **204 No Content**  
   - The menu was successfully deleted.

2. **400 Bad Request**  
   - The request data is invalid (e.g., missing or incorrect fields).

3. **404 Not Found**  
   - No menu with the specified `menuId` and matching `menuName` was found.

4. **500 Internal Server Error**  
   - An unexpected error occurred while deleting the menu.
  
---------
# Dishes
    [Route("api/dish")]
---------

        [HttpPost("create")]

1. **200 OK**  
   - The dish was successfully created.

2. **400 Bad Request**  
   - The request data is invalid (e.g., missing or incorrect fields).

3. **500 Internal Server Error**  
   - An unexpected error occurred while creating the dish.

---------

        [HttpGet]
        [Route("{dishId}")]

1. **200 OK**  
   - The dish was successfully retrieved and returned.

                {
                  "dishName": "Pizza Kebab Special",
                  "description": "pizza med kebab och sallad med sås",
                  "price": 180,
                  "isAvailable": true,
                  "menu": null
                }

2. **404 Not Found**  
   - No dish with the specified `dishId` was found.

3. **500 Internal Server Error**  
   - An unexpected error occurred while retrieving the dish details.

---------

        [HttpGet]
        [Route("dishes")]

1. **200 OK**  
   - All dishes were successfully retrieved and returned.

                [
                  {
                    "dishId": 2,
                    "dishName": "Pizza Kebab Special",
                    "description": "pizza med kebab och sallad med sås",
                    "price": 180,
                    "isAvailable": true,
                    "menu": null
                  },
                  {
                    "dishId": 3,
                    "dishName": "Lax och Sparris",
                    "description": "Lax med sparris och citronsås",
                    "price": 200,
                    "isAvailable": true,
                    "menu": null
                  }
                ]

2. **500 Internal Server Error**  
   - An unexpected error occurred while retrieving the list of dishes.

---------

        [HttpPut("link-to-menu/{dishId}/{menuId}")]

1. **204 No Content**  
   - The dish was successfully linked to the menu.

2. **400 Bad Request**  
   - The request is invalid (e.g., the dish or menu ID is incorrect).

3. **500 Internal Server Error**  
   - An unexpected error occurred while linking the dish to the menu.

---------

        [HttpPut("unlink-from-menu/{dishId}")]

1. **204 No Content**  
   - The dish was successfully unlinked from the menu.

2. **400 Bad Request**  
   - The request is invalid (e.g., the dish ID is incorrect).

3. **500 Internal Server Error**  
   - An unexpected error occurred while unlinking the dish from the menu.

---------

        [HttpPut("update/{dishId}")]

1. **204 No Content**  
   - The dish was successfully updated.

2. **400 Bad Request**  
   - The request data is invalid (e.g., missing or incorrect fields).

3. **404 Not Found**  
   - No dish with the specified `dishId` was found.

4. **500 Internal Server Error**  
   - An unexpected error occurred while updating the dish.

---------

        [HttpDelete("delete/{dishId}")]

1. **204 No Content**  
   - The dish was successfully deleted.

2. **400 Bad Request**  
   - The request data is invalid (e.g., missing or incorrect fields).

3. **404 Not Found**  
   - No dish with the specified `dishId` and matching `dishName` was found.

4. **500 Internal Server Error**  
   - An unexpected error occurred while deleting the dish.
---------
---------
## If you have any questions, please ask away! :)
