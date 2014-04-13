#для тех, кто проживает в хозяйстве с типом 1 nPGO=1
#код ПГО, дата прибытия, дата выбытия, временно отстутств.(1), причина, 
#тип рег(зарегистрирован, временно проживает, не прож. на территории совета)



select 
	concat (id_pgo, id_npgo) as 'Код ПГО',
	datep as 'Дата прибуття',
	datev as 'Дата вибуття', 
	tunchV as 'Тимчасово відсутній',
	reason as 'Причина', 
	type as 'Тип регєстрації'
from 
	registration
where 
	id_people=2



#для тех, кто проживает\владеет - хозяйство с типом 2,3,4,5
#код ПГО, дата прибытия, дата выбытия, цель, тип, адрес регистрации

#select concat(id_pgo, id_npgo) as 'Код ПГО', datep, datev, goal, type, address
#from registration 
#where id_people=(Value)