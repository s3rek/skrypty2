CREATE EXTENSION dblink;
truncate table gminy;

insert into gminy
select *
from dblink('dbname=postgres host=192.168.1.254 dbname=PRG_GUGiK user=postgres password=postgres',
            'select ogc_fid,the_geom,iip_identy,teryt,nazwa from prg_gminy')
       as gminy( ogc_fid integer,
  the_geom geometry,
  iip_identy character varying(36),
  teryt numeric(7,0),
  nazwa character varying(27));