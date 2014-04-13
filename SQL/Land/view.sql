SELECT 
`land`.`idLand` AS `idland`,
`land`.`number` AS `Кадастровий номер`,
`land`.`square` AS `Площа`,
`type_land` AS `Тип земельної ділянки`
FROM
`land`
JOIN `directory_land` ON ((`land`.`type` = `directory_land`.`iddirectory_land`))