 --Additional data required for Part 2 presentation
 --Newly hired technicians (lunch money)
  INSERT INTO technicians (technician_Fname, technician_Lname, technician_rank_id)
  VALUES ( 'Joe', 'Smith', 3),
		 ('Charlie','Cole',3);

--Another service we will need
   INSERT INTO services( service_name, service_description, service_cost, required_technician_rank_id)
   VALUES ('Replace Brake Line', 'Insert new brake line, roast a chicken with potatoes.',100000,2);
   --New appointments
   INSERT INTO service_history (customer_id, vehicle_id, service_id, technician_id, service_record_date, service_record_time, service_record_status)
   VALUES (1,2,1,1, '2024-05-03','14:00:00', 0),
		  (1,2,3,1,'2024-05-03','14:00:00', 0),
		  (1,2,5,1,'2024-05-03','14:00:00', 0),
		  (1,2,2,2,'2024-05-03','14:00:00', 0),
		  (1,2,4,2,'2024-05-03','14:00:00', 0),
		  (3,4,1,1,'2024-05-04','11:00:00',0),
		  (3,4,3,1,'2024-05-04','11:00:00',0),
		  (3,4,5,4,'2024-05-04','11:00:00',0);
		  


