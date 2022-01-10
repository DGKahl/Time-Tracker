--
-- File generated with SQLiteStudio v3.3.0 on Mo Jan 10 17:42:42 2022
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
                      2,
                      Privat,
                      Testeintrag zum Tracken von privater Zeit,
                      false,
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
                      3,
                      Denken,
                      Testeintrag für parallele Tätigkeit,
                      true,
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
                      6,
                      Organisation,
                      Testeintrag für mich,
                      true,
                      0,
                      0
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
                      05.01.2022 13:07:24,
                      05.01.2022 13:07:27,
                      00:00:03,
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
                      180,
                      05.01.2022 13:07:27,
                      05.01.2022 13:07:30,
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
                      182,
                      05.01.2022 13:08:20,
                      05.01.2022 13:08:32,
                      00:00:12,
                      NULL,
                      3
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
                      183,
                      04.01.2022 13:08:32,
                      05.01.2022 19:08:38,
                      1.06:00:06,
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
                      185,
                      06.01.2022 18:35:21,
                      06.01.2022 18:35:23,
                      00:00:01,
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
                      186,
                      06.01.2022 18:46:49,
                      06.01.2022 18:46:54,
                      00:00:04,
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


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
