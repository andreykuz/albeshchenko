namespace PGO.Source
{
    internal static class SqlQuery
    {
        #region PGO SQL
        #region PgoView - отображает список ПГО в лоадере
        public static string PgoView = @"
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
	(registration.id_people is null and registration.id_pgo is null and registration.id_npgo is null )";
        #endregion
        #region PgoInsert - вставка нового ПГО в лоадере
        public static string PgoInsert = @"
INSERT INTO `pgo` 
    (`idstreet`, `idvillage`, `memo`, `nBookPGO`, `nPage`, `num_house`, `num_flat`, `vukl`, `reason`, `nPGO`) 
VALUES 
    ((VALUE), (VALUE), (VALUE), (VALUE), (VALUE), (VALUE), (VALUE), (VALUE), (VALUE), (VALUE))";
         #endregion
        #region PgoUpdate - обновление существующего ПГО в инфо

        public static string PgoUpdate = @" 
UPDATE 
    `pgo` 
SET  
    `idstreet`=(VALUE), 
    `idvillage`=(VALUE), 
    `memo`=(VALUE), 
    `nBookPGO`=(VALUE), 
    `nPage`=(VALUE), 
    `num_house`=(VALUE), 
    `num_flat`=(VALUE), 
    `vukl`=(VALUE), 
    `reason` =(VALUE)
WHERE 
    `nPGO`=(VALUE) and`idPGO`=(VALUE)";

        #endregion
        #region PgoOneQuery - загрузка значений ПГО по ИД и ТИП в инфо

        public static string PgoOneQuery = @"
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
    idpgo=(VALUE) and npgo=(VALUE)";

        #endregion
        #region PgoDelete - удаляет ПГО по ИД и ТИП
        public static string PgoDelete = @"DELETE FROM `pgo` WHERE ((`idPGO` = (VALUE)) AND (`nPGO` = (VALUE)))";
        #endregion
        #endregion

        #region People SQL
        #region PeopleView - отображает список людей в лоадере
        public static string PeopleView = @"
SELECT 
	idpeople, 
	concat(sename,' ', name_, ' ', lastname) AS ПІБ,
	concat('c. ',view_pgo.village_name,' вул.',view_pgo.street_name,' буд. ',view_pgo.num_house) AS Адреса, 
	stat AS Стать, 
	dateBirth AS `Дата народження`
FROM 
	people
LEFT JOIN 
	registration ON people.idpeople=registration.id_people
LEFT JOIN 
	view_pgo ON (view_pgo.idPGO=registration.id_pgo) 
	and 
	(view_pgo.nPGO=registration.id_npgo)";
#endregion
        #region PeopleInsert - вставка нового человека в инфо
        public static string PeopleInsert = @"
INSERT INTO people 
	(sename, name_, lastname, birthplace, datebirth, inn, stat, golovagospod, dateofdeath, reasondeath) 
VALUES 
	((VALUE), (VALUE), (VALUE), (VALUE), (VALUE), (VALUE), (VALUE), (VALUE), (VALUE), (VALUE))
";
        #endregion  
        #region PeopleOneQuery - загрузка значений человека по ИД в инфо
        public static string PeopleOneQuery =@"
SELECT 
	idpeople, 
	sename, 
	name_,
	lastname, 
	birthplace, 
	datebirth, 
	inn,
	stat,
	golovagospod, 
	dateofdeath,
	reasondeath
FROM 
	people
WHERE 
	idpeople=(VALUE)";
        #endregion
        #region PeopleUpdate - обновление существующего человека в инфо
        public static string PeopleUpdate = @"
UPDATE 
    `people` 
SET  
    `sename`=(VALUE), 
    `name_`=(VALUE), 
    `lastname`=(VALUE), 
    `birthplace`=(VALUE), 
    `datebirth`=(VALUE), 
    `inn`=(VALUE), 
    `stat`=(VALUE), 
    `golovagospod`=(VALUE), 
    `dateofdeath` =(VALUE),
	`reasondeath` =(VALUE)
WHERE 
    `idpeople`=(VALUE)";
        #endregion
        #region PeopleDelete - удаляет человека по ИД
        public static string PeopleDelete = @"DELETE FROM `people` WHERE `idpeople` = (VALUE)";
        #endregion
        #endregion
      
        #region House SQL

        public static string HouseView = @"";

        #endregion

        #region Land SQL

        public static string LandView = @"
SELECT 
    `land`.`idLand` AS `idland`,
    `land`.`number` AS `Кадастровий номер`,
    `land`.`square` AS `Площа`,
    `type_land` AS `Тип земельної ділянки`
FROM
    `land`
JOIN 
    `directory_land` ON ((`land`.`type` = `directory_land`.`iddirectory_land`))";

        #endregion

        #region Edditional SQL

        public static string PgoTypeShow = @"SELECT  idpgo_type AS `Номер типу`, type AS `Описання` FROM pgo_type";
        public static string StreetShow = @"SELECT id_street, street_name AS `Вулиця` FROM directory_street;";
        public static string VillageShow = @"SELECT id_village, village_name AS `Населений пункт` FROM directory_village;";
   
        public static string StreetIdGet = @"SELECT id_street FROM  directory_street where street_name = '(VALUE)';";
        public static string VillageIdGet = @"SELECT id_village FROM  directory_village where village_name = '(VALUE)';";
        public static string PgoTypeName = @"SELECT type from pgo_type WHERE pgo_type.idpgo_type=(VALUE)";

        #endregion

        #region Education SQL
        #region EducationView - отображает таблицу образований человека
        public static string EducationView = @"
select 
    ideducation,
    education_type AS `Освітній рівень`, 
    study AS `Навчання`, 
    institution AS `Навчальний заклад`, 
    startdate AS `Початок навчання`, 
    endDate AS `Кінець навчання`
from 
    education
inner join 
    directory_education on (education.type = directory_education.id_education) 
where 
    id_people = (VALUE)";
        #endregion
        #region EducationInsert - добавляет образование в таблицу образований человека
        public static string EducationInsert = @"
INSERT INTO education 
	(type, study, institution, startdate, endDate, idpeople) 
VALUES 
	((VALUE),(VALUE), (VALUE), (VALUE), (VALUE), (VALUE))";
        #endregion
        #region EducationUpadte - обновляет одно образование в таблице образований человека
        public static string EducationUpadte = @"
UPDATE
	education 
SET
	type=(VALUE),
	study=(VALUE),
	institution=(VALUE),
	startdate=(VALUE),
	endDate=(VALUE),
WHERE 
    id_people=(VALUE)";
        #endregion
        #region EducationUpadte - обновляет одно образование в таблице образований человека
        public static string EducationOneQuery = @"
SELECT 
    type, 
    study, 
    institution, 
    startdate, 
    endDate
FROM 
    pgo.education 
where 
    id_people = (VALUE) 
    and 
    ideducation=(VALUE);";
        #endregion
        #endregion

        #region Work SQL
        #region WorkView

        public static string WorkView = @"
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
	id_people = (VALUE)";

        #endregion
        #region 
        public static string WorkInsert = @"
INSERT INTO work 
	(post, workdescription, datestart, dateend, info, id_people) 
VALUES 
	((VALUE),(VALUE), (VALUE), (VALUE), (VALUE), (VALUE))";
        #endregion
        #region 
        public static string WorkUpadte = @"
UPDATE
	work 
SET
	post=(VALUE),
	workdescription=(VALUE),
	datestart=(VALUE),
	dateend=(VALUE),
	info=(VALUE)
WHERE 
    id_people=(VALUE)
and 
    idwork = (VALUE)";
        #endregion
        #region
        public static string WorkOneQuery = @"
select 	
	post,workdescription, datestart,dateend,info
from 
	work 
where 
	id_people = (VALUE) 
    and 
    idwork = (VALUE)";
        #endregion
       
        #endregion

        #region Registration SQL
        #region RegistrationView

        public static string RegistrationView = @"
select 
	concat (id_pgo, id_npgo) as 'Код ПГО',
	datep as 'Дата прибуття',
	datev as 'Дата вибуття', 
	tunchV as 'Тимчасово відсутній',
	reason as 'Причина', 
	type as 'Тип регітрації'
from 
	registration 
where 
	id_people=(VALUE)";

        #endregion
        #region 
        public static string RegistrationInsert = @"
insert into registration
( datep, datev, tunchV, reason, goal, type, address, id_pgo, id_npgo, id_people)
values ((VALUE),(VALUE),(VALUE),(VALUE),(VALUE),(VALUE),(VALUE),(VALUE),(VALUE),(VALUE))";
        #endregion
        #region 
        public static string RegistrationUpadte = @"
UPDATE
	registration
SET
	datep = (VALUE),
	datev = (VALUE),
	tunchV = (VALUE),
	reason = (VALUE),
	goal = (VALUE),
	type = (VALUE),
	address = (VALUE),
	id_pgo = (VALUE),
	id_npgo = (VALUE)	
WHERE
	id_people = (VALUE)";
        #endregion
        #endregion

        #region Document SQL
        #region DocumentView

        public static string DocumentView = @"select 
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
	id_people=(VALUE) ";

        #endregion
        #region 
        public static string DocumentInsert = @"
insert into document
(number, serya, type, kemVudan, dateStart, DateEnd, base, info,id_people)
values ((Value),(Value),(Value),(Value),(Value),(Value),(Value),(Value),(Value))
";
        #endregion
        #region 
        public static string DocumentUpadte = @"
Update document
set
	number=(Value),
	serya=(Value),
	typekem=(Value),
	Vudan=(Value),
	dateStart=(Value),
	DateEnd=(Value),
	base=(Value),
	info=(Value)
where id_people=(Value)
";
        #endregion
        #endregion

        #region Family SQL
        #region FamilyView

        public static string FamilyView = @"
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

where id_pr=(VALUE)";

        #endregion
        #region 
        public static string FamilyInsert = @"

";
        #endregion
        #region 
        public static string FamilyUpadte = @"

";
        #endregion
        #endregion

        #region Benefit SQL
        #region BenefitView

        public static string BenefitView = @"
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
	id_people=(VALUE)";
        #endregion
        #region 
        public static string BenefitInsert = @"
insert into lgota
(document, date, type, info, kemVudan, dateEnd, p_ll, id_people)
values ((Value),(Value),(Value),(Value),(Value),(Value),(Value),(Value))
";
        #endregion
        #region 
        public static string BenefitUpadte = @"
Update lgota
set
	document=(Value),
	date=(Value),
	type=(Value),
	info=(Value),
	kemVudan=(Value),
	dateEnd=(Value),
	p_ll=(Value)
where id_people=(Value)
";
        #endregion
        #endregion

        #region

        #endregion
    }
}