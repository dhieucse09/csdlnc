DROP TABLE CONSUMES_t 			CASCADE CONSTRAINTS ;
DROP TABLE ITEM_t			CASCADE CONSTRAINTS ;
DROP TABLE Laboratory_Assignment_t 	CASCADE CONSTRAINTS ;
DROP TABLE Assignment_t 		CASCADE CONSTRAINTS ;
DROP TABLE PERFORMS_t 			CASCADE CONSTRAINTS ;
DROP TABLE TECHNICIAN_t 		CASCADE CONSTRAINTS ;
DROP TABLE VOLUNTEER_t 			CASCADE CONSTRAINTS ;
DROP TABLE STAFF_t 			CASCADE CONSTRAINTS ;
DROP TABLE RESIDENT_t			CASCADE CONSTRAINTS ;
DROP TABLE OUTPATIENT_t 		CASCADE CONSTRAINTS ;
DROP TABLE PATIENT_t 			CASCADE CONSTRAINTS ;
DROP TABLE PHYSICIAN_t 			CASCADE CONSTRAINTS ;
DROP TABLE NURSE_t 			CASCADE CONSTRAINTS ;
DROP TABLE EMPLOYEE_t 			CASCADE CONSTRAINTS ;
DROP TABLE TREATMENT_t 			CASCADE CONSTRAINTS ;
DROP TABLE LABORATORY_t 		CASCADE CONSTRAINTS ;
DROP TABLE BED_t 			CASCADE CONSTRAINTS ;
DROP TABLE LOCATION_t 			CASCADE CONSTRAINTS ;
DROP TABLE CARE_CENTER_t 		CASCADE CONSTRAINTS ;
DROP TABLE PERSON_t 			CASCADE CONSTRAINTS ;
DROP TABLE Treatment_Item_t             CASCADE CONSTRAINTS ; 



CREATE TABLE PERSON_t
             (Person_ID       	  NUMBER           NOT NULL UNIQUE,
	      Date_Entered        DATE           ,
	      Person_First_Name   VARCHAR(50)    ,
              Person_Last_Name    VARCHAR(50)    ,
              Person_Address      VARCHAR(40)    ,           
              Person_City         VARCHAR(50)    ,
              Person_Phone        VARCHAR(50)    ,
              Person_State        VARCHAR(2)     ,
              Person_Zip          VARCHAR(12)    ,
	      Person_BirthDate    DATE           ,
CONSTRAINT PERSON_PK PRIMARY KEY (Person_ID));

CREATE TABLE PHYSICIAN_t
             (Physician_ID        VARCHAR(20)    NOT NULL UNIQUE,
              Person_ID           NUMBER          ,
              Specialty           VARCHAR(50)    ,
	      Pager#              VARCHAR(50)    ,
CONSTRAINT PHYSICIAN_PK PRIMARY KEY (Physician_ID),
CONSTRAINT PHYSICIAN_FK1 FOREIGN KEY (Person_ID) REFERENCES PERSON_t(Person_ID));

CREATE TABLE EMPLOYEE_t
             (Employee_ID         NUMBER           NOT NULL UNIQUE,
	      Date_Hired          DATE           , 
              Employee_Type        VARCHAR(50)    ,
CONSTRAINT EMPLOYEE_PK PRIMARY KEY (Employee_ID),
CONSTRAINT EMPLOYEE_FK1 FOREIGN KEY (Employee_ID) REFERENCES PERSON_t(Person_ID));

CREATE TABLE PATIENT_t
             (Patient_ID          NUMBER          NOT NULL,
	      Admission_Type      VARCHAR(10)     ,
              Contact_Date        DATE           ,
              Contact_Time        DATE           ,
              Person_ID           NUMBER         ,
              Physician_ID        VARCHAR(20)    ,
              Referral_ID         VARCHAR(20)    , 
CONSTRAINT PATIENT_PK PRIMARY KEY (Patient_ID)   ,
CONSTRAINT PATIENT_FK1 FOREIGN KEY (Person_ID) REFERENCES PERSON_t(Person_ID),
CONSTRAINT PATIENT_FK2 FOREIGN KEY (Physician_ID) REFERENCES PHYSICIAN_t(Physician_ID),
CONSTRAINT PATIENT_FK3 FOREIGN KEY (Referral_ID) REFERENCES PHYSICIAN_t(Physician_ID));

CREATE TABLE CARE_CENTER_t
             (CareCenter_ID       VARCHAR(10)    NOT NULL,
              CareCenter_Location VARCHAR(50)    ,
              CareCenter_name     VARCHAR(50)    ,
              CareCenter_Type     VARCHAR(50)    ,
              In_Charge           NUMBER         ,
CONSTRAINT CARE_CENTER_PK PRIMARY KEY (CareCenter_ID));


CREATE TABLE NURSE_t
             (Employee_ID         NUMBER         NOT NULL,
	      CareCenter_id       VARCHAR(10)    NOT NULL,
              Certificate         VARCHAR(25)    NOT NULL,              
CONSTRAINT NURSE_PK PRIMARY KEY (Employee_ID, Certificate, CareCenter_id),
CONSTRAINT NURSE_FK1 FOREIGN KEY (CareCenter_id) REFERENCES CARE_CENTER_t(CareCenter_id),
CONSTRAINT NURSE_FK2 FOREIGN KEY (Employee_ID) REFERENCES EMPLOYEE_t(Employee_ID));


CREATE TABLE BED_t
             (Bed_ID              VARCHAR(12)    NOT NULL UNIQUE,
              CareCenter_ID       VARCHAR(10),     
              Room_ID             number     ,  
CONSTRAINT BED_PK PRIMARY KEY (Bed_ID),
CONSTRAINT BED_FK1 FOREIGN KEY (CareCenter_ID) REFERENCES CARE_CENTER_t(CareCenter_ID));



CREATE TABLE Assignment_t
             (CareCenter_ID       VARCHAR(10)    NOT NULL,
              Employee_ID         NUMBER         NOT NULL,
              Hours               INTEGER        ,
              Week                INTEGER        NOT NULL,
              Year                NUMBER         NOT NULL,
CONSTRAINT Assignment_PK PRIMARY KEY (CareCenter_ID, Employee_ID, Year, Week),
CONSTRAINT Assignment_FK1 FOREIGN KEY (CareCenter_ID) REFERENCES CARE_CENTER_t(CareCenter_ID));


CREATE TABLE OUTPATIENT_t
             (Patient_ID          NUMBER         NOT NULL,
              Visit_Date          DATE           NOT NULL,
	      Comments            VARCHAR(250)   ,
CONSTRAINT OUTPATIENT_PK PRIMARY KEY (Patient_ID, Visit_Date),
CONSTRAINT OUTPATIENT_FK1 FOREIGN KEY (Patient_ID) REFERENCES PATIENT_t(Patient_ID));


CREATE TABLE RESIDENT_t
             (Patient_ID          NUMBER         NOT NULL,
	      Bed_ID              VARCHAR(12)    NOT NULL,
              Date_Admitted       DATE           NOT NULL,              
CONSTRAINT RESIDENT_PK PRIMARY KEY (Patient_ID, Date_Admitted, Bed_ID),
CONSTRAINT RESIDENT_FK1 FOREIGN KEY (Bed_ID) REFERENCES BED_t(Bed_ID),
CONSTRAINT RESIDENT_FK2 FOREIGN KEY (Patient_ID) REFERENCES PATIENT_t(Patient_ID));


CREATE TABLE STAFF_t
             (Employee_ID         NUMBER         NOT NULL,
              Job_Class           VARCHAR(25),
CONSTRAINT STAFF_PK PRIMARY KEY (Employee_ID),
CONSTRAINT STAFF_FK1 FOREIGN KEY (Employee_ID) REFERENCES EMPLOYEE_t(Employee_ID));

CREATE TABLE VOLUNTEER_t
             (Volunteer_id        NUMBER          NOT NULL,
	      Skill               VARCHAR(25),              
CONSTRAINT VOLUNTEER_PK PRIMARY KEY (Volunteer_id),
CONSTRAINT VOLUNTEER_FK1 FOREIGN KEY (Volunteer_id) REFERENCES PERSON_t(PERSON_id));

CREATE TABLE TECHNICIAN_t
             (Technician_ID         NUMBER          NOT NULL,
              Skill               VARCHAR(25)    ,
CONSTRAINT TECHNICIAN_PK PRIMARY KEY (Technician_ID),
CONSTRAINT TECHNICIAN_FK1 FOREIGN KEY (Technician_ID) REFERENCES EMPLOYEE_t(Employee_ID));

CREATE TABLE TREATMENT_t
             (Treatment_ID        NUMBER           NOT NULL,
              Treatment_Name      VARCHAR(50)    ,
CONSTRAINT TREATMENT_PK PRIMARY KEY (Treatment_ID));


CREATE TABLE PERFORMS_t
             (Patient_id          NUMBER         ,
              Physician_ID        VARCHAR(20)    ,
              Results             VARCHAR(250)   ,
              Treatment_Date      DATE           ,
              Treatment_ID        NUMBER         ,
              Treatment_Time      DATE           ,
CONSTRAINT PERFORMS_FK1 FOREIGN KEY (Patient_id) REFERENCES PATIENT_t(Patient_id),
CONSTRAINT PERFORMS_FK2 FOREIGN KEY (Treatment_ID) REFERENCES TREATMENT_t(Treatment_ID),
CONSTRAINT PERFORMS_FK3 FOREIGN KEY (Physician_ID) REFERENCES PHYSICIAN_t(Physician_ID));

CREATE TABLE LABORATORY_t
             (Laboratory_Id       VARCHAR(50)    NOT NULL,
              Laboratory_Location VARCHAR(50)    NOT NULL,
CONSTRAINT LABORATORY_PK PRIMARY KEY (Laboratory_Id, Laboratory_Location));

CREATE TABLE Laboratory_Assignment_t
             (Laboratory_Id       VARCHAR(50)    NOT NULL,
              Technician_Id       NUMBER         NOT NULL,
CONSTRAINT Laboratory_Assignment_PK PRIMARY KEY (Laboratory_Id, Technician_Id),
CONSTRAINT Laboratory_Assignment_FK1 FOREIGN KEY (Technician_Id) REFERENCES TECHNICIAN_t(Technician_Id));

CREATE TABLE ITEM_t
              (Item_ID            NUMBER           NOT NULL,
     	      Item_cost           NUMBER,
              Item_Description    VARCHAR(125)   ,
CONSTRAINT ITEM_PK PRIMARY KEY (Item_ID));

CREATE TABLE CONSUMES_t
             (Date_Received       DATE           NOT NULL,
              Item_ID             number         NOT NULL,
              Patient_ID          Number         NOT NULL,
              Quantity            INTEGER        ,
              Time_Received       DATE           NOT NULL,
CONSTRAINT CONSUMES_PK PRIMARY KEY (Item_ID, Patient_ID, Date_Received, Time_Received),
CONSTRAINT CONSUMES_FK1 FOREIGN KEY (Item_ID) REFERENCES ITEM_t(Item_ID),
CONSTRAINT CONSUMES_FK2 FOREIGN KEY (Patient_ID) REFERENCES PATIENT_t(Patient_ID));

CREATE TABLE Treatment_Item_t
              (Treatment_ID       number         NOT NULL,
               Item_ID            number         NOT NULL.
CONSTRAINT Treatment_Item_PK PRIMARY KEY (Treatment_ID, Item_ID),
CONSTRAINT Treatment_Item_FK1 FOREIGN KEY (Treatment_ID) REFERENCES TREATMENT_t(Treatment_id),
CONSTRAINT Treatment_Item_FK2 FOREIGN KEY (Item_ID) REFERENCES ITEM_t(Item_ID)); 

CREATE TABLE LOCATION_t
               (Location_ID       number         NOT NULL,
                Location          varchar(40)    NOT NULL);


delete from CONSUMES_t;
delete from PERFORMS_t;
delete from Assignment_t;
delete from Laboratory_Assignment_t;
delete from STAFF_t;
delete from NURSE_t;
delete from RESIDENT_t;
delete from OUTPATIENT_t;
delete from PATIENT_t;
delete from PHYSICIAN_t;
delete from EMPLOYEE_t;
delete from PERSON_t;
delete from BED_t;
delete from CARE_CENTER_t;
delete from ITEM_t;
delete from LOCATION_t;
delete from LABORATORY_t;
delete from TECHNICIAN_t;
delete from TREATMENT_t;
delete from VOLUNTEER_t;
delete from Treatment_Item_t;

INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (1, 'Larreau', 'Anette', '127 Sandhill', 'Grant', 'CO', '80448-1045', '', '25/Jan/42', '28/Mar/01');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (2, 'Dolan', 'Mark', '818 River Run', 'Conifer', 'CO', '80433-2672', '', '13/May/62', '28/Mar/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (3, 'Wiggins', 'Brian', '431 Walnut', 'Sheridan', 'CO', '80110-6598', '', '03/Jul/72', '28/Mar/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (4, 'Thomas', 'Wendell', '928 Logan', 'Evergreen', 'CO', '80437-0862', '', '14/Feb/85', '28/Mar/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (5, 'Dimas', 'Salena', '617 Valley Vista', 'Sheridan', 'CO', '80110-4672', '', '15/Mar/47', '29/Mar/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (6, 'Smith', 'Terri', '5566 Point Loma Drive', 'Lakewood', 'CO', '80033-2859', '', '18/Jul/55', '30/Mar/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (7, 'Moxly', 'Larry', '3421 Hillcrest Ave', 'Evergreen', 'CO', '80439-3740', '', '15/Aug/63', '30/Mar/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (8, 'Jones', 'Jim', '1432 Tied Knot Rd', 'Evergreen', 'CO', '80439-4950', '', '31/Aug/58', '30/Mar/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (9, 'Bailey', 'Chris', '6749 Clifton Rd', 'Lakewood', 'CO', '80033-3905', '', '16/Jan/94', '31/Mar/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (10, 'Sprangler', 'Robert', '2929 Lipton Lane', 'Evergreen', 'CO', '80437-1747', '', '05/Feb/80', '15/May/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (11, 'Bronson', 'Chuck', '343 Knuckels Street', 'Lakewood', 'CO', '80214-9674', '', '30/Apr/74', '15/May/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (12, 'Freeman', 'Rita', '634 Valley Vista', 'Evergreen', 'CO', '80439-5329', '', '26/Aug/67', '22/May/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (13, 'Grost', 'Anita', '1900 Smith Ave', 'Sheridan', 'CO', '80110-7510', '', '25/Nov/81', '22/Apr/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (14, 'Danger', 'Joanne', '101 Hazard Rd', 'Lakewood', 'CO', '80215-5531', '', '24/Jan/72', '17/Jun/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (15, 'Nickolsen', 'Steven', '3234 Garrison Rd', 'Evergreen', 'CO', '80439-6042', '', '08/Jun/78', '17/Jun/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (17, 'Yun', 'Joy', '8734 Fluffy Lane', 'Conifer', 'CO', '80433-2680', '', '18/May/52', '06/Jul/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (18, 'Hamilton', 'Ralph', '710 Lamp Post Lane', 'Conifer', 'CO', '80433-4256', '', '15/May/44', '06/Jul/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (19, 'Tyre', 'Nathanael', '4455 Adrian Court', 'Lakewood', 'CO', '80033-3322', '', '07/Jul/82', '13/Aug/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (20, 'Lawson', 'Cheryl', '1045 Marcum', 'Evergreen', 'CO', '80439-7693', '', '23/Apr/66', '13/Aug/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (21, 'Smith', 'Michelle', '813 Ranger Blvd.', 'Evergreen', 'CO', '80439-8260', '', '14/Feb/84', '29/Sep/04');
INSERT INTO PERSON_t  (Person_ID, Person_Last_Name, Person_First_Name, Person_Address, Person_City, Person_State, Person_Zip, Person_Phone, Person_BirthDate, Date_Entered)
VALUES  (22, 'McLendon', 'Darlene', '15337 Old Boulder Road', 'Sheridan', 'CO', '80110-8785', '', '29/Sep/77', '29/Sep/04');

INSERT INTO CARE_CENTER_t  (CareCenter_ID, CareCenter_name, CareCenter_Type, CareCenter_Location, In_Charge)
VALUES  ('AE', 'Emergency Care Center', 'Emergency', 'Complex 1', 1);
INSERT INTO CARE_CENTER_t  (CareCenter_ID, CareCenter_name, CareCenter_Type, CareCenter_Location, In_Charge)
VALUES  ('CA', 'Cardiology Care Center', 'Cardiology', 'Complex 3', 3);
INSERT INTO CARE_CENTER_t  (CareCenter_ID, CareCenter_name, CareCenter_Type, CareCenter_Location, In_Charge)
VALUES  ('CC', 'Cancer Care Center', 'Cancer', 'Complex 3', 12);
INSERT INTO CARE_CENTER_t  (CareCenter_ID, CareCenter_name, CareCenter_Type, CareCenter_Location, In_Charge)
VALUES  ('GC', 'General Care Center', 'General', 'Complex 2', 13);
INSERT INTO CARE_CENTER_t  (CareCenter_ID, CareCenter_name, CareCenter_Type, CareCenter_Location, In_Charge)
VALUES  ('MA', 'Maternity Care Center', 'Maternity', 'Complex 2', 5);
INSERT INTO CARE_CENTER_t  (CareCenter_ID, CareCenter_name, CareCenter_Type, CareCenter_Location, In_Charge)
VALUES  ('SG', 'Surgery Care center', 'Surgeon', 'Complex 2', 6);
delete from CONSUMES_t;

INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (501, 'Inflatable Air Splint Leg 32"', 12);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (502, 'Inflatable Air Splint Leg 25"', 11);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (503, 'Inflatable Air Splint Arm 32"', 9);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (504, 'Inflatable Air Splint Arm 25"', 8);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (505, 'Inflatable Air Splint Hand and Wrist', 9);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (506, 'Inflatable Air Splint Ankle and Foot', 9);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (507, 'Cast Boot Large', 19);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (508, 'Cast Boot Small', 18);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (509, 'Stifneck Collar', 30);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (600, 'Ultrasound Lotion', 1.25);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (601, 'UltraSound Gel', 1);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (602, 'Ammonia Inhalant', 3);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (604, 'Burn Relief Spray', 12);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (605, 'Burn sheets 60"x96"', 8);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (606, 'Oxygen face Mask w/valve', 27);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (607, 'Micro face Mask', 6);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (608, 'Eyewash Bottle', 8);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (609, 'Sooth-A-Sting swab', 3);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (610, 'Insect Sting Wipe', 2.5);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (611, 'Poison Antidote Kit', 12);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (612, 'OB Kit', 6);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (613, 'Resuscitator Bag Mask Adult', 30);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (614, 'Resuscitator Bag Mask Child', 29);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (615, 'Tracheotomy Kit', 40);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (616, 'IV Sodium Clorine', 3);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (617, 'IV Sterile Water', 2);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (701, 'Chemical Strips #135 Luc.,Gluc.,Prot,Bld', 1);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (702, 'Chemical Strips #145 Luc.,Gluc.,Prot,Bld.,N, Urin.', 1.5);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (703, 'LabStix-urinary blood, ketones, glucose, protein and pH', 1.25);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (704, 'Multi Stix-pH, protein, glucose, ketones, bilirubin, blood and urobilinogen in urine', 2);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (705, 'Multi Stix glucose, bilirubin, ketones, specific gravity, glood, pH, protein, nitrate and leukocytes in urine', 3);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (706, 'Uristix', 1.5);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (801, 'Insta-Glucose tube 31 gram', 6);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (802, 'Insulin Syringe bx/100 monojet 29 gauge', 22);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (803, 'Insulin Syringe bx/100 monojet 27 gauge', 17);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (804, 'Insulin Travel Kit', 26);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (805, 'Lancets bx/100', 7);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (806, 'Diabetis Socks', 5);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (807, 'Diabetic Gloves', 7);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (901, 'Bed Pan diposable', 7);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (902, 'Bed Tray', 17);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (903, 'Emesis Basin Disposable', 1);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (904, 'Hair Comb', 3);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (905, 'Hair Brush', 5);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (906, 'Toothbrush', 3);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (907, 'Nail Clippers', 5);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (908, 'Sitz Bath Disposable', 7);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (909, 'Female Urinal Disposable', 6);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (910, 'Male Urinal Disposable', 2);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (911, 'Wash Basin Disposable', 2);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (912, 'Hand bulb syringe', 7);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (913, 'Wool Blanket', 24);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (914, 'Emergency Foam Blanket', 14);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (915, 'Bite Stick', 4);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (916, 'Tourniquet Velcro', 8);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (917, 'Tourniquet Latex Disposable', 2);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (918, 'Male Briefs Disposable', 1);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (919, 'Female Briefs Disposable', 1);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (920, 'Telephone', 20);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (921, 'Television', 20);
INSERT INTO ITEM_t  (ITEM_ID, Item_Description, Item_cost)
VALUES  (922, 'Computer', 20);

INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (1, '30/Jan/00', 'Nurse');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (2, '30/Jan/00', 'Staff');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (3, '27/Jan/01', 'Nurse');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (4, '30/Jan/01', 'Technician');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (5, '04/Feb/01', 'Nurse');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (6, '14/Feb/01', 'Nurse');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (7, '14/Feb/01', 'Nurse');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (8, '01/Feb/02', 'Technician');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (9, '03/Feb/02', 'Technician');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (10, '05/Feb/02', 'Technician');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (12, '02/Feb/02', 'Nurse');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (13, '15/Jan/03', 'Nurse');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (17, '18/May/03', 'Nurse');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (18, '30/MaY/03', 'Nurse');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (19, '15/Aug/03', 'Nurse');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (20, '15/Aug/03', 'Nurse');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (21, '04/Nov/03', 'Nurse');
INSERT INTO EMPLOYEE_t  (Employee_ID, Date_Hired, Employee_Type)
VALUES  (22, '05/Jan/04', 'Nurse');

INSERT INTO PHYSICIAN_t  (Physician_ID, Person_ID, Specialty, Pager#)
VALUES  ('9624', 7, 'Hematology', '8089995454');
INSERT INTO PHYSICIAN_t  (Physician_ID, Person_ID, Specialty, Pager#)
VALUES  ('9723', 8, 'General', '8089991212');
INSERT INTO PHYSICIAN_t  (Physician_ID, Person_ID, Specialty, Pager#)
VALUES  ('9801', 6, 'OB\GYN', '8089991524');
INSERT INTO PHYSICIAN_t  (Physician_ID, Person_ID, Specialty, Pager#)
VALUES  ('9945', 12, 'Exercise Physiologist', '8089992451');

INSERT INTO NURSE_t  (Employee_ID, Certificate, CareCenter_id)
VALUES  (1, 'RN', 'AE');
INSERT INTO NURSE_t  (Employee_ID, Certificate, CareCenter_id)
VALUES  (3, 'RN', 'CA');
INSERT INTO NURSE_t  (Employee_ID, Certificate, CareCenter_id)
VALUES  (5, 'RN', 'MA');
INSERT INTO NURSE_t  (Employee_ID, Certificate, CareCenter_id)
VALUES  (6, 'RN', 'SG');
INSERT INTO NURSE_t  (Employee_ID, Certificate, CareCenter_id)
VALUES  (7, 'LPN', 'GC');
INSERT INTO NURSE_t  (Employee_ID, Certificate, CareCenter_id)
VALUES  (12, 'RN', 'CC');
INSERT INTO NURSE_t  (Employee_ID, Certificate, CareCenter_id)
VALUES  (13, 'RN', 'GC');
INSERT INTO NURSE_t  (Employee_ID, Certificate, CareCenter_id)
VALUES  (18, 'LPN', 'AE');
INSERT INTO NURSE_t  (Employee_ID, Certificate, CareCenter_id)
VALUES  (19, 'LPN', 'CA');
INSERT INTO NURSE_t  (Employee_ID, Certificate, CareCenter_id)
VALUES  (20, 'RN', 'MA');
INSERT INTO NURSE_t  (Employee_ID, Certificate, CareCenter_id)
VALUES  (21, 'LPN', 'SG');
INSERT INTO NURSE_t  (Employee_ID, Certificate, CareCenter_id)
VALUES  (22, 'RN', 'CC');

INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('AE-100-1', 'AE', 100);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('AE-101-1', 'AE', 101);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('AE-102-1', 'AE', 102);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('AE-103-1', 'AE', 103);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-100-1', 'GC', 100);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-100-2', 'GC', 100);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-102-1', 'GC', 102);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-102-2', 'GC', 102);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-103-1', 'GC', 103);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-103-2', 'GC', 103);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-104-1', 'GC', 104);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-104-2', 'GC', 104);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-105-1', 'GC', 105);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-105-2', 'GC', 105);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-200-1', 'GC', 200);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-201-1', 'GC', 201);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-202-1', 'GC', 202);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-203-1', 'GC', 203);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-204-1', 'GC', 204);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('GC-205-1', 'GC', 205);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('MA-100-1', 'MA', 100);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('MA-101-1', 'MA', 101);
INSERT INTO BED_t  (Bed_ID, CareCenter_ID, Room_ID)
VALUES  ('MA-102-1', 'MA', 102);

INSERT INTO PATIENT_t  (Patient_ID, Person_ID, Physician_ID, Admission_Type, Contact_Date, Contact_Time, Referral_ID)
VALUES  (12, 11, '9723', 'Outpatient', '15/May/04', '30/Dec/99', '9945');
INSERT INTO PATIENT_t  (Patient_ID, Person_ID, Physician_ID, Admission_Type, Contact_Date, Contact_Time, Referral_ID)
VALUES  (13, 12, '9723', 'Outpatient', '22/May/04', '30/Dec/99', '9723');
INSERT INTO PATIENT_t  (Patient_ID, Person_ID, Physician_ID, Admission_Type, Contact_Date, Contact_Time, Referral_ID)
VALUES  (14, 13, '9801', 'Resident', '22/Apr/04', '30/Dec/99', '9945');
INSERT INTO PATIENT_t  (Patient_ID, Person_ID, Physician_ID, Admission_Type, Contact_Date, Contact_Time, Referral_ID)
VALUES  (15, 14, '9945', 'Resident', '17/Jun/04', '30/Dec/99', '9945');
INSERT INTO PATIENT_t  (Patient_ID, Person_ID, Physician_ID, Admission_Type, Contact_Date, Contact_Time, Referral_ID)
VALUES  (16, 15, '9624', 'Outpatient', '17/Jun/04', '30/Dec/99', '');
INSERT INTO PATIENT_t  (Patient_ID, Person_ID, Physician_ID, Admission_Type, Contact_Date, Contact_Time, Referral_ID)
VALUES  (17, 17, '9723', 'Resident', '16/Jul/04', '30/Dec/99', '9723');

INSERT INTO OUTPATIENT_t (Patient_ID, Visit_Date, Comments)
VALUES (12, '15/May/04', 'Broken Leg');
INSERT INTO OUTPATIENT_t (Patient_ID, Visit_Date, Comments)
VALUES (13, '22/May/04', 'Asthma');
INSERT INTO OUTPATIENT_t (Patient_ID, Visit_Date, Comments)
VALUES (16, '17/Jun/04', 'Unconscious upon arrival');

INSERT INTO RESIDENT_t (Patient_ID, Date_Admitted, Bed)
VALUES (14, '13/Aug/04', 'MA-100-1');
INSERT INTO RESIDENT_t (Patient_ID, Date_Admitted, Bed)
VALUES (15, '17/Jun/04', 'GC-100-2');
INSERT INTO RESIDENT_t (Patient_ID, Date_Admitted, Bed)
VALUES (16, '17/Jun/04', 'GC-100-1');
INSERT INTO RESIDENT_t (Patient_ID, Date_Admitted, Bed)
VALUES (17, '16/Jul/04', 'GC-201-1');

INSERT INTO STAFF_t  (Employee_ID, Job_Class)
VALUES  (2, 'Full Time');

INSERT INTO LOCATION_t  (Location_Id, Location_name)
VALUES  (1, 'Complex 1');
INSERT INTO LOCATION_t  (Location_Id, Location_name)
VALUES  (2, 'Complex 2');
INSERT INTO LOCATION_t  (Location_Id, Location_name)
VALUES  (3, 'Complex 3');

INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('Arterial blood gases', 'Complex 2');
INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('Blood alcohol level', 'Complex 2');
INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('CMV', 'Complex 2');
INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('Complete blood count', 'Complex 2');
INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('Digitalis', 'Complex 2');
INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('Drug screening', 'Complex 2');
INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('Electrodiagnosis', 'Complex 2');
INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('Hematology', 'Complex 2');
INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('Pregnancy test', 'Complex 2');
INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('PT/PT', 'Complex 2');
INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('Radiology', 'Complex 3');
INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('RSV', 'Complex 3');
INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('SED rate', 'Complex 2');
INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('SMAC', 'Complex 2');
INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('STD screening', 'Complex 2');
INSERT INTO LABORATORY_t  (Laboratory_Id, Laboratory_Location)
VALUES  ('Troponin', 'Complex 2');

INSERT INTO TECHNICIAN_t  (Technician_ID, Skill)
VALUES  (4, 'Xray');
INSERT INTO TECHNICIAN_t  (Technician_ID, Skill)
VALUES  (8, 'Hematology');
INSERT INTO TECHNICIAN_t  (Technician_ID, Skill)
VALUES  (9, 'Anesthesia');

INSERT INTO TREATMENT_t  (Treatment_ID, Treatment_Name)
VALUES  (1, 'Laboratory');
INSERT INTO TREATMENT_t  (Treatment_ID, Treatment_Name)
VALUES  (2, 'Surgery');
INSERT INTO TREATMENT_t  (Treatment_ID, Treatment_Name)
VALUES  (3, 'Rehabilitation');
INSERT INTO TREATMENT_t  (Treatment_ID, Treatment_Name)
VALUES  (4, 'Physical');
INSERT INTO TREATMENT_t  (Treatment_ID, Treatment_Name)
VALUES  (5, 'Mental');
INSERT INTO TREATMENT_t  (Treatment_ID, Treatment_Name)
VALUES  (6, 'Cardiac');
INSERT INTO TREATMENT_t  (Treatment_ID, Treatment_Name)
VALUES  (7, 'Pulmonary');
INSERT INTO TREATMENT_t  (Treatment_ID, Treatment_Name)
VALUES  (8, 'Neurologic');
INSERT INTO TREATMENT_t  (Treatment_ID, Treatment_Name)
VALUES  (9, 'Pediatric');
INSERT INTO TREATMENT_t  (Treatment_ID, Treatment_Name)
VALUES  (10, 'Natal');

INSERT INTO VOLUNTEER_t  (Volunteer_id, Skill)
VALUES  (13, 'Walking Partner');
INSERT INTO VOLUNTEER_t  (Volunteer_id, Skill)
VALUES  (17, 'Group Reading');

INSERT INTO PERFORMS_t  (Patient_id, Physician_ID, Treatment_ID, Treatment_Date, Treatment_Time, Results)
VALUES  (12, '9723', 4, '15/May/04', '30/Dec/99', 'Immobilized leg');
INSERT INTO PERFORMS_t  (Patient_id, Physician_ID, Treatment_ID, Treatment_Date, Treatment_Time, Results)
VALUES  (16, '9624', 1, '17/Jun/04', '30/Dec/99', 'High blood sugar');
INSERT INTO PERFORMS_t  (Patient_id, Physician_ID, Treatment_ID, Treatment_Date, Treatment_Time, Results)
VALUES  (17, '9624', 1, '16/Jul/04', '30/Dec/99', 'Lab blood test for heart function');
INSERT INTO PERFORMS_t  (Patient_id, Physician_ID, Treatment_ID, Treatment_Date, Treatment_Time, Results)
VALUES  (12, '9945', 4, '15/May/04', '30/Dec/99', 'Consultation');
INSERT INTO PERFORMS_t  (Patient_id, Physician_ID, Treatment_ID, Treatment_Date, Treatment_Time, Results)
VALUES  (12, '9723', 4, '15/May/04', '30/Dec/99', 'Consultation');
INSERT INTO PERFORMS_t  (Patient_id, Physician_ID, Treatment_ID, Treatment_Date, Treatment_Time, Results)
VALUES  (17, '9723', 6, '16/Jul/04', '30/Dec/99', 'Heart attack treated');
INSERT INTO PERFORMS_t  (Patient_id, Physician_ID, Treatment_ID, Treatment_Date, Treatment_Time, Results)
VALUES  (17, '9723', 4, '17/Jul/04', '30/Dec/99', 'Monitoring');
INSERT INTO PERFORMS_t  (Patient_id, Physician_ID, Treatment_ID, Treatment_Date, Treatment_Time, Results)
VALUES  (13, '9723', 7, '22/May/04', '30/Dec/99', 'Restored breathing ability');
INSERT INTO PERFORMS_t  (Patient_id, Physician_ID, Treatment_ID, Treatment_Date, Treatment_Time, Results)
VALUES  (14, '9801', 10, '14/Aug/04', '30/Dec/99', 'Delivered baby');

INSERT INTO CONSUMES_t  (Patient_ID, Item_ID, Date_Received, Time_Received, Quantity)
VALUES  (14, 908, '14/Aug/04', '14/Aug/04', 1);
INSERT INTO CONSUMES_t  (Patient_ID, Item_ID, Date_Received, Time_Received, Quantity)
VALUES  (14, 920, '14/Aug/04', '14/Aug/04', 1);
INSERT INTO CONSUMES_t  (Patient_ID, Item_ID, Date_Received, Time_Received, Quantity)
VALUES  (14, 921, '14/Aug/04', '14/Aug/04', 1);

INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('AE', 1, 2004, 1, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('AE', 1, 2004, 2, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('AE', 1, 2004, 3, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('AE', 1, 2004, 4, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('AE', 18, 2004, 1, 32);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('AE', 18, 2004, 2, 32);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('AE', 18, 2004, 3, 32);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('AE', 18, 2004, 4, 32);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CA', 3, 2004, 1, 38);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CA', 3, 2004, 2, 39);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CA', 3, 2004, 3, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CA', 3, 2004, 4, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CA', 19, 2004, 1, 30);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CA', 19, 2004, 2, 32);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CA', 19, 2004, 3, 28);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CA', 19, 2004, 4, 0);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CC', 12, 2004, 1, 42);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CC', 12, 2004, 2, 41);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CC', 12, 2004, 3, 44);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CC', 12, 2004, 4, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CC', 22, 2004, 1, 35);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CC', 22, 2004, 2, 35);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CC', 22, 2004, 3, 38);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('CC', 22, 2004, 4, 38);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('GC', 7, 2004, 1, 24);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('GC', 7, 2004, 2, 24);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('GC', 7, 2004, 3, 24);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('GC', 7, 2004, 4, 24);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('GC', 13, 2004, 1, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('GC', 13, 2004, 2, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('GC', 13, 2004, 3, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('GC', 13, 2004, 4, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('MA', 5, 2004, 1, 42);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('MA', 5, 2004, 2, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('MA', 5, 2004, 3, 35);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('MA', 5, 2004, 4, 36);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('MA', 20, 2004, 1, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('MA', 20, 2004, 2, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('MA', 20, 2004, 3, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('MA', 20, 2004, 4, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('SG', 6, 2004, 1, 42);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('SG', 6, 2004, 2, 39);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('SG', 6, 2004, 3, 45);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('SG', 6, 2004, 4, 40);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('SG', 21, 2004, 1, 28);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('SG', 21, 2004, 2, 28);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('SG', 21, 2004, 3, 28);
INSERT INTO Assignment_t (CareCenter_ID,Employee_ID, Year, Week, Hours)
VALUES ('SG', 21, 2004, 4, 28);

INSERT INTO Laboratory_Assignment_t (Laboratory_Id, Technician_Id)
VALUES ('Arterial blood gases', 8);
INSERT INTO Laboratory_Assignment_t (Laboratory_Id, Technician_Id)
VALUES ('Blood alcohol level', 8);
INSERT INTO Laboratory_Assignment_t (Laboratory_Id, Technician_Id)
VALUES ('Complete blood count', 8);
INSERT INTO Laboratory_Assignment_t (Laboratory_Id, Technician_Id)
VALUES ('Hematology', 8);
INSERT INTO Laboratory_Assignment_t (Laboratory_Id, Technician_Id)
VALUES ('Radiology', 8);

INSERT INTO Treatment_Item_t (Treatment_ID, Item_ID)
VALUES (1, 701);
INSERT INTO Treatment_Item_t (Treatment_ID, Item_ID)
VALUES (1, 801);
INSERT INTO Treatment_Item_t (Treatment_ID, Item_ID)
VALUES (2, 615);
INSERT INTO Treatment_Item_t (Treatment_ID, Item_ID)
VALUES (2, 616);
INSERT INTO Treatment_Item_t (Treatment_ID, Item_ID)
VALUES (2, 617);
INSERT INTO Treatment_Item_t (Treatment_ID, Item_ID)
VALUES (4, 502);
INSERT INTO Treatment_Item_t (Treatment_ID, Item_ID)
VALUES (6,613);
INSERT INTO Treatment_Item_t (Treatment_ID, Item_ID)
VALUES (7, 606);
INSERT INTO Treatment_Item_t (Treatment_ID, Item_ID)
VALUES (7, 613);
INSERT INTO Treatment_Item_t (Treatment_ID, Item_ID)
VALUES (8, 501);
INSERT INTO Treatment_Item_t (Treatment_ID, Item_ID)
VALUES (9, 614);
INSERT INTO Treatment_Item_t (Treatment_ID, Item_ID)
VALUES (10, 612);



DESC CONSUMES_t;
DESC PERFORMS_t;
DESC Assignment_t;
DESC Laboratory_Assignment_t;
DESC STAFF_t;
DESC NURSE_t;
DESC RESIDENT_t;
DESC outpatient_t;
DESC PATIENT_t;
DESC PHYSICIAN_t;
DESC EMPLOYEE_t;
DESC PERSON_t;
DESC BED_t;
DESC CARE_CENTER_t;
DESC ITEM_t;
DESC LOCATION_t;
DESC LABORATORY_t;
DESC TECHNICIAN_t;
DESC TREATMENT_t;
DESC VOLUNTEER_t;
DESC Treatment_Item_t;