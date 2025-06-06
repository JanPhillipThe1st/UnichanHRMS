-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 03, 2024 at 02:32 AM
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
(29, 1, 'asd', 'asd', 'asd', '25', 'Male', '09635664654', '2000-03-12 08:21:17', '2024-03-12 08:21:17', '2024-03-12 08:21:17', 'March 12, 2024', 'March 12, 2024', 'hired', ''),
(32, 1, 'John', 'J', 'Kennedy', '26', 'Male', '096356268654', '2024-03-21 14:22:29', '2024-03-19 22:11:49', '2024-03-27 22:11:49', 'Friday, 22 March 2024', 'Thursday, 28 March 2024', '', ''),
(33, 1, 'Jun', 'B', 'Alain', '20', 'Male', '096356485223', '2024-04-03 07:00:46', '2024-03-20 14:10:13', '2024-03-20 14:10:13', 'Friday, 22 March 2024', 'Wednesday, 3 April 2024', '', ''),
(34, 1, 'Bhenz', 'Castro', 'Abdulkarim', '20', 'Male', '09350321801', '2024-03-29 20:38:35', '2024-03-29 20:38:35', '2024-03-31 20:38:35', 'NOT SET', 'NOT SET', 'pending', '');

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
  `generated_id` varchar(255) NOT NULL,
  `applicant_ID` int(11) NOT NULL,
  `batch_number` int(11) NOT NULL,
  `sss_number` varchar(255) NOT NULL,
  `philhealth_number` varchar(255) NOT NULL,
  `pag_ibig_number` varchar(255) NOT NULL,
  `TIN_number` varchar(255) NOT NULL,
  `orientation_date` datetime NOT NULL DEFAULT current_timestamp(),
  `employment_status` varchar(10) NOT NULL,
  `employment_remarks` varchar(40) NOT NULL,
  `resignation_date` datetime DEFAULT current_timestamp(),
  `available_leave` int(3) NOT NULL,
  `leaves_used` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`employee_ID`, `generated_id`, `applicant_ID`, `batch_number`, `sss_number`, `philhealth_number`, `pag_ibig_number`, `TIN_number`, `orientation_date`, `employment_status`, `employment_remarks`, `resignation_date`, `available_leave`, `leaves_used`) VALUES
(18, '2024-0', 32, 1, '232-31-54897', '45-623125645-6', '5454-4345-3543', '468-682-111-124', '2023-03-19 22:13:09', 'RESIGNED', 'REGULAR', '2023-03-19 22:13:09', 6, 3),
(19, '2024-19', 33, 1, '   -  -', '  -         -', '    -    -', '   -   -   -', '2024-03-20 14:11:10', 'RESIGNED', 'RESIGNED', '2024-04-01 07:00:48', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `leave_application`
--

CREATE TABLE `leave_application` (
  `leave_ID` int(11) NOT NULL,
  `employee_ID` int(11) NOT NULL,
  `leave_date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
(1, 'admin', 'Hiring Manager', 'mc3zdI7di6UhxLIrt8M2rQ==', 'Secret', '09222123123', 'admin'),
(6, 'mjm123', 'Mark J Mong ', '/cDbSoBdJwWLEJTEjQVdWg==', 'Balangasan', '09635654654', 'hiring_manager');

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
-- Indexes for table `leave_application`
--
ALTER TABLE `leave_application`
  ADD PRIMARY KEY (`leave_ID`);

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
  MODIFY `applicant_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `batch`
--
ALTER TABLE `batch`
  MODIFY `batch_number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `employee_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `leave_application`
--
ALTER TABLE `leave_application`
  MODIFY `leave_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `visitor`
--
ALTER TABLE `visitor`
  MODIFY `visitor_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

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
