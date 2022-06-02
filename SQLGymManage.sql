create table NewMember(
	MID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Fname varchar(150) NOT NULL,
	Lname varchar(150) NOT NULL,
	Gender varchar(20) NOT NULL,
	Dob varchar(100) NOT NULL,
	Mobile bigint NOT NULL,
	Email varchar(150),
	JoinDate varchar(100) NOT NULL,
	GymTime varchar(120) NOT NULL,
	Maddress varchar(250) NOT NULL,
	MemebershipTime varchar(120) NOT NULL

	
);

select * from dbo.NewMember;