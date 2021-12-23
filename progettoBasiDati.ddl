-- *********************************************
-- * Standard SQL generation                   
-- *--------------------------------------------
-- * DB-MAIN version: 10.0.3              
-- * Generator date: Aug 17 2017              
-- * Generation date: Wed May 23 11:27:30 2018 
-- * LUN file: Z:\Google Drive\Università\Basi di Dati\Laboratorio\Progetto Basi Dati\progettoBasiDati.lun 
-- * Schema: Studio Medico/Dentistico Logico/1-1 
-- ********************************************* 


-- Database Section
-- ________________ 

create database Studio Medico/Dentistico Logico;


-- DBSpace Section
-- _______________


-- Tables Section
-- _____________ 

create table AFFIL/SEPARAZ (
     CodPaziente char(16) not null,
     CodMedico char(16) not null,
     Data date not null,
     A/S char not null,
     constraint IDAFFIL/SEPARAZ primary key (CodPaziente, CodMedico, Data));

create table APPUNTAMENTO (
     CodPersona char(16) not null,
     Data date not null,
     Ora varchar(1) not null,
     constraint IDAPPUNTAMENTO_ID primary key (CodPersona, Data, Ora));

create table ASSUNZIONE FARMACO (
     CodFarmaco numeric(1) not null,
     CodPaziente char(16) not null,
     DataPrescrizione date not null,
     DataFineAssunzione date,
     constraint IDASSUNZIONE FARMACO primary key (CodFarmaco, CodPaziente, DataPrescrizione));

create table ATTREZZATURA (
     Codice numeric(1) not null,
     Nome varchar(1) not null,
     Prezzo Unitario numeric(4,2) not null,
     constraint IDATTREZZATURA_ID primary key (Codice));

create table ESAME  (
     CodEsame  numeric(1) not null,
     Nome varchar(1) not null,
     constraint IDTIPI ESAME _ID primary key (CodEsame ));

create table ESAURITA (
     CodPersona char(16) not null,
     Data date not null,
     Ora varchar(1) not null,
     CodAttrezzatura numeric(1) not null,
     Quantità numeric(1) not null,
     constraint IDESAURITA primary key (CodAttrezzatura, CodPersona, Data, Ora));

create table ESEC ESAME (
     CodPaziente char(16) not null,
     CodEsame  numeric(1) not null,
     Data date not null,
     Esito varchar(1),
     constraint IDESEC ESAME primary key (CodEsame , CodPaziente, Data));

create table FARMACO (
     CodFarmaco numeric(1) not null,
     Nome varchar(1) not null,
     Effetti Collaterali varchar(1),
     constraint IDFARMACO_ID primary key (CodFarmaco));

create table MEDICO (
     Nome  varchar(1) not null,
     Cognome varchar(1) not null,
     Cod Fiscale char(16) not null,
     Telefono varchar(1) not null,
     Sesso char(1) not null,
     constraint IDMEDICO primary key (Cod Fiscale));

create table PATOLOGIA (
     CodPaziente char(16) not null,
     Nome varchar(1) not null,
     Data Diagnosi date not null,
     Tipologia varchar(1) not null,
     Descrizione varchar(1),
     constraint IDPATOLOGIA primary key (CodPaziente, Nome, Data Diagnosi));

create table PAZIENTE (
     Nome  varchar(1) not null,
     Cognome varchar(1) not null,
     Cod Fiscale char(16) not null,
     Telefono varchar(1) not null,
     Sesso char(1) not null,
     Via varchar(1) not null,
     Numero Civico numeric(1),
     Città varchar(1) not null,
     CAP char(5) not null,
     Citta Nascita varchar(1) not null,
     Data Nascita date not null,
     Data Morte date,
     constraint IDPAZIENTE primary key (Cod Fiscale));

create table PRESCRIZIONE (
     CodPersona char(16) not null,
     Data date not null,
     Ora varchar(1) not null,
     CodTerapia numeric(1) not null,
     Durata numeric(3) not null,
     Numero Somministrazioni numeric(3),
     Dose Somministrazione numeric(4,2),
     constraint IDPRESCRIZIONE primary key (CodPersona, Data, Ora, CodTerapia));

create table QUANTITA (
     CodAttrezzatura numeric(1) not null,
     NumeroElementi numeric(1) not null,
     constraint FKpresente_ID primary key (CodAttrezzatura));

create table RIFORNIMENTO (
     CodAttrezzatura numeric(1) not null,
     Quantità numeric(1) not null,
     constraint FKricomprare_ID primary key (CodAttrezzatura));

create table SCHEDA CLINICA (
     CodPaziente char(16) not null,
     Fumatore char not null,
     Sport char not null,
     Alcol char not null,
     constraint FKpossiede_ID primary key (CodPaziente));

create table TERAPIA (
     CodTerapia numeric(1) not null,
     CodFarmaco numeric(1),
     CodEsame  numeric(1),
     Nome varchar(1) not null,
     constraint IDTERAPIA primary key (CodTerapia),
     constraint FKcontieneFarmaco_ID unique (CodFarmaco),
     constraint FKcontieneEsame_ID unique (CodEsame ));

create table TRATTAMENTO (
     CodPersona char(16) not null,
     Data date not null,
     Ora varchar(1) not null,
     Descrizione varchar(1) not null,
     Diagnosi varchar(1),
     Tipologia varchar(1) not null,
     constraint FKprenota_ID primary key (CodPersona, Data, Ora));


-- Constraints Section
-- ___________________ 

alter table AFFIL/SEPARAZ add constraint FKesegue
     foreign key (CodMedico)
     references MEDICO;

alter table AFFIL/SEPARAZ add constraint FKpartecipa
     foreign key (CodPaziente)
     references PAZIENTE;

alter table APPUNTAMENTO add constraint IDAPPUNTAMENTO_CHK
     check(exists(select * from TRATTAMENTO
                  where TRATTAMENTO.CodPersona = CodPersona and TRATTAMENTO.Data = Data and TRATTAMENTO.Ora = Ora)); 

alter table APPUNTAMENTO add constraint FKfissare
     foreign key (CodPersona)
     references PAZIENTE;

alter table ASSUNZIONE FARMACO add constraint FKregistra
     foreign key (CodPaziente)
     references SCHEDA CLINICA;

alter table ASSUNZIONE FARMACO add constraint FKprevede
     foreign key (CodFarmaco)
     references FARMACO;

alter table ATTREZZATURA add constraint IDATTREZZATURA_CHK
     check(exists(select * from QUANTITA
                  where QUANTITA.CodAttrezzatura = Codice)); 

alter table ESAME  add constraint IDTIPI ESAME _CHK
     check(exists(select * from TERAPIA
                  where TERAPIA.CodEsame  = CodEsame )); 

alter table ESAURITA add constraint FKesa_ATT
     foreign key (CodAttrezzatura)
     references ATTREZZATURA;

alter table ESAURITA add constraint FKesa_TRA
     foreign key (CodPersona, Data, Ora)
     references TRATTAMENTO;

alter table ESEC ESAME add constraint FKattua
     foreign key (CodEsame )
     references ESAME ;

alter table ESEC ESAME add constraint FKsvolto
     foreign key (CodPaziente)
     references SCHEDA CLINICA;

alter table FARMACO add constraint IDFARMACO_CHK
     check(exists(select * from TERAPIA
                  where TERAPIA.CodFarmaco = CodFarmaco)); 

alter table PATOLOGIA add constraint FKpresenta
     foreign key (CodPaziente)
     references SCHEDA CLINICA;

alter table PRESCRIZIONE add constraint FKpre_TER
     foreign key (CodTerapia)
     references TERAPIA;

alter table PRESCRIZIONE add constraint FKpre_TRA
     foreign key (CodPersona, Data, Ora)
     references TRATTAMENTO;

alter table QUANTITA add constraint FKpresente_FK
     foreign key (CodAttrezzatura)
     references ATTREZZATURA;

alter table RIFORNIMENTO add constraint FKricomprare_FK
     foreign key (CodAttrezzatura)
     references ATTREZZATURA;

alter table SCHEDA CLINICA add constraint FKpossiede_FK
     foreign key (CodPaziente)
     references PAZIENTE;

alter table TERAPIA add constraint FKcontieneFarmaco_FK
     foreign key (CodFarmaco)
     references FARMACO;

alter table TERAPIA add constraint FKcontieneEsame_FK
     foreign key (CodEsame )
     references ESAME ;

alter table TRATTAMENTO add constraint FKprenota_FK
     foreign key (CodPersona, Data, Ora)
     references APPUNTAMENTO;


-- Index Section
-- _____________ 

