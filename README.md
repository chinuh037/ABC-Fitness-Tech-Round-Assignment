# ABC Fitness Tech Round Assignment

This repository contains the API solution for managing fitness club class bookings. It includes RESTful APIs for creating classes, booking classes, and searching bookings.

## Table of Contents
1. [Overview](#overview)
2. [API Endpoints](#api-endpoints)
   - [Create a Class](#create-a-class)
   - [Create a Booking](#create-a-booking)
   - [Search Bookings](#search-bookings)
3. [Setup and Usage](#setup-and-usage)
4. [Testing APIs](#testing-apis)

## Overview
The system allows fitness club owners and members to interact with the following functionalities:

- **Create a Class**: Club owners can create classes with the details such as name, duration, capacity, etc.
- **Create a Booking**: Members can book classes by providing their name, the class name, and participation date.
- **Search Bookings**: Club owners can search bookings based on member names and date ranges.

The solution is built using C# and follows RESTful API principles.

---

## API Endpoints

### **1. Create a Class**
- **Endpoint**: `POST /api/classes/create`
- **Description**: This API allows the creation of a new class. A class contains information about its name, duration, start time, end time, and capacity.
  
#### Request Body:
```json
{
    "name": "Pilates",
    "startDate": "2025-12-01",
    "endDate": "2025-12-20",
    "startTime": "14:00",
    "duration": "1 hour",
    "capacity": 10
}
```

#### Response:
```json
{
    "message": "Class 'Pilates' has been created successfully."
}
```

### **2. Create a Booking**
- **Endpoint**: `POST /api/booking/create`
- **Description**: This API allows a member to book a class. It requires the member's name, class name, and participation date.

#### Request Body:
```json
{
    "memberName": "John Doe",
    "className": "Pilates",
    "participationDate": "2025-12-05"
}
```

#### Response:
```json
{
    "message": "Booking successful for 'Pilates' on 2025-12-05."
}
```

#### Error Response (If the class is at capacity):
```json
{
    "error": "Booking failed. Class 'Pilates' has reached its capacity."
}
```

### **3. Search Bookings**
- **Endpoint**: `POST /api/booking/search`
- **Description**: This API allows the club owner to search bookings by member or date range.

#### Query Parameters:
- **member** (Optional): `POST /api/booking/search`
- **startDate** (Optional): This API allows the club owner to search bookings by member or date range.
- **endDate** (Optional): This API allows the club owner to search bookings by member or date range.

#### Example Request:
```bash
GET /api/bookings?member=John Doe&startDate=2025-12-01&endDate=2025-12-20
```

#### Responses:
```json
[
    {
        "className": "Pilates",
        "classStartTime": "14:00",
        "bookingDate": "2025-12-05",
        "member": "John Doe"
    }
]
```