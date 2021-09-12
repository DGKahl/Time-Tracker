--
-- File generated with SQLiteStudio v3.3.0 on So Sep 12 11:09:06 2021
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
    parallel     BOOLEAN DEFAULT (true) 
);

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel
                  )
                  VALUES (
                      1,
                      Arbeit,
                      Testeintrag zum Tracken von Arbeitszeit,
                      false
                  );

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel
                  )
                  VALUES (
                      2,
                      Privat,
                      Testeintrag zum Tracken von privater Zeit,
                      false
                  );

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel
                  )
                  VALUES (
                      3,
                      Denken,
                      Testeintrag für parallele Tätigkeit,
                      true
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
