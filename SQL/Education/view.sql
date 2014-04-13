select education_type, study, institution, startdate, endDate
from education
inner join directory_education on (education.type = directory_education.id_education) 
where id_people = (VALUE)