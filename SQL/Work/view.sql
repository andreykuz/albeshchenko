select 
	idwork , 
	post as 'Посада', 
	workdescription as 'Місце роботи', 
	datestart as 'Прийняття на роботу', 
	dateend as 'Звільнення', 
	info as 'Додаткова інформція'
from 
	work 
where 
	id_people = (VALUE)