create table AFFIL_SEPARAZ (
     CodPaziente char(16) not null,
     CodMedico char(16) not null,
     Data_ date not null,
     A_S char(1) not null,
     constraint IDAFFIL_SEPARAZ primary key (CodPaziente, CodMedico, Data_));

create table APPUNTAMENTO (
     CodPersona char(16) not null,
     Data_ date not null,
     Ora varchar(5) not null,
     constraint IDAPPUNTAMENTO_ID primary key (CodPersona, Data_, Ora));

create table ASSUNZIONE_FARMACO (
     CodFarmaco int not null,
     CodPaziente char(16) not null,
     DataPrescrizione date not null,
     DataFineAssunzione date,
     constraint IDASSUNZIONE_FARMACO primary key (CodFarmaco, CodPaziente, DataPrescrizione));

create table ATTREZZATURA (
     Codice int not null,
     Nome varchar(25) not null,
     Prezzo_Unitario numeric(4,2) not null,
     constraint IDATTREZZATURA_ID primary key (Codice));

create table ESAME  (
     CodEsame  int not null,
     Nome varchar(25) not null,
     constraint IDTIPI_ESAME_ID primary key (CodEsame ));

create table ESAURITA (
     CodPersona char(16) not null,
     Data_ date not null,
     Ora varchar(5) not null,
     CodAttrezzatura int not null,
     Quantità int not null,
     constraint IDESAURITA primary key (CodAttrezzatura, CodPersona, Data_, Ora));

create table ESEC_ESAME (
     CodPaziente char(16) not null,
     CodEsame int not null,
     Data_ date not null,
     Esito varchar(500),
     constraint IDESEC_ESAME primary key (CodEsame , CodPaziente, Data_));

create table FARMACO (
     CodFarmaco int not null,
     Nome varchar(30) not null,
     EffettiCollaterali varchar(500),
     constraint IDFARMACO_ID primary key (CodFarmaco));

create table MEDICO (
     Nome  varchar(25) not null,
     Cognome varchar(30) not null,
     CodFiscale char(16) not null,
     Telefono varchar(12) not null,
     Sesso char(1) not null,
     constraint IDMEDICO primary key (CodFiscale));

create table PATOLOGIA (
     CodPaziente char(16) not null,
     Nome varchar(25) not null,
     DataDiagnosi date not null,
     Tipologia varchar(200) not null,
     Descrizione varchar(500),
     constraint IDPATOLOGIA primary key (CodPaziente, Nome, DataDiagnosi));

create table PAZIENTE (
     Nome  varchar(25) not null,
     Cognome varchar(30) not null,
     CodFiscale char(16) not null,
     Telefono varchar(12) not null,
     Sesso char(1) not null,
     Via varchar(50) not null,
     NumeroCivico int,
     Città varchar(25) not null,
     CAP char(5) not null,
     CittaNascita varchar(25) not null,
     DataNascita date not null,
     DataMorte date,
     constraint IDPAZIENTE primary key (CodFiscale));

create table PRESCRIZIONE (
     CodPersona char(16) not null,
     Data_ date not null,
     Ora varchar(5) not null,
     CodTerapia int not null,
     Durata int not null,
     Numero_Somministrazioni int,
     Dose_Somministrazione numeric(4,2),
     constraint IDPRESCRIZIONE primary key (CodPersona, Data_, Ora, CodTerapia));

create table QUANTITA (
     CodAttrezzatura int not null,
     NumeroElementi int not null,
     constraint FKpresente_ID primary key (CodAttrezzatura));

create table RIFORNIMENTO (
     CodAttrezzatura int not null,
     Quantità int not null,
     constraint FKricomprare_ID primary key (CodAttrezzatura));

create table SCHEDA_CLINICA (
     CodPaziente char(16) not null,
     Fumatore char(2) not null,
     Sport char(2) not null,
     Alcol char(2) not null,
     constraint FKpossiede_ID primary key (CodPaziente));

create table TERAPIA (
     CodTerapia int not null,
     CodFarmaco int,
     CodEsame  int,
     Nome varchar(25) not null,
     constraint IDTERAPIA primary key (CodTerapia),
     constraint FKcontieneFarmaco_ID unique (CodFarmaco),
     constraint FKcontieneEsame_ID unique (CodEsame ));

create table TRATTAMENTO (
     CodPersona char(16) not null,
     Data_ date not null,
     Ora varchar(5) not null,
     Descrizione varchar(200) not null,
     Diagnosi varchar(500),
     Tipologia varchar(200) not null,
     constraint FKprenota_ID primary key (CodPersona, Data_, Ora));
