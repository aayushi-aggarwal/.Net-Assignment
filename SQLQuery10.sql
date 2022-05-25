create database Assignment2

use Assignment2
GO

create table Player(
Player_id int primary key not null,
Player_name varchar(100),
Jersey_no bigint unique,
Age int check(Age between 15 and 40),
Country varchar(50),
DOB date, 
Gender varchar(50) default 'Male',
Sport varchar(50)
);

insert into Player values 
(1,'Hamilton Masakadza',098,38,'Zimbabwe','1983-07-09','Male','Cricket'),
(2,'Cristiano Ronaldo',017,37,'Portuguese','1985-02-05','Male','Football'),
(3,'Amit Balwan Singh',120,24,'India','1998-04-25','Male','Volleyball'),
(4,'Wellington Masakadza',013,32,'New Zealand','1993-10-04','Male','Cricket'),
(5,'Lionel Messi',031,34,' Argentina','1987-06-24','Male','Football'),
(6,'Bhuvneshwar Kumar',901,32,'India','1990-02-05','Male','Cricket'),
(7,'Gagan Kumar',103,23,'India','1999-07-29','Male','Volleyball'),
(8,'Joel Paris',201,29,'Australia','1992-12-11','Male','Cricket'),
(9,'Sunil Chhetri',029,37,'India','1984-09-03','Male','Football'),
(10,'PV Sindhu',209,26,'India','1995-07-05','Female','Badminton');



