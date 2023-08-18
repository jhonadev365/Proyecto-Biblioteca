create database ExamenLibro
use ExamenLibro

create table libro(
	ISBN varchar(50) primary key,
	autor varchar(100),
	editorial varchar(70),
	edicion varchar(50),
	año date
)
truncate table libro
insert into libro values ('111-123-123', 'Edwardo Saenz', ' Pearson', '3ra', '2012-02-10' )
insert into libro values ('112-123-123', 'Melina BanCough', 'Spring', '2ra', '2015-04-23' )
insert into libro values ('113-123-123', 'Ifit Gutierrez', ' O relly', '1ra', '1996-01-3' )

insert into libro values ('114-123-123', 'Emilia Bernard', 'Spring', '4ra', '1879-05-13' )
insert into libro values ('115-123-123', 'Facundo Paredes', 'McGrawHill', '3ra', '2002-06-12' )
insert into libro values ('116-123-123', 'Ignacio Medina', ' Cenage', '3ra', '2015-12-12' )
insert into libro values ('117-123-123', 'Juan Carlos Hernandez', ' Pearson', '5ra', '2000-01-01' )
insert into libro values ('118-123-123', 'Beowolf Smith', 'Cenage', '7ra', '1999-09-19' )

insert into libro values ('119-123-123', 'Javier Santaolla', ' Pearson', '3ra', '2012-02-10' )
insert into libro values ('110-124-123', 'Ignacio Felipe', 'Cenage', '1ra', '1896-11-30' )
insert into libro values ('111-125-123', 'Tito Sanders', ' O relly', '1ra', '1989-11-19' )