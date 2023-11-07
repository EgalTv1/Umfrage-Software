CREATE TABLE Benutzer (
    Benutzer_ID INT AUTO_INCREMENT PRIMARY KEY,
    Benutzername VARCHAR(255) NOT NULL,
    Passwort VARCHAR(255) NOT NULL,
    Rolle VARCHAR(20) NOT NULL
);

CREATE TABLE Umfragen (
    Umfrage_ID INT AUTO_INCREMENT PRIMARY KEY,
    Titel VARCHAR(255) NOT NULL,
    Beschreibung TEXT,
    Erstellungsdatum DATETIME,
    Ablaufdatum DATETIME,
    Autor INT,
    Automatische_Loeschung DATETIME,
    Status ENUM('Aktiv', 'Abgeschlossen') NOT NULL,
    Archiv ENUM('Ja', 'Nein') NOT NULL
);

CREATE TABLE Antworten (
    Antwort_ID INT AUTO_INCREMENT PRIMARY KEY,
    Umfrage_ID INT,
    Benutzer_ID INT,
    Antworttext TEXT,
    Vordefinierte_Antwort ENUM('Ja', 'Nein', 'Andere Optionen')
);

CREATE TABLE Benutzergruppen (
    Gruppen_ID INT AUTO_INCREMENT PRIMARY KEY,
    Gruppenname VARCHAR(255) NOT NULL
);

CREATE TABLE Benutzer_Benutzergruppen (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Benutzer_ID INT,
    Gruppen_ID INT
);

CREATE TABLE Umfragen_Benutzergruppen (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Umfrage_ID INT,
    Gruppen_ID INT
);

CREATE TABLE Feedback (
    Feedback_ID INT AUTO_INCREMENT PRIMARY KEY,
    Umfrage_ID INT,
    Benutzer_ID INT,
    Kommentar TEXT,
    Bewertung INT
);

ALTER TABLE Umfragen
ADD FOREIGN KEY (Autor) REFERENCES Benutzer(Benutzer_ID);

ALTER TABLE Antworten
ADD FOREIGN KEY (Umfrage_ID) REFERENCES Umfragen(Umfrage_ID);

ALTER TABLE Antworten
ADD FOREIGN KEY (Benutzer_ID) REFERENCES Benutzer(Benutzer_ID);

ALTER TABLE Benutzer_Benutzergruppen
ADD FOREIGN KEY (Benutzer_ID) REFERENCES Benutzer(Benutzer_ID);

ALTER TABLE Benutzer_Benutzergruppen
ADD FOREIGN KEY (Gruppen_ID) REFERENCES Benutzergruppen(Gruppen_ID);

ALTER TABLE Umfragen_Benutzergruppen
ADD FOREIGN KEY (Umfrage_ID) REFERENCES Umfragen(Umfrage_ID);

ALTER TABLE Umfragen_Benutzergruppen
ADD FOREIGN KEY (Gruppen_ID) REFERENCES Benutzergruppen(Gruppen_ID);

ALTER TABLE Feedback
ADD FOREIGN KEY (Umfrage_ID) REFERENCES Umfragen(Umfrage_ID);

ALTER TABLE Feedback
ADD FOREIGN KEY (Benutzer_ID) REFERENCES Benutzer(Benutzer_ID);
