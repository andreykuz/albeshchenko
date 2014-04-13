#вывод людей на главной странице , скрыть при выводе id

SELECT 
	idpeople, 
	concat(sename,' ', name_, ' ', lastname) AS ПІБ,
	concat('c. ',view_pgo.village_name,' вул.',view_pgo.street_name,' ',view_pgo.num_house) AS Адреса, 
	stat AS Стать, 
	dateBirth AS `Дата народження`
FROM 
	people
LEFT JOIN 
	registration ON people.idpeople=registration.id_people
LEFT JOIN 
	view_pgo ON (view_pgo.idPGO=registration.id_pgo) 
	and 
	(view_pgo.nPGO=registration.id_npgo)
