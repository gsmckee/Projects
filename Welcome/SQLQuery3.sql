
--Create table AFCNorth(City varchar(20), State char(2), Mascot varchar(12) primary key, Championship int);
--Create table Record(Season int, Mascot varchar(12),Wins int, Losses int, Ties int);
--insert into AFCNorth values('Pittsburgh', 'PA', 'Steelers', 6), ('Baltimore', 'MD', 'Ravens', 2), ('Cincinnati', 'OH', 'Bengals', 0), ('Cleveland', 'OH', 'Browns', 4);
--insert into Record values(2017, 'Steelers', 0, 0, 0),(2017, 'Ravens', 0, 0, 0),(2017, 'Bengals', 0, 0, 0),(2017, 'Browns', 0, 0, 0);
select * from AFCNorth, Record;