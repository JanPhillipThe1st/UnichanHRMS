-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 11, 2024 at 04:34 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `unichan`
--

-- --------------------------------------------------------

--
-- Table structure for table `applicant`
--

CREATE TABLE `applicant` (
  `applicant_ID` int(11) NOT NULL,
  `batch_number` int(11) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `middle_name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `age` varchar(5) NOT NULL,
  `gender` varchar(30) NOT NULL,
  `contact` varchar(255) NOT NULL,
  `birth_date` datetime NOT NULL DEFAULT current_timestamp(),
  `application_date` datetime NOT NULL DEFAULT current_timestamp(),
  `exam_date` datetime NOT NULL DEFAULT current_timestamp(),
  `initial_interview_date` varchar(255) NOT NULL DEFAULT current_timestamp(),
  `final_interview_date` varchar(255) NOT NULL DEFAULT current_timestamp(),
  `application_status` varchar(20) NOT NULL,
  `remarks` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `applicant`
--

INSERT INTO `applicant` (`applicant_ID`, `batch_number`, `first_name`, `middle_name`, `last_name`, `age`, `gender`, `contact`, `birth_date`, `application_date`, `exam_date`, `initial_interview_date`, `final_interview_date`, `application_status`, `remarks`) VALUES
(24, 1, '', '', '', '', '', '', '2024-03-11 22:34:34', '2024-03-11 22:34:34', '2024-03-11 22:34:34', 'March 11, 2024', 'March 11, 2024', 'hired', ''),
(25, 1, '', '', '', '', '', '', '2024-03-11 22:35:36', '2024-03-11 22:35:36', '2024-03-11 22:35:36', 'NOT SET', 'NOT SET', 'rejected', ''),
(26, 1, 'Michael', 'M', 'Jackson', '32', 'Male', '09365665389', '1980-03-11 22:40:30', '2024-03-14 22:40:31', '2024-03-20 22:40:31', 'NOT SET', 'NOT SET', 'rejected', 'Did not pass exam'),
(27, 1, 'Michael', 'J', 'Jordan', '23', 'Male', '096356231532', '2001-03-05 22:43:50', '2024-03-11 22:43:50', '2024-03-11 22:43:50', 'March 11, 2024', 'March 27, 2024', 'hired', '');

-- --------------------------------------------------------

--
-- Table structure for table `batch`
--

CREATE TABLE `batch` (
  `batch_number` int(11) NOT NULL,
  `number_of_applicants` int(11) NOT NULL,
  `number_of_hired_applicants` int(11) NOT NULL,
  `date_created` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `batch`
--

INSERT INTO `batch` (`batch_number`, `number_of_applicants`, `number_of_hired_applicants`, `date_created`) VALUES
(1, 20, 5, '2024-02-13 07:30:13');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `employee_ID` int(11) NOT NULL,
  `applicant_ID` int(11) NOT NULL,
  `batch_number` int(11) NOT NULL,
  `sss_number` varchar(255) NOT NULL,
  `philhealth_number` varchar(255) NOT NULL,
  `pag_ibig_number` varchar(255) NOT NULL,
  `TIN_number` varchar(255) NOT NULL,
  `orientation_date` datetime NOT NULL DEFAULT current_timestamp(),
  `employment_status` varchar(10) NOT NULL,
  `employment_remarks` varchar(40) NOT NULL,
  `photo` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`employee_ID`, `applicant_ID`, `batch_number`, `sss_number`, `philhealth_number`, `pag_ibig_number`, `TIN_number`, `orientation_date`, `employment_status`, `employment_remarks`, `photo`) VALUES
(14, 24, 1, '   -  -', '  -         -', '    -    -', '   -   -   -', '2024-03-11 22:35:00', 'ACTIVE', 'PASSED ALL EXAMS', ''),
(15, 27, 1, '555-55-55555', '55-555555555-5', '5555-5555-5555', '555-555-555-555', '2024-03-25 22:45:39', 'ACTIVE', 'PASSED ALL EXAMS', '');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `ID` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `full_name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `contact` varchar(13) NOT NULL,
  `access` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`ID`, `username`, `full_name`, `password`, `address`, `contact`, `access`) VALUES
(1, 'admin', 'Admin', 'mc3zdI7di6UhxLIrt8M2rQ==', 'Secret', '09222123123', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `visitor`
--

CREATE TABLE `visitor` (
  `visitor_ID` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `company` varchar(255) NOT NULL,
  `time_in` datetime NOT NULL,
  `time_out` datetime NOT NULL,
  `date_of_visit` datetime NOT NULL,
  `purpose` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `visitor`
--

INSERT INTO `visitor` (`visitor_ID`, `name`, `company`, `time_in`, `time_out`, `date_of_visit`, `purpose`) VALUES
(1, 'James', 'Smart INC.', '2024-03-11 15:00:00', '2024-03-11 16:00:00', '2024-03-11 15:57:19', '0'),
(2, 'John', 'Smart', '2024-03-13 19:32:02', '2024-03-19 19:32:02', '2024-03-25 19:32:02', 'Nothing');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `applicant`
--
ALTER TABLE `applicant`
  ADD PRIMARY KEY (`applicant_ID`);

--
-- Indexes for table `batch`
--
ALTER TABLE `batch`
  ADD PRIMARY KEY (`batch_number`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`employee_ID`),
  ADD KEY `applicant_ID` (`applicant_ID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `visitor`
--
ALTER TABLE `visitor`
  ADD PRIMARY KEY (`visitor_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `applicant`
--
ALTER TABLE `applicant`
  MODIFY `applicant_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `batch`
--
ALTER TABLE `batch`
  MODIFY `batch_number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `employee_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `visitor`
--
ALTER TABLE `visitor`
  MODIFY `visitor_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `employee`
--
ALTER TABLE `employee`
  ADD CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`applicant_ID`) REFERENCES `applicant` (`applicant_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
