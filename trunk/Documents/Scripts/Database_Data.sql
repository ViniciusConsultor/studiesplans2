insert into privilages values(N'Edycja');
insert into privilages values(N'Recenzowanie');
insert into privilages values(N'Przegl퉐anie');
insert into privilages values(N'Archiwizacja');
insert into privilages values(N'U퓓tkownicy');

Insert into roles values(N'Administrator');
declare @roleid int
declare @edit int, @rec int, @prev int, @arch int, @user int
select @roleId = roleid from roles where name=N'Administrator';
select @edit = privilageid from privilages where name = N'Edycja';
select @rec = privilageid from privilages where name = N'Recenzowanie';
select @prev = privilageid from privilages where name = N'Przegl퉐anie';
select @arch = privilageid from privilages where name = N'Archiwizacja';
select @user = privilageid from privilages where name = N'U퓓tkownicy';
Insert into rolesprivilages values(@roleId, @edit)
Insert into rolesprivilages values(@roleId, @rec)
Insert into rolesprivilages values(@roleId, @prev)
Insert into rolesprivilages values(@roleId, @arch)
Insert into rolesprivilages values(@roleId, @user)

Insert into users values(N'admin', N'49F9F7EE8FA74F4290870CA3C68F01A6', NULL, @roleid, NULL);


