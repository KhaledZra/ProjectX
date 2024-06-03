-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 22, 2022 at 04:04 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `world_of_heretics`
--

-- --------------------------------------------------------

--
-- Table structure for table `character`
--

CREATE TABLE `character` (
                             `id` int(11) NOT NULL,
                             `name` varchar(64) DEFAULT NULL,
                             `experience` int(11) DEFAULT NULL,
                             `health` int(11) DEFAULT NULL,
                             `gold` int(11) DEFAULT NULL,
                             `vocation` int(11) DEFAULT NULL,
                             `positionx` int(11) DEFAULT NULL,
                             `positiony` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `character`
--

INSERT INTO `character` (`id`, `name`, `experience`, `health`, `gold`, `vocation`, `positionx`, `positiony`) VALUES
                                                                                                                 (1, 'Khaled', 0, 200, 50, 1, 45, 15);

-- --------------------------------------------------------

--
-- Table structure for table `character_to_item`
--

CREATE TABLE `character_to_item` (
                                     `character_id` int(11) NOT NULL,
                                     `item_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `enemy_name`
--

CREATE TABLE `enemy_name` (
                              `id` int(11) NOT NULL,
                              `name` varchar(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `enemy_name`
--

INSERT INTO `enemy_name` (`id`, `name`) VALUES
                                            (1, 'Abo Hazan'),
                                            (2, 'Az-Adar'),
                                            (3, 'Azog'),
                                            (4, 'Gorbag'),
                                            (5, 'Gothmog'),
                                            (6, 'Grishnákh'),
                                            (7, 'Kâka'),
                                            (8, 'Shag'),
                                            (9, 'Shagrat'),
                                            (10, 'Skak'),
                                            (11, 'Snaga'),
                                            (12, 'Uglúk'),
                                            (13, 'Shaká'),
                                            (14, 'Zuka'),
                                            (15, 'Ogg');

-- --------------------------------------------------------

--
-- Table structure for table `enemy_race`
--

CREATE TABLE `enemy_race` (
                              `id` int(11) NOT NULL,
                              `name` varchar(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `enemy_race`
--

INSERT INTO `enemy_race` (`id`, `name`) VALUES
                                            (1, 'Goblin'),
                                            (2, 'Skeleton'),
                                            (3, 'Orc'),
                                            (4, 'Shaytan'),
                                            (5, 'Jihn'),
                                            (6, 'Murloc'),
                                            (7, 'Revenant');

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE `item` (
                        `id` int(11) NOT NULL,
                        `name` varchar(64) DEFAULT NULL,
                        `currency` int(11) DEFAULT NULL,
                        `health` int(11) DEFAULT NULL,
                        `level` int(11) DEFAULT NULL,
                        `vocation` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `item`
--

INSERT INTO `item` (`id`, `name`, `currency`, `health`, `level`, `vocation`) VALUES
                                                                                 (1, 'Shuriken', 1, 5, 1, 1),
                                                                                 (2, 'Short Bow', 10, 10, 1, 1),
                                                                                 (3, 'Long Bow', 30, 20, 5, 1),
                                                                                 (4, 'Batarang', 25, 50, 5, 1),
                                                                                 (5, 'Long Bow', 30, 20, 5, 1),
                                                                                 (6, 'Crossbow', 100, 30, 10, 1),
                                                                                 (7, 'Fūma Shuriken, major throwing star', 150, 25, 30, 1),
                                                                                 (8, 'Widows Wail', 1500, 100, 49, 1),
                                                                                 (9, 'The Spirit Spear Chastiefol', 9999999, 10000, 50, 1),
                                                                                 (10, 'Rusty Sword', 1, 10, 1, 2),
                                                                                 (11, 'Butchers Axe', 10, 20, 5, 2),
                                                                                 (12, 'Jagged Scimitar', 25, 20, 5, 2),
                                                                                 (13, 'Longsword', 30, 30, 10, 2),
                                                                                 (14, 'Skullcrackers Mace', 50, 35, 10, 2),
                                                                                 (15, 'Needle', 15000, 50, 30, 2),
                                                                                 (16, 'Kusanagi', 30000, 100, 49, 2),
                                                                                 (17, 'Stonecutter Axe', 90000, 100, 49, 2),
                                                                                 (18, 'Newgates Murakumogiri', 9999999, 100, 49, 2),
                                                                                 (19, 'The Vorpal Blade', 9999999, 100, 50, 2),
                                                                                 (20, 'Mihawks Yoru', 9999999, 1000, 50, 2),
                                                                                 (21, 'The Sword of Rupture, Ea', 9999999, 10000, 50, 2),
                                                                                 (22, 'Wooden Stick', 5, 10, 1, 3),
                                                                                 (23, 'Wooden Wand', 10, 15, 5, 3),
                                                                                 (24, 'Orb of inferno', 50, 50, 15, 3),
                                                                                 (25, 'Book of neverending screams', 95, 75, 25, 3),
                                                                                 (26, 'Eon Sceptre', 200, 75, 35, 3),
                                                                                 (27, 'Long staff of Heretic', 1000, 100, 45, 3),
                                                                                 (28, 'Orcus, Scythe of the Reaper', 9999999, 1000, 50, 3),
                                                                                 (29, 'Death Note', 9999999, 10000, 50, 3);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `character`
--
ALTER TABLE `character`
    ADD PRIMARY KEY (`id`);

--
-- Indexes for table `character_to_item`
--
ALTER TABLE `character_to_item`
    ADD KEY `character_id` (`character_id`),
    ADD KEY `item_id` (`item_id`);

--
-- Indexes for table `enemy_name`
--
ALTER TABLE `enemy_name`
    ADD PRIMARY KEY (`id`);

--
-- Indexes for table `enemy_race`
--
ALTER TABLE `enemy_race`
    ADD PRIMARY KEY (`id`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
    ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `character`
--
ALTER TABLE `character`
    MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `enemy_name`
--
ALTER TABLE `enemy_name`
    MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `enemy_race`
--
ALTER TABLE `enemy_race`
    MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `item`
--
ALTER TABLE `item`
    MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `character_to_item`
--
ALTER TABLE `character_to_item`
    ADD CONSTRAINT `character_to_item_ibfk_1` FOREIGN KEY (`character_id`) REFERENCES `character` (`id`),
    ADD CONSTRAINT `character_to_item_ibfk_2` FOREIGN KEY (`item_id`) REFERENCES `item` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
