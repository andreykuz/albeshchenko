#выборка документов для человека, id_people скрыть 
#(base основной-1 или нет-0, может быть только один основной)
#перед установкой основного документа снять галочку с осн. если такой есть

select 
	serya as 'Серія',
	number as 'Номер',
	doc_type as 'Тип',
	dateStart as 'Дата видачі',
	dateend as 'Дата закінчення дії',
	base as 'Основний'
from 
	document
inner join 
	directory_doc_type on id_doc_type=type
where 
	id_people=(VALUE) 