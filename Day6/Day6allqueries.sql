--Select id,fname from Students where id>1;
--Select id,fname from Students where id between 1 and 3;

--Select id,class,fname from Students where class in (11);
--select class, count(id) as count from Students group by class having count(id) >1;
--select id,fname from Students order by fname desc;
--select id,fname from Students order by id offset 2 rows fetch next 2 rows only