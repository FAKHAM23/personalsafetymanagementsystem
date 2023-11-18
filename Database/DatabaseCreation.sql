-- Create the database

-- Create the UserRole table
CREATE TABLE [UserRole] (
    UserRoleID INT PRIMARY KEY IDENTITY(1,1),
    RoleName VARCHAR(255),
    RoleDescription TEXT,
    CreatedAt DATETIME,
    UpdatedAt DATETIME
);

-- Create the [User] table
CREATE TABLE [User] (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(255),
    Password VARCHAR(255), -- Hashed and salted
    RoleID INT,
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    FOREIGN KEY (RoleID) REFERENCES [UserRole](UserRoleID)
);

-- Create the UserDetails table
CREATE TABLE UserDetails (
    UserDetailsID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT,
    Email VARCHAR(255),
    FirstName VARCHAR(255),
    LastName VARCHAR(255),
    PhoneNumber VARCHAR(20),
    Gender NVARCHAR(10) CHECK (Gender IN ('Male', 'Female', 'Other')),
    DateOfBirth DATE,
    LastLoginDate DATETIME,
    PrivacySettings TEXT,
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    FOREIGN KEY (UserID) REFERENCES [User](UserID)
);

-- Create the EmergencyContacts table
CREATE TABLE EmergencyContacts (
    ContactID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT,
    ContactName VARCHAR(255),
    ContactPhoneNumber VARCHAR(20),
    Relationship VARCHAR(255),
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    FOREIGN KEY (UserID) REFERENCES [User](UserID)
);

-- Create the Location table
CREATE TABLE Location (
    LocationID INT PRIMARY KEY IDENTITY(1,1),
    Latitude DECIMAL(10, 8),
    Longitude DECIMAL(11, 8),
    Address VARCHAR(255),
    City VARCHAR(255),
    State VARCHAR(255),
    Country VARCHAR(255),
    HighRiskAreaFlag BIT,
    CreatedAt DATETIME,
    UpdatedAt DATETIME
);

-- Create the Incident table
CREATE TABLE Incident (
    IncidentID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT,
    LocationID INT,
    IncidentType VARCHAR(255),
    Description TEXT,
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    FOREIGN KEY (UserID) REFERENCES [User](UserID),
    FOREIGN KEY (LocationID) REFERENCES Location(LocationID)
);

-- Create the UserAudit table
CREATE TABLE UserAudit (
    UserAuditID INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(10), -- INSERT, UPDATE, DELETE
    OldUserID INT,
    OldUsername VARCHAR(255),
    OldPassword VARCHAR(255),
    OldRoleID INT,
    OldCreatedAt DATETIME,
    OldUpdatedAt DATETIME,
    NewUserID INT,
    NewUsername VARCHAR(255),
    NewPassword VARCHAR(255),
    NewRoleID INT,
    NewCreatedAt DATETIME,
    NewUpdatedAt DATETIME,
    Timestamp DATETIME
);


-- Create the UserDetailsAudit table
CREATE TABLE UserDetailsAudit (
    UserDetailsAuditID INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(10), -- INSERT, UPDATE, DELETE
    OldUserDetailsID INT,
    OldUserID INT,
    OldEmail VARCHAR(255),
    OldFirstName VARCHAR(255),
    OldLastName VARCHAR(255),
    OldPhoneNumber VARCHAR(20),
    OldGender NVARCHAR(10),
    OldDateOfBirth DATE,
    OldLastLoginDate DATETIME,
    OldPrivacySettings TEXT,
    OldCreatedAt DATETIME,
    OldUpdatedAt DATETIME,
    NewUserDetailsID INT,
    NewUserID INT,
    NewEmail VARCHAR(255),
    NewFirstName VARCHAR(255),
    NewLastName VARCHAR(255),
    NewPhoneNumber VARCHAR(20),
    NewGender NVARCHAR(10),
    NewDateOfBirth DATE,
    NewLastLoginDate DATETIME,
    NewPrivacySettings TEXT,
    NewCreatedAt DATETIME,
    NewUpdatedAt DATETIME,
    Timestamp DATETIME
);

-- Create the UserRoleAudit table
CREATE TABLE UserRoleAudit (
    UserRoleAuditID INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(10), -- INSERT, UPDATE, DELETE
    OldUserRoleID INT,
    OldRoleName VARCHAR(255),
    OldRoleDescription TEXT,
    OldCreatedAt DATETIME,
    OldUpdatedAt DATETIME,
    NewUserRoleID INT,
    NewRoleName VARCHAR(255),
    NewRoleDescription TEXT,
    NewCreatedAt DATETIME,
    NewUpdatedAt DATETIME,
    Timestamp DATETIME
);

-- Create the EmergencyContactsAudit table
CREATE TABLE EmergencyContactsAudit (
    EmergencyContactsAuditID INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(10), -- INSERT, UPDATE, DELETE
    OldContactID INT,
    OldUserID INT,
    OldContactName VARCHAR(255),
    OldContactPhoneNumber VARCHAR(20),
    OldRelationship VARCHAR(255),
    OldCreatedAt DATETIME,
    OldUpdatedAt DATETIME,
    NewContactID INT,
    NewUserID INT,
    NewContactName VARCHAR(255),
    NewContactPhoneNumber VARCHAR(20),
    NewRelationship VARCHAR(255),
    NewCreatedAt DATETIME,
    NewUpdatedAt DATETIME,
    Timestamp DATETIME
);

-- Create the IncidentAudit table
CREATE TABLE IncidentAudit (
    IncidentAuditID INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(10), -- INSERT, UPDATE, DELETE
    OldIncidentID INT,
    OldUserID INT,
    OldLocationID INT,
    OldIncidentType VARCHAR(255),
    OldDescription TEXT,
    OldCreatedAt DATETIME,
    OldUpdatedAt DATETIME,
    NewIncidentID INT,
    NewUserID INT,
    NewLocationID INT,
    NewIncidentType VARCHAR(255),
    NewDescription TEXT,
    NewCreatedAt DATETIME,
    NewUpdatedAt DATETIME,
    Timestamp DATETIME
);

-- Create the LocationAudit table
CREATE TABLE LocationAudit (
    LocationAuditID INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(10), -- INSERT, UPDATE, DELETE
    OldLocationID INT,
    OldLatitude DECIMAL(10, 8),
    OldLongitude DECIMAL(11, 8),
    OldAddress VARCHAR(255),
    OldCity VARCHAR(255),
    OldState VARCHAR(255),
    OldCountry VARCHAR(255),
    OldHighRiskAreaFlag BIT,
    OldCreatedAt DATETIME,
    OldUpdatedAt DATETIME,
    NewLocationID INT,
    NewLatitude DECIMAL(10, 8),
    NewLongitude DECIMAL(11, 8),
    NewAddress VARCHAR(255),
    NewCity VARCHAR(255),
    NewState VARCHAR(255),
    NewCountry VARCHAR(255),
    NewHighRiskAreaFlag BIT,
    NewCreatedAt DATETIME,
    NewUpdatedAt DATETIME,
    Timestamp DATETIME
);

-- Create the SafetyTipsAudit table
CREATE TABLE SafetyTipsAudit (
    SafetyTipsAuditID INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(10), -- INSERT, UPDATE, DELETE
    OldTipID INT,
    OldTitle VARCHAR(255),
    OldDescription TEXT,
    OldCreatedAt DATETIME,
    OldUpdatedAt DATETIME,
    NewTipID INT,
    NewTitle VARCHAR(255),
    NewDescription TEXT,
    NewCreatedAt DATETIME,
    NewUpdatedAt DATETIME,
    Timestamp DATETIME
);

-- Create the ChatMessagesAudit table
CREATE TABLE ChatMessagesAudit (
    ChatMessagesAuditID INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(10), -- INSERT, UPDATE, DELETE
    OldMessageID INT,
    OldUserID INT,
    OldReceiverUserID INT,
    OldMessageText TEXT,
    OldCreatedAt DATETIME,
    OldUpdatedAt DATETIME,
    NewMessageID INT,
    NewUserID INT,
    NewReceiverUserID INT,
    NewMessageText TEXT,
    NewCreatedAt DATETIME,
    NewUpdatedAt DATETIME,
    Timestamp DATETIME
);

-- Create the AlertsAudit table
CREATE TABLE AlertsAudit (
    AlertsAuditID INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(10), -- INSERT, UPDATE, DELETE
    OldAlertID INT,
    OldUserID INT,
    OldAlertType VARCHAR(255),
    OldCreatedAt DATETIME,
    OldUpdatedAt DATETIME,
    NewAlertID INT,
    NewUserID INT,
    NewAlertType VARCHAR(255),
    NewCreatedAt DATETIME,
    NewUpdatedAt DATETIME,
    Timestamp DATETIME
);

-- Create the LanguageSupportAudit table
CREATE TABLE LanguageSupportAudit (
    LanguageSupportAuditID INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(10), -- INSERT, UPDATE, DELETE
    OldLanguageID INT,
    OldLanguageName VARCHAR(255),
    OldCreatedAt DATETIME,
    OldUpdatedAt DATETIME,
    NewLanguageID INT,
    NewLanguageName VARCHAR(255),
    NewCreatedAt DATETIME,
    NewUpdatedAt DATETIME,
    Timestamp DATETIME
);

-- Create the ReportAudit table
CREATE TABLE ReportAudit (
    ReportAuditID INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(10), -- INSERT, UPDATE, DELETE
    OldReportID INT,
    OldUserID INT,
    OldLocationID INT,
    OldFeedbackText TEXT,
    OldCreatedAt DATETIME,
    OldUpdatedAt DATETIME,
    NewReportID INT,
    NewUserID INT,
    NewLocationID INT,
    NewFeedbackText TEXT,
    NewCreatedAt DATETIME,
    NewUpdatedAt DATETIME,
    Timestamp DATETIME
);

-- Create the IncidentHistoryAudit table
CREATE TABLE IncidentHistoryAudit (
    IncidentHistoryAuditID INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(10), -- INSERT, UPDATE, DELETE
    OldIncidentHistoryID INT,
    OldUserID INT,
    OldIncidentID INT,
    OldCreatedAt DATETIME,
    OldUpdatedAt DATETIME,
    NewIncidentHistoryID INT,
    NewUserID INT,
    NewIncidentID INT,
    NewCreatedAt DATETIME,
    NewUpdatedAt DATETIME,
    Timestamp DATETIME
);

-- Create the FeedbackRatingAudit table
CREATE TABLE FeedbackRatingAudit (
    FeedbackRatingAuditID INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(10), -- INSERT, UPDATE, DELETE
    OldRatingID INT,
    OldUserID INT,
    OldRating INT,
    OldFeedbackText TEXT,
    OldCreatedAt DATETIME,
    OldUpdatedAt DATETIME,
    NewRatingID INT,
    NewUserID INT,
    NewRating INT,
    NewFeedbackText TEXT,
    NewCreatedAt DATETIME,
    NewUpdatedAt DATETIME,
    Timestamp DATETIME
);



-- Create the SafetyTips table
CREATE TABLE SafetyTips (
    TipID INT PRIMARY KEY IDENTITY(1,1),
    Title VARCHAR(255),
    Description TEXT,
    CreatedAt DATETIME,
    UpdatedAt DATETIME
);

-- Create the ChatMessages table
CREATE TABLE ChatMessages (
    MessageID INT PRIMARY KEY  IDENTITY(1,1),
    UserID INT,
    ReceiverUserID INT,
    MessageText TEXT,
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    FOREIGN KEY (UserID) REFERENCES [User](UserID),
    FOREIGN KEY (ReceiverUserID) REFERENCES [User](UserID)
);

-- Create the Alerts table
CREATE TABLE Alerts (
    AlertID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT,
    AlertType VARCHAR(255),
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    FOREIGN KEY (UserID) REFERENCES [User](UserID)
);

-- Create the LanguageSupport table
CREATE TABLE LanguageSupport (
    LanguageID INT PRIMARY KEY IDENTITY(1,1),
    LanguageName VARCHAR(255),
    CreatedAt DATETIME,
    UpdatedAt DATETIME
);

-- Create the Report table
CREATE TABLE Report (
    ReportID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT,
    LocationID INT,
    FeedbackText TEXT,
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    FOREIGN KEY (UserID) REFERENCES [User](UserID),
    FOREIGN KEY (LocationID) REFERENCES Location(LocationID)
);

-- Create the IncidentHistory table
CREATE TABLE IncidentHistory (
    IncidentHistoryID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT,
    IncidentID INT,
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    FOREIGN KEY (UserID) REFERENCES [User](UserID),
    FOREIGN KEY (IncidentID) REFERENCES Incident(IncidentID)
);

-- Create the FeedbackRating table
CREATE TABLE FeedbackRating (
    RatingID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT,
    Rating INT,
    FeedbackText TEXT,
    CreatedAt DATETIME,
    UpdatedAt DATETIME,
    FOREIGN KEY (UserID) REFERENCES [User](UserID)
);



-- Alter the UserAudit table
ALTER TABLE UserAudit
ADD UserID INT,
CONSTRAINT FK_UserAudit_UserID FOREIGN KEY (UserID) REFERENCES [User](UserID);

-- Alter the UserDetailsAudit table
ALTER TABLE UserDetailsAudit
ADD UserID INT,
CONSTRAINT FK_UserDetailsAudit_UserID FOREIGN KEY (UserID) REFERENCES [User](UserID);

-- Alter the UserRoleAudit table
ALTER TABLE UserRoleAudit
ADD UserID INT,
CONSTRAINT FK_UserRoleAudit_UserID FOREIGN KEY (UserID) REFERENCES [User](UserID);

-- Alter the EmergencyContactsAudit table
ALTER TABLE EmergencyContactsAudit
ADD UserID INT,
CONSTRAINT FK_EmergencyContactsAudit_UserID FOREIGN KEY (UserID) REFERENCES [User](UserID);

-- Alter the IncidentAudit table
ALTER TABLE IncidentAudit
ADD UserID INT,
CONSTRAINT FK_IncidentAudit_UserID FOREIGN KEY (UserID) REFERENCES [User](UserID);

-- Alter the LocationAudit table
ALTER TABLE LocationAudit
ADD UserID INT,
CONSTRAINT FK_LocationAudit_UserID FOREIGN KEY (UserID) REFERENCES [User](UserID);

-- Alter the SafetyTipsAudit table
ALTER TABLE SafetyTipsAudit
ADD UserID INT,
CONSTRAINT FK_SafetyTipsAudit_UserID FOREIGN KEY (UserID) REFERENCES [User](UserID);

-- Alter the ChatMessagesAudit table
ALTER TABLE ChatMessagesAudit
ADD UserID INT,
CONSTRAINT FK_ChatMessagesAudit_UserID FOREIGN KEY (UserID) REFERENCES [User](UserID);

-- Alter the AlertsAudit table
ALTER TABLE AlertsAudit
ADD UserID INT,
CONSTRAINT FK_AlertsAudit_UserID FOREIGN KEY (UserID) REFERENCES [User](UserID);

-- Alter the LanguageSupportAudit table
ALTER TABLE LanguageSupportAudit
ADD UserID INT,
CONSTRAINT FK_LanguageSupportAudit_UserID FOREIGN KEY (UserID) REFERENCES [User](UserID);

-- Alter the ReportAudit table
ALTER TABLE ReportAudit
ADD UserID INT,
CONSTRAINT FK_ReportAudit_UserID FOREIGN KEY (UserID) REFERENCES [User](UserID);

-- Alter the IncidentHistoryAudit table
ALTER TABLE IncidentHistoryAudit
ADD UserID INT,
CONSTRAINT FK_IncidentHistoryAudit_UserID FOREIGN KEY (UserID) REFERENCES [User](UserID);

-- Alter the FeedbackRatingAudit table
ALTER TABLE FeedbackRatingAudit
ADD UserID INT,
CONSTRAINT FK_FeedbackRatingAudit_UserID FOREIGN KEY (UserID) REFERENCES [User](UserID);







