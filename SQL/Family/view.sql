#семейные отношения id_pr=people, id_obr скрыть 
select 
	id_pr, 
	id_obr, 
	relationship as 'Родинний звязок', 
	concat (people.sename, ' ', people.name_,' ', people.lastname) as 'ПІБ',
	dateR as 'Дата початку'
from 
	relationshep
inner join 
	people on (id_obr=people.idpeople)
inner join 
	directory_relationship 	on (id_relationship=relationshep.type)

where id_pr=(Value)