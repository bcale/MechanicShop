# MechanicShop

## Database Structure 
- DB Name: MechanicShop
  
| customers                 | vehicles               | service_history               | technicians                | services                     | technician_rank          |
| ----------- | ----------- | ----------- | ----------- | ----------- | -----------  |
| customer_id int           | customer_id int        | service_record_id FK          | technician_id int          | service_id int               | technician_rank_id int   |
| customer_Fname char(50)   | vehicle_model char(50) | customer_id FK                | technician_Fname char(50)  | service_name char(50)        | technician_rank char(10) |
| customer_Lname char(50)   | vehicle_trim char(50)  | vehicle_id FK                 | technician_Lname char(50)  | service_description char(50) | rank_value float         | 
| customer_phone int        | vehicle_year int       | service_id FK                 | technician_rank_id FK      | service_cost float
| customer_city char(50)    | vehicle_license_plate char(7)  | technician_id FK      |                            | technician_rank_id FK
| customer_street char(50)  | vehicle_color char(50) | service_record_date char(10)  |
| customer_apartment_number | vehicle_vin char(50)   | service_record_time int       |
| customer_state char(2)    | vehicle_make char(50)  | service_record_status boolean |
| customer_zip int          |                        |                               |
| customer_email char(50)   |                        |                               |


### Visual Studio
