-- phpMyAdmin SQL Dump
-- version 4.8.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 05. Dez 2023 um 12:10
-- Server-Version: 10.1.33-MariaDB
-- PHP-Version: 7.2.6

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
  `Umfrage_ID` int(11) DEFAULT NULL,
  `Benutzer_ID` int(11) DEFAULT NULL
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

--
-- Daten für Tabelle `benutzer`
--

INSERT INTO `benutzer` (`Benutzer_ID`, `Benutzername`, `Passwort`, `Rolle`) VALUES
(0, 'Anonym', '', ''),
(2, 'Clyde', '$2a$11$kimfLnmeArzFxpYaJoIDh.7DHNN0Vs1rm1v4KE2lxcVw31jwSiK1a', 'Admin');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `umfragen`
--

CREATE TABLE `umfragen` (
  `Umfrage_ID` int(11) NOT NULL,
  `Titel` varchar(255) NOT NULL,
  `Beschreibung` text,
  `UmfragenTyp` varchar(40) NOT NULL,
  `Erstellungsdatum` datetime DEFAULT NULL,
  `Ablaufdatum` datetime DEFAULT NULL,
  `Autor` int(11) DEFAULT NULL,
  `Automatische_Loeschung` datetime DEFAULT NULL,
  `Status` enum('Aktiv','Abgeschlossen') NOT NULL,
  `Archiv` enum('Ja','Nein') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `antworten`
--
ALTER TABLE `antworten`
  ADD KEY `Umfrage_ID` (`Umfrage_ID`),
  ADD KEY `Benutzer_ID` (`Benutzer_ID`);

--
-- Indizes für die Tabelle `benutzer`
--
ALTER TABLE `benutzer`
  ADD PRIMARY KEY (`Benutzer_ID`);

--
-- Indizes für die Tabelle `umfragen`
--
ALTER TABLE `umfragen`
  ADD PRIMARY KEY (`Umfrage_ID`),
  ADD KEY `Autor` (`Autor`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `benutzer`
--
ALTER TABLE `benutzer`
  MODIFY `Benutzer_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT für Tabelle `umfragen`
--
ALTER TABLE `umfragen`
  MODIFY `Umfrage_ID` int(11) NOT NULL AUTO_INCREMENT;

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
-- Constraints der Tabelle `umfragen`
--
ALTER TABLE `umfragen`
  ADD CONSTRAINT `umfragen_ibfk_1` FOREIGN KEY (`Autor`) REFERENCES `benutzer` (`Benutzer_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
