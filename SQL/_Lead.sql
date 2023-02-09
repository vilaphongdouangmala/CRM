
create table `LeadStatus` (
 LeadStatusId int(11) not null,
 StatusName varchar(255)  default null,
 primary key (LeadStatusId)    
) engine=InnoDB default charset=utf8mb4;


create table `Lead` (
 LeadId int(11) not null,
 FirstName varchar(255)  default null,
 LastName varchar(255)  default null,
 Email varchar(255)  default null,
 CreatedDate datetime not null,
 LastContactedDate datetime not null,
 Source varchar(255)  default null,
 LeadStatusId int(11) not null,
 primary key (LeadId),
 KEY IX_Lead_LeadStatusId (LeadStatusId),
 CONSTRAINT FK_Lead_LeadStatus_LeadStatusId FOREIGN KEY (LeadStatusId) REFERENCES `LeadStatus` (LeadStatusId) ON DELETE CASCADE    
) engine=InnoDB default charset=utf8mb4;

