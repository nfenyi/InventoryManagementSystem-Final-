-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 15, 2022 at 08:19 PM
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
-- Database: `inventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `id` int(11) NOT NULL,
  `user` varchar(100) NOT NULL,
  `details` varchar(5000) NOT NULL,
  `price` varchar(50) NOT NULL,
  `paid` varchar(30) NOT NULL DEFAULT 'no',
  `date` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`id`, `user`, `details`, `price`, `paid`, `date`) VALUES
(4, 'roose', 'Model 2 Head Light manufactured 511*2', '511', 'yes', ''),
(5, 'roose', 'Model 1 Battery imported 224*1', '224', 'cancelled', ''),
(6, 'roose', 'Model 5 Steering Wheel imported 339*1', '339', 'cancelled', ''),
(7, 'demoaccount', 'DemoModel Demo Parts imported 255*3\r\n', '765', 'yes', ''),
(8, 'christine', 'Model 2 Seat Belt imported 88*1\r\n', '88', 'yes', ''),
(9, 'estela', 'Model 1 Spoiler imported 190*2\r\n', '380', 'yes', ''),
(10, 'robert', 'Model 1 Decklid imported 499*1\r\n', '499', 'yes', ''),
(11, 'jimmy', 'Model 3 Muffler manufactured 830*1\r\n', '830', 'yes', ''),
(12, 'cath', 'Model 4 Battery imported 201*1\r\n', '201', 'cancelled', ''),
(13, 'warren', 'Model 2 Seat Belt imported 88*2\r\n', '176', 'no', ''),
(14, 'sacco', 'Model 2 Gear Lever imported 401*1\r\n', '401', 'no', ''),
(15, 'demoaccount', 'Model 7 Indicator Lights imported 149*2\r\n', '298', 'yes', ''),
(16, 'demoaccount', 'Model 6 Dashcam imported 266*1\r\n', '266', 'yes', ''),
(17, 'cBrown', ' Baby Products Nan3  50*2\r\nOffice Brown Envelopes Pack  30*2\r\n', '160', 'no', 'Friday, 14 October 2022 10:58'),
(18, 'cBrown', 'Office Brown Envelopes Pack  30*2\r\n', '60', 'no', 'Friday, 14 October 2022 11:04'),
(19, 'cBrown', ' Baby Products Nan3  50*2\r\n Baby Products Nan3  50*2\r\n', '200', 'no', 'Friday, 14 October 2022 11:20'),
(20, 'aDuah', 'Baby Products Pacifier  28*1\r\n', '28', 'no', 'Friday, 14 October 2022 11:28'),
(21, 'cBrown', 'Home Appliances Binatone Steam Iron  150*2\r\n', '300', 'no', 'Friday, 14 October 2022 11:39'),
(22, 'aDuah', ' Baby Products Nan3  50.59*2\r\n', '101.18', 'no', 'Friday, 14 October 2022 11:48'),
(23, 'aDuah', 'Office A4 sheets pack  55.56*5\r\n', '277.8', 'no', 'Friday, 14 October 2022 12:01'),
(24, 'aDuah', 'Groceries Lele Rice 5kg  75.80*3\r\n', '227.4', 'no', 'Friday, 14 October 2022 12:09'),
(25, 'aDuah', 'Baby Products Pacifier  28.99*1\r\n', '28.99', 'no', 'Saturday, 15 October 2022 17:00'),
(26, 'aDuah', 'Office Bic Pens pack  43.70*1\r\n', '43.7', 'no', 'Saturday, 15 October 2022 17:23'),
(27, 'aDuah', 'Baby Products Pacifier  28.99*1\r\n', '28.99', 'no', 'Saturday, 15 October 2022 17:30'),
(28, 'aDuah', 'Groceries Cabbage 500g  22.80*1\r\n', '22.8', 'no', 'Saturday, 15 October 2022 17:34'),
(29, 'aDuah', 'Groceries Cabbage 500g  22.80*2\r\n', '45.6', 'no', 'Saturday, 15 October 2022 17:36'),
(30, 'aDuah', 'Groceries Cabbage 500g  22.80*3\r\n', '68.39999', 'no', 'Saturday, 15 October 2022 17:43');

-- --------------------------------------------------------

--
-- Table structure for table `stock`
--

CREATE TABLE `stock` (
  `barcode` int(11) NOT NULL,
  `category` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `price` varchar(50) NOT NULL,
  `instock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stock`
--

INSERT INTO `stock` (`barcode`, `category`, `name`, `price`, `instock`) VALUES
(10001, ' Baby Products', 'Nan3', '50.59', 44),
(10002, 'Baby Products', 'Pacifier', '28.99', 7),
(10003, 'Groceries', 'Lele Rice 5kg', '75.80', 45),
(10004, 'Groceries', 'Cabbage 500g', '22.80', 20),
(10005, 'Office', 'A4 sheets pack', '55.56', 15),
(10006, 'Office', 'Bic Pens pack', '43.70', 23),
(10007, 'Home Appliances', 'Philips Blender', '170.89', 11),
(10008, 'Home Appliances', 'Binatone Steam Iron', '150.80', 20),
(10009, 'Cosmetics', 'Palmer\'s Cocoa Butter Pomade', '75.90', 15),
(10010, 'Cosmetics', 'Exfoliator', '40.40', 15),
(10011, 'Groceries', 'Eggs', '40.40', 18),
(10012, 'Office', 'Staple Pins', '50.30', 100),
(10013, 'Kitchen', 'Ceramic Bowls Set', '75.99', 5),
(10014, 'Kitchen', 'Wooden Utensil Set', '38.67', 10),
(10015, 'Kitchen', '5-Knife Set', '75.89', 20),
(10025, 'Office', 'Brown Envelopes Pack', '30.75', 16);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `first` varchar(100) NOT NULL,
  `last` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `phone` varchar(10) NOT NULL,
  `password` varchar(50) NOT NULL,
  `usertype` varchar(20) NOT NULL DEFAULT 'member'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `first`, `last`, `username`, `phone`, `password`, `usertype`) VALUES
(1, 'Nana', 'Fenyi', 'nFenyi', '1470001011', 'c24a542f884e144451f9063b79e7994e', 'admin'),
(2, 'Charlie', 'Brown', 'cBrown', '0244400000', '49f68a5c8493ec2c0bf489821c21fc3b', 'attendant'),
(16, 'Akofah', 'Duah', 'aDuah', '0591559097', '1e5e5700b01ec0981aa4a53e44594ff3', 'attendant');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`barcode`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `stock`
--
ALTER TABLE `stock`
  MODIFY `barcode` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10026;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
