-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 27. Nov 2023 um 10:12
-- Server-Version: 10.4.11-MariaDB
-- PHP-Version: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `umfrage_software`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `antworten`
--

CREATE TABLE `antworten` (
  `Antwort_ID` int(11) NOT NULL,
  `Umfrage_ID` int(11) DEFAULT NULL,
  `Benutzer_ID` int(11) DEFAULT NULL,
  `Antworttext` text DEFAULT NULL,
  `Vordefinierte_Antwort` enum('Ja','Nein','Andere Optionen') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `benutzer`
--

CREATE TABLE `benutzer` (
  `Benutzer_ID` int(11) NOT NULL,
  `Benutzername` varchar(255) NOT NULL,
  `Passwort` varchar(255) NOT NULL,
  `Rolle` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `benutzergruppen`
--

CREATE TABLE `benutzergruppen` (
  `Gruppen_ID` int(11) NOT NULL,
  `Gruppenname` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `benutzer_benutzergruppen`
--

CREATE TABLE `benutzer_benutzergruppen` (
  `ID` int(11) NOT NULL,
  `Benutzer_ID` int(11) DEFAULT NULL,
  `Gruppen_ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `feedback`
--

CREATE TABLE `feedback` (
  `Feedback_ID` int(11) NOT NULL,
  `Umfrage_ID` int(11) DEFAULT NULL,
  `Benutzer_ID` int(11) DEFAULT NULL,
  `Kommentar` text DEFAULT NULL,
  `Bewertung` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `umfragen`
--

CREATE TABLE `umfragen` (
  `Umfrage_ID` int(11) NOT NULL,
  `Titel` varchar(255) NOT NULL,
  `Beschreibung` text DEFAULT NULL,
  `UmfragenTyp` varchar(40) NOT NULL,
  `Erstellungsdatum` datetime DEFAULT NULL,
  `Ablaufdatum` datetime DEFAULT NULL,
  `Autor` int(11) DEFAULT NULL,
  `Automatische_Loeschung` datetime DEFAULT NULL,
  `Status` enum('Aktiv','Abgeschlossen') NOT NULL,
  `Archiv` enum('Ja','Nein') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `umfragen_benutzergruppen`
--

CREATE TABLE `umfragen_benutzergruppen` (
  `ID` int(11) NOT NULL,
  `Umfrage_ID` int(11) DEFAULT NULL,
  `Gruppen_ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `antworten`
--
ALTER TABLE `antworten`
  ADD PRIMARY KEY (`Antwort_ID`),
  ADD KEY `Umfrage_ID` (`Umfrage_ID`),
  ADD KEY `Benutzer_ID` (`Benutzer_ID`);

--
-- Indizes für die Tabelle `benutzer`
--
ALTER TABLE `benutzer`
  ADD PRIMARY KEY (`Benutzer_ID`);

--
-- Indizes für die Tabelle `benutzergruppen`
--
ALTER TABLE `benutzergruppen`
  ADD PRIMARY KEY (`Gruppen_ID`);

--
-- Indizes für die Tabelle `benutzer_benutzergruppen`
--
ALTER TABLE `benutzer_benutzergruppen`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Benutzer_ID` (`Benutzer_ID`),
  ADD KEY `Gruppen_ID` (`Gruppen_ID`);

--
-- Indizes für die Tabelle `feedback`
--
ALTER TABLE `feedback`
  ADD PRIMARY KEY (`Feedback_ID`),
  ADD KEY `Umfrage_ID` (`Umfrage_ID`),
  ADD KEY `Benutzer_ID` (`Benutzer_ID`);

--
-- Indizes für die Tabelle `umfragen`
--
ALTER TABLE `umfragen`
  ADD PRIMARY KEY (`Umfrage_ID`),
  ADD KEY `Autor` (`Autor`);

--
-- Indizes für die Tabelle `umfragen_benutzergruppen`
--
ALTER TABLE `umfragen_benutzergruppen`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Umfrage_ID` (`Umfrage_ID`),
  ADD KEY `Gruppen_ID` (`Gruppen_ID`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `antworten`
--
ALTER TABLE `antworten`
  MODIFY `Antwort_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `benutzer`
--
ALTER TABLE `benutzer`
  MODIFY `Benutzer_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `benutzergruppen`
--
ALTER TABLE `benutzergruppen`
  MODIFY `Gruppen_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `benutzer_benutzergruppen`
--
ALTER TABLE `benutzer_benutzergruppen`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `feedback`
--
ALTER TABLE `feedback`
  MODIFY `Feedback_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `umfragen`
--
ALTER TABLE `umfragen`
  MODIFY `Umfrage_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `umfragen_benutzergruppen`
--
ALTER TABLE `umfragen_benutzergruppen`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `antworten`
--
ALTER TABLE `antworten`
  ADD CONSTRAINT `antworten_ibfk_1` FOREIGN KEY (`Umfrage_ID`) REFERENCES `umfragen` (`Umfrage_ID`),
  ADD CONSTRAINT `antworten_ibfk_2` FOREIGN KEY (`Benutzer_ID`) REFERENCES `benutzer` (`Benutzer_ID`);

--
-- Constraints der Tabelle `benutzer_benutzergruppen`
--
ALTER TABLE `benutzer_benutzergruppen`
  ADD CONSTRAINT `benutzer_benutzergruppen_ibfk_1` FOREIGN KEY (`Benutzer_ID`) REFERENCES `benutzer` (`Benutzer_ID`),
  ADD CONSTRAINT `benutzer_benutzergruppen_ibfk_2` FOREIGN KEY (`Gruppen_ID`) REFERENCES `benutzergruppen` (`Gruppen_ID`);

--
-- Constraints der Tabelle `feedback`
--
ALTER TABLE `feedback`
  ADD CONSTRAINT `feedback_ibfk_1` FOREIGN KEY (`Umfrage_ID`) REFERENCES `umfragen` (`Umfrage_ID`),
  ADD CONSTRAINT `feedback_ibfk_2` FOREIGN KEY (`Benutzer_ID`) REFERENCES `benutzer` (`Benutzer_ID`);

--
-- Constraints der Tabelle `umfragen`
--
ALTER TABLE `umfragen`
  ADD CONSTRAINT `umfragen_ibfk_1` FOREIGN KEY (`Autor`) REFERENCES `benutzer` (`Benutzer_ID`);

--
-- Constraints der Tabelle `umfragen_benutzergruppen`
--
ALTER TABLE `umfragen_benutzergruppen`
  ADD CONSTRAINT `umfragen_benutzergruppen_ibfk_1` FOREIGN KEY (`Umfrage_ID`) REFERENCES `umfragen` (`Umfrage_ID`),
  ADD CONSTRAINT `umfragen_benutzergruppen_ibfk_2` FOREIGN KEY (`Gruppen_ID`) REFERENCES `benutzergruppen` (`Gruppen_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
