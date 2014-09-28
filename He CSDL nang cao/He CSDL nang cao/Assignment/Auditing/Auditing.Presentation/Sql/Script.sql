create table user_log
(
   user_id           varchar2(30),
   session_id           number(8),
   host              varchar2(30),
   last_program      varchar2(48),
   last_action       varchar2(32),
   last_module       varchar2(32),
   logon_day                 date,
   logon_time        varchar2(10),
   logoff_day                date,
   logoff_time       varchar2(10),
   elapsed_minutes       number(8)
);

create or replace trigger logon_audit_trigger
AFTER LOGON ON DATABASE
BEGIN
insert into user_log values(
   user,
   sys_context('USERENV','SESSIONID'),
   sys_context('USERENV','HOST'),
   null,
   null,
   null,
   sysdate,
   to_char(sysdate, 'hh24:mi:ss'),
   null,
   null,
   null
);
END;

create or replace trigger logoff_audit_trigger
BEFORE LOGOFF ON DATABASE
BEGIN
-- ***************************************************
-- Update the last action accessed
-- ***************************************************
update
user_log
set
last_action = (select action from v$session where     
sys_context('USERENV','SESSIONID') = audsid)
where
sys_context('USERENV','SESSIONID') = session_id;
--***************************************************
-- Update the last program accessed
-- ***************************************************
update
user_log
set
last_program = (select program from v$session where     
sys_context('USERENV','SESSIONID') = audsid)
where
sys_context('USERENV','SESSIONID') = session_id;
-- ***************************************************
-- Update the last module accessed
-- ***************************************************
update
user_log
set
last_module = (select module from v$session where     
sys_context('USERENV','SESSIONID') = audsid)
where
sys_context('USERENV','SESSIONID') = session_id;
-- ***************************************************
-- Update the logoff day
-- ***************************************************
update
   user_log
set
   logoff_day = sysdate
where
   sys_context('USERENV','SESSIONID') = session_id;
-- ***************************************************
-- Update the logoff time
-- ***************************************************
update
   user_log
set
   logoff_time = to_char(sysdate, 'hh24:mi:ss')
where
   sys_context('USERENV','SESSIONID') = session_id;
-- ***************************************************
-- Compute the elapsed minutes
-- ***************************************************
update
user_log
set
elapsed_minutes =     
round((logoff_day - logon_day)*1440)
where
sys_context('USERENV','SESSIONID') = session_id;
END;