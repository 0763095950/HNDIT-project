-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 27, 2020 at 03:31 AM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `restauretdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `comment_tb3`
--

CREATE TABLE `comment_tb3` (
  `id` int(5) NOT NULL,
  `mobile` varchar(10) NOT NULL,
  `name` varchar(100) NOT NULL,
  `rateval` int(6) NOT NULL,
  `comments` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `comment_tb3`
--

INSERT INTO `comment_tb3` (`id`, `mobile`, `name`, `rateval`, `comments`) VALUES
(2, '0763095950', 'Randika', 5, 'it is working now');

-- --------------------------------------------------------

--
-- Table structure for table `itemlist_tb`
--

CREATE TABLE `itemlist_tb` (
  `id` int(11) NOT NULL,
  `itemCode` varchar(15) NOT NULL,
  `itemName` varchar(25) NOT NULL,
  `size` varchar(15) NOT NULL,
  `price` varchar(15) NOT NULL,
  `availability` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `itemlist_tb`
--

INSERT INTO `itemlist_tb` (`id`, `itemCode`, `itemName`, `size`, `price`, `availability`) VALUES
(1, '1', 'Butter Scotch P', 'Medium', '150', ''),
(2, '2', 'Fruit Milk Jely', 'Medium', '120', ''),
(3, '3', 'Cream Yogurt', 'Medium', '100', ''),
(4, '4', 'Strawberry Pudd', 'Medium', '130', ''),
(5, '5', 'Watalappan', 'Medium', '80', ''),
(6, '6', 'Greek Yogurt', 'Medium', '140', ''),
(7, '7', 'Chocalate Puddi', 'Medium', '130', ''),
(8, '8', 'Olive Oil Cake', 'Medium', '80', ''),
(9, '9', 'Fruit Salad', 'Medium', '150', ''),
(10, '10', 'Ice Cofee', 'Medium', '100', ''),
(11, '11', 'Mango Juice', 'Medium', '120', ''),
(12, '12', 'Falooda', 'Medium', '140', ''),
(13, '13', 'Papaya Juice', 'Medium', '120', ''),
(14, '14', 'Orange Juice', 'Medium', '120', ''),
(15, '15', 'Milkshake juice', 'Medium', '150', ''),
(16, '16', 'Pineapple Juice', 'Medium', '120', ''),
(17, '17', 'Watermelon Juic', 'Medium', '100', ''),
(18, '18', 'Mix Fruit Juice', 'Medium', '120', ''),
(19, '19', 'Vegetable Fride', 'Small', '100', ''),
(20, '19', 'Vegetable Fride', 'Medium', '120', ''),
(21, '19', 'Vegetable Fride', 'Large', '150', ''),
(22, '20', 'Egg Fride Rice', 'Small', '120', ''),
(23, '20', 'Egg Fride Rice', 'Medium', '140', ''),
(24, '20', 'Egg Fride Rice', 'Large', '160', ''),
(25, '21', 'Chicken Fride R', 'Small', '140', ''),
(26, '21', 'Chicken Fride Rice', 'Medium', '160', ''),
(27, '21', 'Chicken Fride Rice', 'Medium', '160', ''),
(28, '21', 'Chicken Fride Rice', 'Large', '180', ''),
(29, '22', 'Vegetable Kottu', 'Small', '120', ''),
(30, '22', 'Vegetable Kottu', 'Medium', '140', ''),
(31, '22', 'Vegetable Kottu', 'Large', '160', ''),
(32, '23', 'Egg Kottu', 'Small', '140', ''),
(33, '23', 'Egg Kottu', 'Medium', '160', ''),
(34, '23', 'Egg Kottu', 'Large', '180', ''),
(35, '24', 'Chicken Kottu', 'Small', '150', ''),
(36, '24', 'Chicken Kottu', 'Medium', '180', ''),
(37, '24', 'Chicken Kottu', 'Large', '200', ''),
(38, '25', 'Vegetable Noodless', 'Small', '130', ''),
(39, '25', 'Vegetable Noodless', 'Medium', '150', ''),
(40, '25', 'Vegetable Noodless', 'Large', '170', ''),
(41, '26', 'Egg Noodless', 'Small', '140', ''),
(42, '26', 'Egg Noodless', 'Medium', '160', ''),
(43, '26', 'Egg Noodless', 'Large', '180', ''),
(44, '27', 'Chicken Noodless', 'Small', '150', ''),
(45, '27', 'Chicken Noodless', 'Medium', '170', ''),
(46, '27', 'Chicken Noodless', 'Large', '200', ''),
(47, 'sw1', 'Chocalate Cake', 'Medium', '80', ''),
(48, 'sw2', 'Apple Cake', 'Medium', '100', ''),
(49, 'sw3', 'Gulab Jamun', 'Medium', '40', ''),
(50, 'sw4', 'Chocalate Eclairs', 'Medium', '120', ''),
(51, 'sw5', 'Chocalate Burger', 'Medium', '180', ''),
(52, 's6', 'Magic Chocalate Ball', 'Medium', '140', ''),
(53, 'sw7', 'Cup Cake', 'Medium', '50', ''),
(54, 'sw8', 'Coconut Lado', 'Medium', '40', ''),
(55, 'sw9', 'Sandwich', 'Medium', '40', ''),
(56, '36', 'Fish Bun', 'Medium', '40', ''),
(57, '37', 'Avocado Bun', 'Medium', '80', ''),
(58, '38', 'Potato Bun', 'Medium', '80', ''),
(59, '39', 'Butter Bun', 'Medium', '50', ''),
(60, '40', 'Fride Chicken Bun', 'Medium', '100', ''),
(61, '41', 'Hot Dog Bun', 'Medium', '100', ''),
(62, '42', 'Egg Bun', 'Medium', '60', ''),
(63, '43', 'Easter Bun', 'Medium', '100', ''),
(64, '44', 'Iced Bun', 'Medium', '50', ''),
(65, '65', 'aaaaaa', 'medium', '80', '');

-- --------------------------------------------------------

--
-- Table structure for table `orders_tb`
--

CREATE TABLE `orders_tb` (
  `id` int(11) NOT NULL,
  `orderNo` varchar(15) NOT NULL,
  `itemCode` varchar(15) NOT NULL,
  `size` varchar(15) NOT NULL,
  `qty` varchar(15) NOT NULL,
  `eachPrice` varchar(15) NOT NULL,
  `total` varchar(15) NOT NULL,
  `date` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `orders_tb`
--

INSERT INTO `orders_tb` (`id`, `orderNo`, `itemCode`, `size`, `qty`, `eachPrice`, `total`, `date`) VALUES
(135, '1', '', '', '', '', '', ''),
(136, '2', '19', 'Medium', '2', '120', '240', '8/18/2020 12:51'),
(137, '3', '19', 'Medium', '4', '120', '480', '8/18/2020 3:41:'),
(138, '3', '36', 'Medium', '2', '40', '80', '8/18/2020 3:42:'),
(139, '3', '5', 'Medium', '1', '80', '80', '8/18/2020 3:42:'),
(140, '3', 'sw1', 'Medium', '1', '80', '80', '8/18/2020 3:43:'),
(141, '141', '10', 'Medium', '2', '50', '100', '8/18/2020 3:52:'),
(142, '142', '65', 'medium', '4', '80', '320', '8/18/2020 4:05:'),
(143, '4', '16', 'Medium', '2', '120', '240', '10/26/2020 11:2'),
(144, '5', '36', 'Medium', '2', '40', '80', '10/26/2020 11:3'),
(145, '145', '17', 'Medium', '5', '80', '400', '10/27/2020 6:37'),
(146, '145', '17', 'Medium', '5', '80', '400', '10/27/2020 6:40'),
(147, '6', '19', 'Medium', '2', '120', '240', '10/27/2020 7:35');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(15) NOT NULL,
  `email` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL,
  `privilages` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `name`, `email`, `password`, `privilages`) VALUES
(1, 'indunil', 'asdasd', '123', ''),
(2, 'admin', 'admin', 'admin', '1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `comment_tb3`
--
ALTER TABLE `comment_tb3`
  ADD PRIMARY KEY (`id`,`mobile`);

--
-- Indexes for table `itemlist_tb`
--
ALTER TABLE `itemlist_tb`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `orders_tb`
--
ALTER TABLE `orders_tb`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `comment_tb3`
--
ALTER TABLE `comment_tb3`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `itemlist_tb`
--
ALTER TABLE `itemlist_tb`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT for table `orders_tb`
--
ALTER TABLE `orders_tb`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=148;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
