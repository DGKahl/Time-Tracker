--
-- File generated with SQLiteStudio v3.3.0 on Di Feb 1 09:29:23 2022
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: Settings
CREATE TABLE Settings (
    ID               INTEGER PRIMARY KEY,
    Tracking         STRING,
    Trackinginterval STRING,
    savedlogs        STRING
);

INSERT INTO Settings (
                         ID,
                         Tracking,
                         Trackinginterval,
                         savedlogs
                     )
                     VALUES (
                         1,
                         True,
                         daily,
                         10
                     );


-- Table: Timer
CREATE TABLE Timer (
    ID           INTEGER PRIMARY KEY AUTOINCREMENT,
    Name         TEXT    UNIQUE
                         NOT NULL,
    Beschreibung TEXT,
    parallel     BOOLEAN DEFAULT (true),
    quickslot    INTEGER DEFAULT (0),
    Archived     BOOLEAN DEFAULT false,
    Color        INTEGER UNIQUE
);

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot,
                      Archived,
                      Color
                  )
                  VALUES (
                      1,
                      Arbeit,
                      Testeintrag zum Tracken von Arbeitszeit,
                      false,
                      2,
                      0,
                      NULL
                  );

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot,
                      Archived,
                      Color
                  )
                  VALUES (
                      2,
                      Privat,
                      Testeintrag zum Tracken von privater Zeit,
                      false,
                      3,
                      0,
                      NULL
                  );

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot,
                      Archived,
                      Color
                  )
                  VALUES (
                      3,
                      Denken,
                      Testeintrag für parallele Tätigkeit,
                      true,
                      0,
                      0,
                      NULL
                  );

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot,
                      Archived,
                      Color
                  )
                  VALUES (
                      4,
                      Programmieren,
                      Testeintrag für Quickslot-Tests,
                      false,
                      0,
                      0,
                      NULL
                  );

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot,
                      Archived,
                      Color
                  )
                  VALUES (
                      5,
                      Hausarbeit,
                      Testeintrag für Spatzl,
                      false,
                      1,
                      0,
                      NULL
                  );

INSERT INTO Timer (
                      ID,
                      Name,
                      Beschreibung,
                      parallel,
                      quickslot,
                      Archived,
                      Color
                  )
                  VALUES (
                      6,
                      Organisation,
                      Testeintrag für mich,
                      true,
                      0,
                      0,
                      NULL
                  );


-- Table: Times
CREATE TABLE Times (
    ID      INTEGER PRIMARY KEY AUTOINCREMENT,
    Start   STRING,
    [End]   STRING,
    Zeit    STRING,
    Notiz   TEXT,
    TimerID INTEGER REFERENCES Timer (ID) 
                    NOT NULL ON CONFLICT ROLLBACK
);

INSERT INTO Times (
                      ID,
                      Start,
                      [End],
                      Zeit,
                      Notiz,
                      TimerID
                  )
                  VALUES (
                      170,
                      07.12.2021 16:20:40,
                      09.12.2021 17:20:45,
                      2.01:00:05,
                      NULL,
                      1
                  );

INSERT INTO Times (
                      ID,
                      Start,
                      [End],
                      Zeit,
                      Notiz,
                      TimerID
                  )
                  VALUES (
                      172,
                      08.12.2021 05:00:04,
                      10.12.2021 17:06:01,
                      2.12:05:57,
                      NULL,
                      1
                  );

INSERT INTO Times (
                      ID,
                      Start,
                      [End],
                      Zeit,
                      Notiz,
                      TimerID
                  )
                  VALUES (
                      173,
                      07.12.2021 17:20:45,
                      10.12.2021 17:20:47,
                      00:00:02,
                      NULL,
                      1
                  );

INSERT INTO Times (
                      ID,
                      Start,
                      [End],
                      Zeit,
                      Notiz,
                      TimerID
                  )
                  VALUES (
                      175,
                      07.12.2021 17:20:45,
                      10.12.2021 22:20:47,
                      05:00:02,
                      NULL,
                      1
                  );

INSERT INTO Times (
                      ID,
                      Start,
                      [End],
                      Zeit,
                      Notiz,
                      TimerID
                  )
                  VALUES (
                      177,
                      09.12.2021 16:37:59,
                      09.12.2021 16:38:07,
                      00:00:07,
                      NULL,
                      1
                  );

INSERT INTO Times (
                      ID,
                      Start,
                      [End],
                      Zeit,
                      Notiz,
                      TimerID
                  )
                  VALUES (
                      178,
                      05.01.2022 13:07:11,
                      05.01.2022 13:07:14,
                      00:00:03,
                      NULL,
                      1
                  );

INSERT INTO Times (
                      ID,
                      Start,
                      [End],
                      Zeit,
                      Notiz,
                      TimerID
                  )
                  VALUES (
                      179,
                      05.01.2022 15:07:24,
                      06.01.2022 13:07:27,
                      22:00:03,
                      NULL,
                      2
                  );

INSERT INTO Times (
                      ID,
                      Start,
                      [End],
                      Zeit,
                      Notiz,
                      TimerID
                  )
                  VALUES (
                      184,
                      05.01.2022 13:08:38,
                      05.01.2022 13:08:39,
                      00:00:01,
                      NULL,
                      6
                  );

INSERT INTO Times (
                      ID,
                      Start,
                      [End],
                      Zeit,
                      Notiz,
                      TimerID
                  )
                  VALUES (
                      186,
                      04.01.2022 18:00:00,
                      05.01.2022 19:00:00,
                      1.01:00:00,
                      NULL,
                      2
                  );

INSERT INTO Times (
                      ID,
                      Start,
                      [End],
                      Zeit,
                      Notiz,
                      TimerID
                  )
                  VALUES (
                      187,
                      06.01.2022 18:49:10,
                      06.01.2022 18:49:15,
                      00:00:05,
                      NULL,
                      5
                  );

INSERT INTO Times (
                      ID,
                      Start,
                      [End],
                      Zeit,
                      Notiz,
                      TimerID
                  )
                  VALUES (
                      188,
                      06.01.2022 18:51:10,
                      06.01.2022 18:51:26,
                      00:00:15,
                      NULL,
                      1
                  );

INSERT INTO Times (
                      ID,
                      Start,
                      [End],
                      Zeit,
                      Notiz,
                      TimerID
                  )
                  VALUES (
                      189,
                      06.01.2022 09:00:00,
                      06.01.2022 10:30:00,
                      01:30:00,
                      NULL,
                      2
                  );


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
