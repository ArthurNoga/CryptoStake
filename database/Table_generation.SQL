-- -----------------------------------------------------------------------------
--             Génération d'une base de données pour
--                      Oracle Version 10g
--                        (29/10/2021 15:47:16)
-- -----------------------------------------------------------------------------
--      Nom de la base : MLR1
--      Projet : Espace de travail
--      Auteur : Noguera Arthur
--      Date de dernière modification : 8/10/2021 14:14:21
-- -----------------------------------------------------------------------------

DROP TABLE PERS CASCADE CONSTRAINTS;

DROP TABLE FACTURE CASCADE CONSTRAINTS;

DROP TABLE TRANSAC CASCADE CONSTRAINTS;

DROP TABLE COMPTE CASCADE CONSTRAINTS;

DROP TABLE CRYPTO CASCADE CONSTRAINTS;

-- -----------------------------------------------------------------------------
--       CREATION DE LA BASE 
-- -----------------------------------------------------------------------------

CREATE DATABASE MLR1;

-- -----------------------------------------------------------------------------
--       TABLE : PERS
-- -----------------------------------------------------------------------------

CREATE TABLE PERS
   (
    PERS_ID NUMBER(3)  NOT NULL,
    PERS_NOM VARCHAR2(32)  NOT NULL,
    PERS_PRENOM VARCHAR2(32)  NOT NULL,
    PERS_USERNAME VARCHAR2(32)  NULL,
    PERS_PASSWORD VARCHAR2(32)  NULL
,   CONSTRAINT PK_PERS PRIMARY KEY (PERS_ID)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : FACTURE
-- -----------------------------------------------------------------------------

CREATE TABLE FACTURE
   (
    COMPT_ID NUMBER(3)  NOT NULL,
    FACTURE_DATE_PERIOD DATE  NULL,
    FACTURE_PRIXTOTAL NUMBER(10,2)  NULL,
    FACTURE_ID NUMBER(3)  NOT NULL
,   CONSTRAINT PK_FACTURE PRIMARY KEY (FACTURE_ID)  
   ) ;

-- -----------------------------------------------------------------------------
--       INDEX DE LA TABLE FACTURE
-- -----------------------------------------------------------------------------

CREATE  INDEX I_FK_FACTURE_COMPTE
     ON FACTURE (COMPT_ID ASC)
    ;

-- -----------------------------------------------------------------------------
--       TABLE : TRANSAC
-- -----------------------------------------------------------------------------

CREATE TABLE TRANSAC
   (
    TRANSAC_ID NUMBER(5)  NOT NULL,
    COMPT_ID NUMBER(3)  NOT NULL,
    CRYPT_ID NUMBER(10)  NOT NULL,
    TRANSAC_DATE DATE  NOT NULL,
    TRANSAC_QUANTITÉ NUMBER(10)  NOT NULL,
    TRANSAC_TYPE NUMBER(1)  NOT NULL,
    TRANSAC_PRIX NUMBER(10,5)  NULL
,   CONSTRAINT PK_TRANSAC PRIMARY KEY (TRANSAC_ID)  
   ) ;

-- -----------------------------------------------------------------------------
--       INDEX DE LA TABLE TRANSAC
-- -----------------------------------------------------------------------------

CREATE  INDEX I_FK_TRANSAC_COMPTE
     ON TRANSAC (COMPT_ID ASC)
    ;

CREATE UNIQUE INDEX I_FK_TRANSAC_CRYPTO
     ON TRANSAC (CRYPT_ID ASC)
    ;

-- -----------------------------------------------------------------------------
--       TABLE : COMPTE
-- -----------------------------------------------------------------------------

CREATE TABLE COMPTE
   (
    COMPT_ID NUMBER(3)  NOT NULL,
    PERS_ID NUMBER(3)  NOT NULL,
    COMPT_VAL_FIAT NUMBER(10,3)  NOT NULL,
    COMPTE_VAL_CRYPTO NUMBER(10,2)  NULL
,   CONSTRAINT PK_COMPTE PRIMARY KEY (COMPT_ID)  
   ) ;

-- -----------------------------------------------------------------------------
--       INDEX DE LA TABLE COMPTE
-- -----------------------------------------------------------------------------

CREATE UNIQUE INDEX I_FK_COMPTE_PERS
     ON COMPTE (PERS_ID ASC)
    ;

-- -----------------------------------------------------------------------------
--       TABLE : CRYPTO
-- -----------------------------------------------------------------------------

CREATE TABLE CRYPTO
   (
    CRYPT_ID NUMBER(10)  NOT NULL,
    CRYPT_NOM VARCHAR2(32)  NOT NULL,
    CRYPT_ACHAT NUMBER(10,4)  NOT NULL,
    CRYPT_VENTE NUMBER(10,2)  NULL
,   CONSTRAINT PK_CRYPTO PRIMARY KEY (CRYPT_ID)  
   ) ;


-- -----------------------------------------------------------------------------
--       CREATION DES REFERENCES DE TABLE
-- -----------------------------------------------------------------------------


ALTER TABLE FACTURE ADD (
     CONSTRAINT FK_FACTURE_COMPTE
          FOREIGN KEY (COMPT_ID)
               REFERENCES COMPTE (COMPT_ID))   ;

ALTER TABLE TRANSAC ADD (
     CONSTRAINT FK_TRANSAC_COMPTE
          FOREIGN KEY (COMPT_ID)
               REFERENCES COMPTE (COMPT_ID))   ;

ALTER TABLE TRANSAC ADD (
     CONSTRAINT FK_TRANSAC_CRYPTO
          FOREIGN KEY (CRYPT_ID)
               REFERENCES CRYPTO (CRYPT_ID))   ;

ALTER TABLE COMPTE ADD (
     CONSTRAINT FK_COMPTE_PERS
          FOREIGN KEY (PERS_ID)
               REFERENCES PERS (PERS_ID))   ;


-- -----------------------------------------------------------------------------
--                FIN DE GENERATION
-- -----------------------------------------------------------------------------