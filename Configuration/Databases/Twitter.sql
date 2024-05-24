CREATE DATABASE Twitter;
GO
USE Twitter;
GO
CREATE TABLE Users
(	
	UserID INT NOT NULL,
	Username NVARCHAR(50) NOT NULL,
	PRIMARY KEY (UserID)
);
GO
CREATE TABLE Tweets

(	
	TweetID INT NOT NULL, 
	UserID INT NOT NULL REFERENCES Users(UserId), 
	TweetText NVARCHAR(3000) NOT NULL, 
	CreatedAt DATETIME NOT NULL,
	PRIMARY KEY (TweetID)
);
GO
CREATE TABLE Comments
(	
	CommentID INT NOT NULL, 
	UserID INT NOT NULL REFERENCES Users(UserID), 
	TweetID INT NOT NULL REFERENCES Tweets(TweetID), 
	CommentText NVARCHAR(3000) NOT NULL, 
	CreatedAt DATETIME NOT NULL,
	PRIMARY KEY (CommentID)
); 

GO
INSERT INTO USERS (UserID, Username) VALUES 
		(1, N'User #1'), (2, N'User #2'), (3, N'User #3');
GO
INSERT INTO Tweets (TweetID, UserID, TweetText, CreatedAt) VALUES 
		(1, 1, N'EF-Core is an open source ORM', '2022-01-11 19:35');
GO
INSERT INTO Comments (CommentID, UserID, TweetID, CommentText, CreatedAt) VALUES 
(1, 2, 1, N'yes and also it''s light weight', '2022-01-11 19:45');
GO
INSERT INTO Comments (CommentID, UserID, TweetID, CommentText, CreatedAt) VALUES 
(2, 3, 1,N'Don''t forget it''s also cross-platform', '2022-01-11 20:05');