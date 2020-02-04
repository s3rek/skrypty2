CREATE TABLE gminy2 AS 
SELECT substring(teryt::text,1,4) as teryt_powiat,nazwa,
	ST_Multi(ST_Union(the_geom)) as geom
	FROM gminy 
GROUP BY teryt_powiat,nazwa ORDER BY teryt_powiat;