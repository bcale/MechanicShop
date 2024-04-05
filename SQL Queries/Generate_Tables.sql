USE MechanicShop;

CREATE TABLE customers (
    customer_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_Fname NVARCHAR(50) NOT NULL,
    customer_Lname NVARCHAR(50) NOT NULL,
    customer_phone NVARCHAR(10) NOT NULL,
    customer_city NVARCHAR(50) NOT NULL,
    customer_street NVARCHAR(50) NOT NULL,
    customer_apartment_number char(5),
    customer_state NVARCHAR(2) NOT NULL,
    customer_zip NVARCHAR(5) NOT NULL,
    customer_email NVARCHAR(50) NOT NULL, 
);

CREATE TABLE vehicles (
    vehicle_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT NOT NULL,
    vehicle_model NVARCHAR(50) NOT NULL,
    vehicle_trim NVARCHAR(50) NOT NULL,
    vehicle_year NVARCHAR(4) NOT NULL,
    vehicle_license_plate NVARCHAR(7) NOT NULL,
    vehicle_color NVARCHAR(50) NOT NULL,
    vehicle_vin NVARCHAR(50) NOT NULL,
    vehicle_make NVARCHAR(50) NOT NULL,
    CONSTRAINT fk_vehicles_customer_id FOREIGN KEY (customer_id) REFERENCES customers(customer_id)
);

CREATE TABLE technician_rank (
    technician_rank_id INT IDENTITY(1,1) PRIMARY KEY,
    technician_rank NVARCHAR(10) NOT NULL,
    rank_value FLOAT NOT NULL
);

CREATE TABLE technicians (
    technician_id INT IDENTITY(1,1) PRIMARY KEY,
    technician_Fname NVARCHAR(50) NOT NULL,
    technician_Lname NVARCHAR(50) NOT NULL,
    technician_rank_id INT NOT NULL,
    CONSTRAINT fk_technicians_technician_rank FOREIGN KEY (technician_rank_id) REFERENCES technician_rank(technician_rank_id)
);

CREATE TABLE services (
    service_id INT IDENTITY(1,1) PRIMARY KEY,
    service_name NVARCHAR(50) NOT NULL,
    service_description NVARCHAR(100) NOT NULL,
    service_cost FLOAT NOT NULL,
    required_technician_rank_id INT NOT NULL,
    CONSTRAINT fk_services_technician_rank_id FOREIGN KEY (required_technician_rank_id) REFERENCES technician_rank(technician_rank_id)
);

CREATE TABLE service_history (
    service_record_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT NOT NULL,
    vehicle_id INT NOT NULL,
    service_id INT NOT NULL,
    technician_id INT NOT NULL,
    service_record_date date NULL,
    service_record_time time(7) NOT NULL,
    service_record_status BIT NOT NULL,
    CONSTRAINT fk_service_history_customers_id FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
    CONSTRAINT fk_service_history_vehicles_id FOREIGN KEY (vehicle_id) REFERENCES vehicles(vehicle_id),
    CONSTRAINT fk_service_history_services_id FOREIGN KEY (service_id) REFERENCES services(service_id),
    CONSTRAINT fk_service_history_technicians_id FOREIGN KEY (technician_id) REFERENCES technicians(technician_id)
);
