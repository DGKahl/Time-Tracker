--
-- File generated with SQLiteStudio v3.3.0 on Di Sep 21 11:04:42 2021
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


-- Table: TimerTimes
CREATE TABLE TimerTimes (
    TimerID INTEGER REFERENCES Timer (ID),
    TimesID INTEGER REFERENCES Times (ID) ON DELETE CASCADE,
    PRIMARY KEY (
        TimerID,
        TimesID
    )
);


-- Table: Times
CREATE TABLE Times (
    ID    INTEGER  PRIMARY KEY AUTOINCREMENT,
    Start DATETIME,
    [End] DATETIME,
    Zeit  TIME,
    Notiz TEXT
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
