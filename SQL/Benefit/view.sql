#вывод льгот и пенсий id,id_people не выводить

select 
	id,
	id_people,
	p_ll as 'Пенсія/льгота',
	document as 'Документ',
	lgota_type as 'Тип',
	date as 'Дата видачі', 
	dateEnd as 'Дата закінчення дії'
from 
	lgota
inner join 
	directory_lgota on id_lgota=lgota.type
where 
	id_people=(VALUE)