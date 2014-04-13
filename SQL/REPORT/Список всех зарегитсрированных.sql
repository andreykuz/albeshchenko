#список всех, кто зарегистрирован, исключая умерших и выбывших
SELECT 
	
	concat(sename,' ', name_, ' ', lastname) AS ПІБ,
	concat('c. ',view_pgo.village_name,' вул.',view_pgo.street_name,' ',view_pgo.num_house) AS Адреса, 
	dateBirth AS `Дата народження`
FROM 
	people
LEFT JOIN 
	registration ON people.idpeople=registration.id_people
LEFT JOIN 
	view_pgo ON (view_pgo.idPGO=registration.id_pgo) 
	and 
	(view_pgo.nPGO=registration.id_npgo)
where registration.type='зареєстрований' and dateOfdeath is null and datev is null
