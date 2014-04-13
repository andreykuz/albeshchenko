SELECT
	concat(pgo.idPGO, pgo.nPGO) as ОПГО, 
	concat('c. ', directory_village.village_name,  ' вул. ', directory_street.street_name) as Адреса,
	concat(people.sename,' ',people.name_, ' ', people.lastname) as Власник
FROM 
	(pgo
	INNER JOIN 
		directory_street on pgo.idstreet = directory_street.id_street
	INNER JOIN 
		directory_village on pgo.idvillage = directory_village.id_village
	left join registration on (pgo.idPGO=registration.id_pgo) 
	and
	(pgo.nPGO=registration.id_npgo))

left join 
	people on people.idpeople=registration.id_people 

WHERE 	
	(people.golovaGospod!=0 and registration.datev is null and registration.datep  is not null) 
	or 
	(registration.id_people is null and registration.id_pgo is null and registration.id_npgo is null )