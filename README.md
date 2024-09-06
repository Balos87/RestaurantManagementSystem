----------------------------
# RestaurantManagementSystem
----------------------------

This is a project that was made for a school assignment.
Its purpose is to be able to manage a restaurant with its:
- Customers
- Bookings
- Tables
- Menus
- Dishes

You are able to do CRUD-Operations on all the
above.

Here is a detailed diagram of the database.
------------------------------------------------------------------
![ER-Diagram-RestaurantManagementSystem](https://github.com/user-attachments/assets/1137b662-f772-4fff-8ac5-1a70a5f4477f)

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

