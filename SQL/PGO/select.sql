SELECT 
    idPGO,
    nPGO,
    directory_village.village_name,
    street_name,
	num_house,
    num_flat,
    memo, 
    vukl,
    reason,
    nBookPGO,
    nPage
FROM 
    `pgo`
LEFT JOIN  
    `directory_street` ON ((`pgo`.`idstreet` = `directory_street`.`id_street`))
LEFT JOIN  
    `directory_village` ON ((`pgo`.`idvillage` = `directory_village`.`id_village`))
WHERE 
    idpgo=(VALUE) and npgo=(VALUE)