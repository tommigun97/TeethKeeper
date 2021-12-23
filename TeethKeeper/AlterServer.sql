alter table AFFIL_SEPARAZ add constraint FKesegue
     foreign key (CodMedico)
     references MEDICO;

alter table AFFIL_SEPARAZ add constraint FKpartecipa
     foreign key (CodPaziente)
     references PAZIENTE;

/*alter table APPUNTAMENTO add constraint IDAPPUNTAMENTO_CHK
     check(exists(select * from TRATTAMENTO
                  where TRATTAMENTO.CodPersona = CodPersona and TRATTAMENTO.Data = Data and TRATTAMENTO.Ora = Ora)); */

alter table APPUNTAMENTO add constraint FKfissare
     foreign key (CodPersona)
     references PAZIENTE;

alter table ASSUNZIONE_FARMACO add constraint FKregistra
     foreign key (CodPaziente)
     references SCHEDA_CLINICA;

alter table ASSUNZIONE_FARMACO add constraint FKprevede
     foreign key (CodFarmaco)
     references FARMACO;

/*alter table ATTREZZATURA add constraint IDATTREZZATURA_CHK
     check(exists(select * from QUANTITA
                  where QUANTITA.CodAttrezzatura = Codice)); 

alter table ESAME  add constraint IDTIPI ESAME _CHK
     check(exists(select * from TERAPIA
                  where TERAPIA.CodEsame  = CodEsame )); */

alter table ESAURITA add constraint FKesa_ATT
     foreign key (CodAttrezzatura)
     references ATTREZZATURA;

alter table ESAURITA add constraint FKesa_TRA
     foreign key (CodPersona, Data, Ora)
     references TRATTAMENTO;

alter table ESEC_ESAME add constraint FKattua
     foreign key (CodEsame )
     references ESAME ;

alter table ESEC_ESAME add constraint FKsvolto
     foreign key (CodPaziente)
     references SCHEDA_CLINICA;

/*alter table FARMACO add constraint IDFARMACO_CHK
     check(exists(select * from TERAPIA
                  where TERAPIA.CodFarmaco = CodFarmaco));*/

alter table PATOLOGIA add constraint FKpresenta
     foreign key (CodPaziente)
     references SCHEDA_CLINICA;

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

alter table SCHEDA_CLINICA add constraint FKpossiede_FK
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