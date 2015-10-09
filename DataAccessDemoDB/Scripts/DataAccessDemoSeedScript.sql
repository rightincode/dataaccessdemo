/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF NOT EXISTS (SELECT 1 FROM [dbo].[Contact] WHERE [FirstName] = 'Richard' AND [LastName] = 'Taylor') BEGIN
	INSERT INTO [dbo].[Contact] (FirstName, LastName, Email, Phone)
	VALUES ('Richard', 'Taylor', 'rtaylor@rightincode.com', '704-777-7777')	
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Contact] WHERE [FirstName] = 'Cam' AND [LastName] = 'Newton') BEGIN
	INSERT INTO [dbo].[Contact] (FirstName, LastName, Email, Phone)
	VALUES ('Cam', 'Newton', 'cnewton@rightincode.com', '704-777-7777')	
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Contact] WHERE [FirstName] = 'Michael' AND [LastName] = 'Tolbert') BEGIN
	INSERT INTO [dbo].[Contact] (FirstName, LastName, Email, Phone)
	VALUES ('Michael', 'Tolbert', 'mtolbert@rightincode.com', '704-777-7777')	
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Contact] WHERE [FirstName] = 'Kelvin' AND [LastName] = 'Benjamin') BEGIN
	INSERT INTO [dbo].[Contact] (FirstName, LastName, Email, Phone)
	VALUES ('Kelvin', 'Benjamin', 'kbenjamin@rightincode.com', '704-777-7777')	
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Contact] WHERE [FirstName] = 'Luke' AND [LastName] = 'Kuechly') BEGIN
	INSERT INTO [dbo].[Contact] (FirstName, LastName, Email, Phone)
	VALUES ('Luke', 'Kuechly', 'lkuechly@rightincode.com', '704-777-7777')	
END
