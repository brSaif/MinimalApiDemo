﻿IF not exists (select 1 from dbo.[User])
begin
	insert into dbo.[User](FirstName, LastName)
	values('Seif','Eddine'),
	('John','Smith'),
	('Tim','Corey');
end
