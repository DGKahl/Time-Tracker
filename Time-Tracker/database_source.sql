--
-- File generated with SQLiteStudio v3.3.0 on So Sep 12 17:06:11 2021
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: Timer
CREATE TABLE Timer (
    ID           INTEGER PRIMARY KEY AUTOINCREMENT,
    Name         TEXT,
    Beschreibung TEXT,
    parallel     BOOLEAN DEFAULT (true),
    quickslot    INTEGER DEFAULT (0) 
);

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot
                  )
                  VALUES (
                      1,
                      Arbeit,
                      Testeintrag zum Tracken von Arbeitszeit,
                      false,
                      1
                  );

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot
                  )
                  VALUES (
                      2,
                      Privat,
                      Testeintrag zum Tracken von privater Zeit,
                      false,
                      2
                  );

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot
                  )
                  VALUES (
                      3,
                      Denken,
                      Testeintrag für parallele Tätigkeit,
                      true,
                      3
                  );

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot
                  )
                  VALUES (
                      4,
                      Programmieren,
                      Testeintrag für Quickslot-Tests,
                      false,
                      0
                  );


-- Table: TimerTimes
CREATE TABLE TimerTimes (
    TimerID INTEGER REFERENCES Timer (ID),
    TimesID INTEGER REFERENCES Times (ID),
    PRIMARY KEY (
        TimerID,
        TimesID
    )
);


-- Table: Times
CREATE TABLE Times (
    ID    INTEGER PRIMARY KEY AUTOINCREMENT,
    Datum DATE,
    Zeit  TEXT,
    Notiz TEXT
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
