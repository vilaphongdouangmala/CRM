
create table `OpportunityStatus` (
 OpportunityStatusId int(11) not null,
 StatusName varchar(255)  default null,
 primary key (OpportunityStatusId)    
) engine=InnoDB default charset=utf8mb4;


create table `QuoteStatus` (
 QuoteStatusId int(11) not null,
 StatusName varchar(255)  default null,
 primary key (QuoteStatusId)    
) engine=InnoDB default charset=utf8mb4;


create table `Product` (
 ProductId int(11) not null,
 ProductName varchar(255)  default null,
 Price double not null,
 primary key (ProductId)    
) engine=InnoDB default charset=utf8mb4;


create table `QuoteItem` (
 QuoteItemId int(11) not null,
 Qty int(11) not null,
 Discount int(11) not null,
 ProductId int(11) not null,
 QuoteId int(11) not null,
 primary key (QuoteItemId),
 KEY IX_QuoteItem_ProductId (ProductId),
 KEY IX_QuoteItem_QuoteId (QuoteId),
 CONSTRAINT FK_QuoteItem_Product_ProductId FOREIGN KEY (ProductId) REFERENCES `Product` (ProductId) ON DELETE CASCADE,
 CONSTRAINT FK_QuoteItem_Quote_QuoteId FOREIGN KEY (QuoteId) REFERENCES `Quote` (QuoteId) ON DELETE CASCADE    
) engine=InnoDB default charset=utf8mb4;


create table `Quote` (
 QuoteId int(11) not null,
 QuoteName varchar(255)  default null,
 CreatedDate datetime not null,
 ModifiedDate datetime not null,
 ExpirationDate datetime not null,
 GrandTotal double not null,
 Description varchar(255)  default null,
 QuoteStatusId int(11) not null,
 primary key (QuoteId),
 KEY IX_Quote_QuoteStatusId (QuoteStatusId),
 CONSTRAINT FK_Quote_QuoteStatus_QuoteStatusId FOREIGN KEY (QuoteStatusId) REFERENCES `QuoteStatus` (QuoteStatusId) ON DELETE CASCADE    
) engine=InnoDB default charset=utf8mb4;


create table `Account` (
 AccountId int(11) not null,
 Type varchar(255)  default null,
 Website varchar(255)  default null,
 CreatedDate datetime not null,
 ModifiedDate datetime not null,
 primary key (AccountId)    
) engine=InnoDB default charset=utf8mb4;


create table `Account` (
 AccountId int(11) not null,
 Type varchar(255)  default null,
 Website varchar(255)  default null,
 CreatedDate datetime not null,
 ModifiedDate datetime not null,
 primary key (AccountId)    
) engine=InnoDB default charset=utf8mb4;


create table `Contact` (
 ContactId int(11) not null,
 CreatedDate datetime not null,
 FirstName varchar(255)  default null,
 LastName varchar(255)  default null,
 Email varchar(255)  default null,
 PhoneNumber int(11) not null,
 Birthdate datetime not null,
 ModifiedDate datetime not null,
 LastContactedDate datetime not null,
 AccountId int(11) not null,
 OpportunityId int(11) not null,
 primary key (ContactId),
 KEY IX_Contact_AccountId (AccountId),
 KEY IX_Contact_OpportunityId (OpportunityId),
 CONSTRAINT FK_Contact_Account_AccountId FOREIGN KEY (AccountId) REFERENCES `Account` (AccountId) ON DELETE CASCADE,
 CONSTRAINT FK_Contact_Opportunity_OpportunityId FOREIGN KEY (OpportunityId) REFERENCES `Opportunity` (OpportunityId) ON DELETE CASCADE    
) engine=InnoDB default charset=utf8mb4;


create table `Opportunity` (
 OpportunityId int(11) not null,
 CreatedDate datetime not null,
 OpportunityName varchar(255)  default null,
 Amount double not null,
 ModifiedDate datetime not null,
 OpportunityStatusId int(11) not null,
 Note varchar(255)  default null,
 QuoteId int(11) not null,
 AccountId int(11) not null,
 primary key (OpportunityId),
 KEY IX_Opportunity_OpportunityStatusId (OpportunityStatusId),
 KEY IX_Opportunity_QuoteId (QuoteId),
 KEY IX_Opportunity_AccountId (AccountId),
 CONSTRAINT FK_Opportunity_OpportunityStatus_OpportunityStatusId FOREIGN KEY (OpportunityStatusId) REFERENCES `OpportunityStatus` (OpportunityStatusId) ON DELETE CASCADE,
 CONSTRAINT FK_Opportunity_Quote_QuoteId FOREIGN KEY (QuoteId) REFERENCES `Quote` (QuoteId) ON DELETE CASCADE,
 CONSTRAINT FK_Opportunity_Account_AccountId FOREIGN KEY (AccountId) REFERENCES `Account` (AccountId) ON DELETE CASCADE    
) engine=InnoDB default charset=utf8mb4;

