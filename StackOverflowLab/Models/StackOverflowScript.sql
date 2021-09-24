CREATE TABLE Questions (
ID int NOT NULL AUTO_INCREMENT,
Username varchar(100),
Title varchar(255),
Detail varchar(255),
Posted DateTime,
Category varchar(100),
Tags varchar(100),
Status int,
PRIMARY KEY (ID)
);

CREATE TABLE Answers (
ID int,
Username varchar(100),
Detail varchar(255),
QuestionID int,
FOREIGN KEY (QuestionID) REFERENCES Questions(ID),
Posted DateTime,
Upvotes int
);

INSERT INTO  Questions
VALUES (1, "DanTheMan", "How do I upvote?", "Title says all,
appears to be broken.", STR_TO_DATE('18/02/2019 11:15:45','%d/%m/%Y %H:%i:%s'), "General", "user help,'
design",
1);




