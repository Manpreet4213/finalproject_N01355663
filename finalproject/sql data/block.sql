-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 07, 2019 at 04:28 AM
-- Server version: 5.7.24
-- PHP Version: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `block`
--

-- --------------------------------------------------------

--
-- Table structure for table `pages`
--

CREATE TABLE `pages` (
  `pageid` int(20) UNSIGNED NOT NULL,
  `pagetitle` varchar(255) CHARACTER SET latin1 NOT NULL,
  `pagebody` mediumtext CHARACTER SET latin1 NOT NULL,
  `pagedate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pages`
--

INSERT INTO `pages` (`pageid`, `pagetitle`, `pagebody`, `pagedate`) VALUES
(1, 'Seneca', 'All about me', '2019-04-03'),
(2, 'Reeta', 'This was a wonderful page in the past few years...', '2018-05-06'),
(3, 'My wife', 'She is very beautiful and she takes care of my whole family..', '2017-07-09'),
(4, 'Harsh', 'It is very strange sometimes when others don\'t take care of...', '2014-08-06'),
(5, 'wet', 'It was a dark night.I was scared a lot due to weather...', '2013-03-01'),
(6, 'Cat', 'My cat is of white clour.I take care of my... ', '2016-07-01'),
(7, 'Great page', 'It is one of the famous pages. It was published in ...', '2011-03-05'),
(8, 'Rosario', 'He hit the car with a ....', '2011-05-02'),
(9, 'Pet', 'I have a pet.It is a dog.It is very faithful...', '2008-11-04'),
(10, 'Hero', 'He is one of the great actors i ever know...', '2013-02-08'),
(11, 'Ink', 'I bought this inkpot from Canada.It is...', '2001-03-09'),
(12, 'Queen', 'I was waiting for the night to pass.But, at sudden i had a deam ...', '2001-05-01'),
(13, 'Lady', 'I saw a white lady with a white cat in her hand....', '2017-07-07'),
(14, 'Parrot', 'He was having a parrot few years ago...', '2014-04-09'),
(15, 'tresa', 'I am a girl', '2019-12-06'),
(16, 'Manpreet', 'Kaur', '2019-12-06');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pages`
--
ALTER TABLE `pages`
  ADD PRIMARY KEY (`pageid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pages`
--
ALTER TABLE `pages`
  MODIFY `pageid` int(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
