--
-- File generated with SQLiteStudio v3.3.0 on Mi Dez 8 20:55:00 2021
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: Timer
CREATE TABLE Timer (
    ID           INTEGER PRIMARY KEY AUTOINCREMENT,
    Name         TEXT    UNIQUE,
    Beschreibung TEXT,
    parallel     BOOLEAN DEFAULT (true),
    quickslot    INTEGER DEFAULT (0),
    Archived     BOOLEAN DEFAULT false
);

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot,
                      Archived
                  )
                  VALUES (
                      1,
                      Arbeit,
                      Testeintrag zum Tracken von Arbeitszeit,
                      false,
                      1,
                      0
                  );

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot,
                      Archived
                  )
                  VALUES (
                      2,
                      Privat,
                      Testeintrag zum Tracken von privater Zeit,
                      false,
                      2,
                      0
                  );

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot,
                      Archived
                  )
                  VALUES (
                      3,
                      Denken,
                      Testeintrag für parallele Tätigkeit,
                      true,
                      3,
                      0
                  );

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot,
                      Archived
                  )
                  VALUES (
                      4,
                      Programmieren,
                      Testeintrag für Quickslot-Tests,
                      false,
                      0,
                      0
                  );

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot,
                      Archived
                  )
                  VALUES (
                      5,
                      Hausarbeit,
                      Testeintrag für Spatzl,
                      false,
                      0,
                      0
                  );

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot,
                      Archived
                  )
                  VALUES (
                      6,
                      Organisation,
                      Testeintrag für mich,
                      true,
                      0,
                      0
                  );


-- Table: Times
CREATE TABLE Times (
    ID      INTEGER  PRIMARY KEY AUTOINCREMENT,
    Start   DATETIME,
    [End]   DATETIME,
    Zeit    STRING,
    Notiz   TEXT,
    TimerID INTEGER  REFERENCES Timer (ID) 
                     NOT NULL ON CONFLICT ROLLBACK
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
