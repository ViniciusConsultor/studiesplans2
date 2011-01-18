Use [SP]
GO

insert into privilages values(N'Edycja');
insert into privilages values(N'Recenzowanie');
insert into privilages values(N'Przegl¹danie');
insert into privilages values(N'Archiwizacja');
insert into privilages values(N'U¿ytkownicy');

Insert into roles values(N'Administrator');
declare @roleid int
declare @edit int, @rec int, @prev int, @arch int, @user int
select @roleId = roleid from roles where name=N'Administrator';
select @edit = privilageid from privilages where name = N'Edycja';
select @rec = privilageid from privilages where name = N'Recenzowanie';
select @prev = privilageid from privilages where name = N'Przegl¹danie';
select @arch = privilageid from privilages where name = N'Archiwizacja';
select @user = privilageid from privilages where name = N'U¿ytkownicy';
Insert into rolesprivilages values(@roleId, @edit)
Insert into rolesprivilages values(@roleId, @rec)
Insert into rolesprivilages values(@roleId, @prev)
Insert into rolesprivilages values(@roleId, @arch)
Insert into rolesprivilages values(@roleId, @user)

Insert into users values(N'admin', N'49F9F7EE8FA74F4290870CA3C68F01A6', NULL, @roleid, NULL);
declare @userid int
select @userid = userid from users where name=N'admin';

Insert into faculties values(N'Informatyka');
declare @facultyid int
select @facultyid=facultyid from faculties where name=N'Informatyka';
Insert into departaments values(N'Automatykie Elektroniki i Informatyki');
declare @departamentid int
select @departamentid=departamentid from departaments where name=N'Automatykie Elektroniki i Informatyki';
insert into facultiesdepartaments values(@facultyid, @departamentid);

insert into studiestypes values(N'Stacjonarne 1-go stopnia');
declare @studiestypesid int
select @studiestypesid = studiestypeid from studiestypes where name = N'Stacjonarne 1-go stopnia';

insert into plans values(N'Informatyka 1st', null, null, 1, 7, 0, @departamentid, @facultyid, @studiestypesid, @userid, null, 0);
declare @planid int
select @planid= planid from plans where name=N'Informatyka 1st'

insert into subjects values(N'Fizyka')
declare @sub1 int
select @sub1 = subjectid from subjects where name=N'Fizyka';

insert into subjects values(N'Wychowanie Fizyczne')
declare @sub2 int
select @sub2 = subjectid from subjects where name=N'Wychowanie Fizyczne';

insert into subjects values(N'Analiza Matematyczna i Algebra Liniowa')
declare @sub3 int
select @sub3 = subjectid from subjects where name=N'Analiza Matematyczna i Algebra Liniowa';

insert into subjects values(N'Podstawy Programowania Komputerów')
declare @sub4 int
select @sub4 = subjectid from subjects where name=N'Podstawy Programowania Komputerów';

insert into subjects values(N'Jêzyk Angielski')
declare @sub5 int
select @sub5 = subjectid from subjects where name=N'Jêzyk Angielski';

insert into subjects values(N'Podstawy Elektrotechniki')
declare @sub6 int
select @sub6 = subjectid from subjects where name=N'Podstawy Elektrotechniki';

insert into subjects values(N'Teoria Uk³adów Cyfrowych')
declare @sub7 int
select @sub7 = subjectid from subjects where name=N'Teoria Uk³adów Cyfrowych';

insert into subjects values(N'Arytmetyka Systemów Cyfrowych')
declare @sub8 int
select @sub8 = subjectid from subjects where name=N'Arytmetyka Systemów Cyfrowych';

insert into subjects values(N'Podstawy Informatyki')
declare @sub9 int
select @sub9 = subjectid from subjects where name=N'Podstawy Informatyki';

insert into semesters values(N'Pierwszy', 1, 1)
declare @semester int
select @semester = semesterid from semesters where Name=N'Pierwszy';

declare @sd1 int, @sd2 int, @sd3 int, @sd4 int, @sd5 int, @sd6 int, @sd7 int, @sd8 int, @sd9 int

insert into subjectsdata(subjectid, semesterid, facultyid, ects, isexam, specializationdataid, departamentid, instituteid, iselective, isgeneral) values(@sub1, @semester, @facultyid, 5, 1, null, @departamentid, null, 0, 1)
select @sd1 = subjectdataid from subjectsdata where subjectid=@sub1

insert into subjectsdata values(@sub2, @semester, @facultyid, 0, 0, null, @departamentid, null, 0, 1)
select @sd2 = subjectdataid from subjectsdata where subjectid=@sub2

insert into subjectsdata values(@sub3, @semester, @facultyid, 6, 1, null, @departamentid, null, 0, 1)
select @sd3 = subjectdataid from subjectsdata where subjectid=@sub3

insert into subjectsdata values(@sub4, @semester, @facultyid, 4, 1, null, @departamentid, null, 0, 1)
select @sd4 = subjectdataid from subjectsdata where subjectid=@sub4

insert into subjectsdata values(@sub5, @semester, @facultyid, 1, 0, null, @departamentid, null, 0, 1)
select @sd5 = subjectdataid from subjectsdata where subjectid=@sub5

insert into subjectsdata values(@sub6, @semester, @facultyid, 4, 0, null, @departamentid, null, 0, 1)
select @sd6 = subjectdataid from subjectsdata where subjectid=@sub6

insert into subjectsdata values(@sub7, @semester, @facultyid, 3, 0, null, @departamentid, null, 0, 1)
select @sd7 = subjectdataid from subjectsdata where subjectid=@sub7

insert into subjectsdata values(@sub8, @semester, @facultyid, 2, 0, null, @departamentid, null, 0, 1)
select @sd8 = subjectdataid from subjectsdata where subjectid=@sub8

insert into subjectsdata values(@sub9, @semester, @facultyid, 5, 0, null, @departamentid, null, 0, 1)
select @sd9 = subjectdataid from subjectsdata where subjectid=@sub9

insert into plansdata values(@planid, @sd1);
insert into plansdata values(@planid, @sd2);
insert into plansdata values(@planid, @sd3);
insert into plansdata values(@planid, @sd4);
insert into plansdata values(@planid, @sd5);
insert into plansdata values(@planid, @sd6);
insert into plansdata values(@planid, @sd7);
insert into plansdata values(@planid, @sd8);
insert into plansdata values(@planid, @sd9);

insert into subjecttypes values(N'Wyk³ad')
declare @st1 int
select @st1 = subjecttypeid from subjecttypes where name = N'Wyk³ad'

insert into subjecttypes values(N'Æwiczenia')
declare @st2 int
select @st2 = subjecttypeid from subjecttypes where name = N'Æwiczenia'

insert into subjecttypes values(N'Laboratorium')
declare @st3 int
select @st3 = subjecttypeid from subjecttypes where name = N'Laboratorium'

insert into subjecttypesdata values(@sd3, @st1, 2)
insert into subjecttypesdata values(@sd3, @st2, 2)

insert into subjecttypesdata values(@sd1, @st1, 2)
insert into subjecttypesdata values(@sd1, @st2, 1)

insert into subjecttypesdata values(@sd4, @st1, 2)
insert into subjecttypesdata values(@sd4, @st3, 2)

insert into subjecttypesdata values(@sd5, @st2, 2)

insert into subjecttypesdata values(@sd6, @st1, 2)
insert into subjecttypesdata values(@sd6, @st2, 1)

insert into subjecttypesdata values(@sd7, @st1, 2)
insert into subjecttypesdata values(@sd7, @st2, 1)

insert into subjecttypesdata values(@sd8, @st1, 2)

insert into subjecttypesdata values(@sd9, @st1, 2)
insert into subjecttypesdata values(@sd9, @st2, 2)

insert into subjecttypesdata values(@sd2, @st2, 2)