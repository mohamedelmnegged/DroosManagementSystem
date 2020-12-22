-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 22, 2020 at 11:32 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `droos management system`
--

-- --------------------------------------------------------

--
-- Table structure for table `attends`
--

CREATE TABLE `attends` (
  `ID` int(11) NOT NULL,
  `Student_id` int(11) NOT NULL,
  `Lesson_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `attends`
--

INSERT INTO `attends` (`ID`, `Student_id`, `Lesson_id`) VALUES
(1, 9, 1),
(2, 8, 1),
(3, 1, 1),
(7, 3, 1),
(8, 5, 2);

-- --------------------------------------------------------

--
-- Table structure for table `classes`
--

CREATE TABLE `classes` (
  `ID` int(11) NOT NULL,
  `Name` varchar(255) CHARACTER SET utf8 NOT NULL COMMENT 'this is the Class name like the first secondary school',
  `Description` varchar(255) CHARACTER SET utf8 NOT NULL COMMENT 'this is the class description to describe the class info ',
  `Sect` varchar(255) CHARACTER SET utf8 NOT NULL COMMENT 'this is the class section like sect18 or sect20',
  `Price` smallint(4) NOT NULL COMMENT 'this is the class salary or the price which the students will pay',
  `Year` year(4) NOT NULL,
  `Teacher_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `classes`
--

INSERT INTO `classes` (`ID`, `Name`, `Description`, `Sect`, `Price`, `Year`, `Teacher_id`) VALUES
(6, 'الإعدادى 1', 'the  second secondary school', 'sect20', 100, 2019, 3),
(7, 'الإعددى2', 'the  third secondary school', 'sect20', 150, 2020, 3),
(8, 'الثانوية 2', 'the  second secondary school', 'sect20', 100, 2020, 4),
(9, 'الثانوية1', 'the  second secondary school', 'sect20', 100, 2019, 5),
(10, 'الثانوية العامة ', 'هذه المجموعه خاصه بالثانوية العامه ', 'sec5', 500, 2021, 3);

-- --------------------------------------------------------

--
-- Table structure for table `clerks`
--

CREATE TABLE `clerks` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) CHARACTER SET utf8 NOT NULL,
  `Job` varchar(255) CHARACTER SET utf8 NOT NULL,
  `Hour_value` int(4) NOT NULL,
  `Phone1` int(11) NOT NULL,
  `Phone2` int(11) NOT NULL,
  `Home_phone` int(9) NOT NULL,
  `Email` varchar(255) CHARACTER SET utf8 NOT NULL,
  `Teacher_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `clerks`
--

INSERT INTO `clerks` (`ID`, `Name`, `Job`, `Hour_value`, `Phone1`, `Phone2`, `Home_phone`, `Email`, `Teacher_id`) VALUES
(1, 'first', 'teacher assistant ', 10, 1000000, 122002, 356544, 'first@teacher.com', 3),
(2, 'second', 'clerk', 15, 11222, 11555, 21454, 'second@teacher.com', 3),
(3, 'third', 'سكرتير', 30, 1112112, 211, 1212111, 'third@teacher.com', 3),
(4, 'رابع ', 'عامل', 30, 1111, 1212111221, 212121112, 'four@teacher.com', 3);

-- --------------------------------------------------------

--
-- Table structure for table `degrees`
--

CREATE TABLE `degrees` (
  `ID` int(11) NOT NULL,
  `Value` tinyint(3) NOT NULL COMMENT 'this is the exam degree value which student get',
  `Student_id` int(11) NOT NULL COMMENT 'this is the student which get the degree',
  `Exam_id` int(11) NOT NULL COMMENT 'this is the exam which student get the degree'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `degrees`
--

INSERT INTO `degrees` (`ID`, `Value`, `Student_id`, `Exam_id`) VALUES
(1, 20, 4, 1),
(3, 20, 5, 1),
(5, 20, 5, 1),
(7, 20, 5, 1),
(8, 18, 4, 2),
(9, 5, 4, 3),
(12, 15, 4, 4),
(13, 10, 4, 4);

-- --------------------------------------------------------

--
-- Table structure for table `exams`
--

CREATE TABLE `exams` (
  `ID` int(11) NOT NULL,
  `Name` varchar(200) CHARACTER SET utf8 NOT NULL COMMENT 'this is the exam name',
  `Description` varchar(255) CHARACTER SET utf8 NOT NULL COMMENT 'this  is the description of the exam ',
  `Date` date NOT NULL DEFAULT current_timestamp() COMMENT 'this is the exam date ',
  `FullMark` tinyint(3) NOT NULL,
  `Class_id` int(11) NOT NULL COMMENT 'this is the class related to this exam'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `exams`
--

INSERT INTO `exams` (`ID`, `Name`, `Description`, `Date`, `FullMark`, `Class_id`) VALUES
(1, 'first exam', 'this is the first exam', '2020-11-30', 20, 6),
(2, 'second exam', 'this is the second exam', '2020-11-30', 20, 6),
(3, 'third exam', 'this is the third exam', '2020-11-30', 20, 7),
(4, 'four exam', 'this is the fourth exam', '2020-11-30', 20, 8);

-- --------------------------------------------------------

--
-- Table structure for table `lessons`
--

CREATE TABLE `lessons` (
  `ID` int(11) NOT NULL,
  `Number` int(5) NOT NULL,
  `date` datetime NOT NULL,
  `Class_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `lessons`
--

INSERT INTO `lessons` (`ID`, `Number`, `date`, `Class_id`) VALUES
(1, 1, '2020-12-04 16:15:03', 6),
(2, 2, '2020-12-04 16:15:03', 7),
(3, 3, '2020-12-04 16:15:03', 8),
(5, 4, '2020-12-11 16:16:11', 6);

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `ID` int(11) NOT NULL,
  `FullName` varchar(200) CHARACTER SET utf8 NOT NULL COMMENT 'this is the student full name ',
  `Phone` int(11) NOT NULL COMMENT 'this is the student phone number ',
  `Parent_phone` int(11) NOT NULL COMMENT 'this  is the student''s parent phone number ',
  `Parent_job` varchar(255) NOT NULL COMMENT 'this is the parent job ',
  `Year` year(4) NOT NULL COMMENT 'this is the existing year ',
  `Register_date` date NOT NULL DEFAULT current_timestamp() COMMENT 'this is the date when the student is added ',
  `Class_id` int(11) NOT NULL COMMENT 'this is the student''s class ',
  `ParCode` int(11) NOT NULL,
  `Address` varchar(255) CHARACTER SET utf8 NOT NULL,
  `Money_Paied` tinyint(1) NOT NULL COMMENT 'this to check if student exempt or not if 0 so he do have a money paied',
  `Lastmonthpaied` int(2) NOT NULL COMMENT 'this is the last month of paied',
  `Notes` varchar(255) NOT NULL COMMENT 'this to type some words about the students '
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`ID`, `FullName`, `Phone`, `Parent_phone`, `Parent_job`, `Year`, `Register_date`, `Class_id`, `ParCode`, `Address`, `Money_Paied`, `Lastmonthpaied`, `Notes`) VALUES
(1, 'mohamed ahmed mahmoud', 1011111111, 1011111111, 'employee', 2020, '2020-11-04', 6, 455, 'Shapas', 0, 11, ''),
(3, 'Marwan', 1011111111, 1011111111, 'manager', 2019, '2020-11-14', 6, 454, 'biella', 0, 10, ''),
(4, 'ali', 1011111111, 1011111111, 'carbenter', 2020, '2020-11-14', 6, 48, '', 0, 11, ''),
(5, 'mai mahmoud', 1011111111, 1011111111, 'HR', 2020, '2020-11-14', 7, 54, 'Alex', 0, 11, ''),
(6, 'Manal', 454545454, 544548454, 'teacher', 2019, '2020-12-02', 9, 455445, 'at police station', 1, 11, 'no notes'),
(7, 'mawada', 454545454, 544548454, 'doctor', 2020, '2020-12-02', 9, 455445, 'at hospital station', 1, 12, 'no notes'),
(8, 'Samah', 10111111, 2026506, 'clerk', 2021, '2020-12-09', 10, 655, 'qilin ', 1, 11, 'there is no notes'),
(9, 'ala', 10111111, 2026506, 'pharmacy', 2021, '2020-12-09', 10, 655, 'desouq ', 0, 11, 'there is no notes'),
(10, 'mando', 10111111, 2026506, 'profissor', 2021, '2020-12-09', 10, 655, 'kafr Elshiekh ', 0, 12, 'there is no notes'),
(11, 'ممدوح', 121545, 4545454, 'محامى', 2020, '2020-12-22', 6, 0, 'شباس', 0, 12, 'لايوجد'),
(12, 'عمر', 123002, 9897979, 'مدرس', 2020, '2020-12-22', 7, 0, 'شباس', 0, 12, 'لايوجد');

-- --------------------------------------------------------

--
-- Table structure for table `teachers`
--

CREATE TABLE `teachers` (
  `ID` int(11) NOT NULL,
  `Name` varchar(255) CHARACTER SET utf8 NOT NULL COMMENT 'this is the teacher name ',
  `UserName` varchar(255) CHARACTER SET utf8 NOT NULL COMMENT 'this is the username to make login ',
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `teachers`
--

INSERT INTO `teachers` (`ID`, `Name`, `UserName`, `Password`) VALUES
(3, 'first teacher ', 'first_teacher', '123456789'),
(4, 'second teacher ', 'second_teacher', '123456789'),
(5, 'third teacher ', 'third_teacher', '123456789'),
(6, 'four teacher ', 'four_teacher', '123456789');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attends`
--
ALTER TABLE `attends`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `attendLesson` (`Lesson_id`),
  ADD KEY `attendStudent` (`Student_id`);

--
-- Indexes for table `classes`
--
ALTER TABLE `classes`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `teacher` (`Teacher_id`);

--
-- Indexes for table `clerks`
--
ALTER TABLE `clerks`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `clerk_teacher` (`Teacher_id`);

--
-- Indexes for table `degrees`
--
ALTER TABLE `degrees`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Student_id` (`Student_id`) USING BTREE,
  ADD KEY `Exam_id` (`Exam_id`) USING BTREE;

--
-- Indexes for table `exams`
--
ALTER TABLE `exams`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Class_id` (`Class_id`) USING BTREE;

--
-- Indexes for table `lessons`
--
ALTER TABLE `lessons`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `lessonClass` (`Class_id`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Class_id` (`Class_id`) USING BTREE;

--
-- Indexes for table `teachers`
--
ALTER TABLE `teachers`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `UserName` (`UserName`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attends`
--
ALTER TABLE `attends`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `classes`
--
ALTER TABLE `classes`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `clerks`
--
ALTER TABLE `clerks`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `degrees`
--
ALTER TABLE `degrees`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `exams`
--
ALTER TABLE `exams`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `lessons`
--
ALTER TABLE `lessons`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `teachers`
--
ALTER TABLE `teachers`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attends`
--
ALTER TABLE `attends`
  ADD CONSTRAINT `attendLesson` FOREIGN KEY (`Lesson_id`) REFERENCES `lessons` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `attendStudent` FOREIGN KEY (`Student_id`) REFERENCES `students` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `classes`
--
ALTER TABLE `classes`
  ADD CONSTRAINT `teacher` FOREIGN KEY (`Teacher_id`) REFERENCES `teachers` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `clerks`
--
ALTER TABLE `clerks`
  ADD CONSTRAINT `clerk_teacher` FOREIGN KEY (`Teacher_id`) REFERENCES `teachers` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `degrees`
--
ALTER TABLE `degrees`
  ADD CONSTRAINT `exam_degree` FOREIGN KEY (`Exam_id`) REFERENCES `exams` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `student_degree` FOREIGN KEY (`Student_id`) REFERENCES `students` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `exams`
--
ALTER TABLE `exams`
  ADD CONSTRAINT `class_exam` FOREIGN KEY (`Class_id`) REFERENCES `classes` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `lessons`
--
ALTER TABLE `lessons`
  ADD CONSTRAINT `lessonClass` FOREIGN KEY (`Class_id`) REFERENCES `classes` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `class` FOREIGN KEY (`Class_id`) REFERENCES `classes` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
