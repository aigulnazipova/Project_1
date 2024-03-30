-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Mar 30, 2024 at 08:41 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `studentdiary`
--

-- --------------------------------------------------------

--
-- Table structure for table `about_classes`
--

CREATE TABLE `about_classes` (
  `ID` int(11) NOT NULL,
  `subject_name` varchar(100) NOT NULL COMMENT 'Название',
  `format` varchar(100) NOT NULL COMMENT 'Формат',
  `info` varchar(1000) NOT NULL COMMENT 'Информация'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `about_classes`
--

INSERT INTO `about_classes` (`ID`, `subject_name`, `format`, `info`) VALUES
(1, 'Алгебра и геометрия', 'Лекция', 'Преподаватель: Карчевский Е.М. Количество учебных часов:54. Зачет:+. Экзамен:+'),
(2, 'Алгебра и геометрия', 'Семинар', 'Преподаватели: Гиниятова Д.Х., Александрова И.Л. Количество учебных часов:54\r\n\r\n'),
(3, 'Математический анализ', 'Лекция', 'Преподаватель: Сидоров А.М. Количество учебных часов:54. Зачет:+. Экзамен:+'),
(4, 'Математический анализ', 'Семинар', 'Преподаватели: Сидоров А.М., Тумаков М.Д.. Количество учебных часов:54'),
(5, 'История России', 'Лекция', 'Преподаватель: Бродовская Л.Н. Количество учебных часов:1000. Зачет:-. Экзамен:+\r\nНа этих занятиях можно узнать много нового об истории, своей личности и прошлом, а также послушать рассказы о жандармах'),
(6, 'Английский язык', 'Пратика', 'Преподаватель: Закирова Р.Р Количество учебных часов:200. Зачет:+. Экзамен:-\r\nНа этих занятиях можно будет ознакомиться с компьютерной лексикой, которая поможет в дальнейшем изучении IT-технологий'),
(7, 'Русский язык и культура речи', 'Практика', 'Преподаватель: Файзуллина Э.Ф. Количество учебных часов:20. Зачет:+. Экзамен:-'),
(8, 'Физическая культура', 'Практика', 'Преподаватель: Усманова С.В. Количество учебных часов:524. Зачет:+. Экзамен:-');

-- --------------------------------------------------------

--
-- Table structure for table `admin_users`
--

CREATE TABLE `admin_users` (
  `id_user` int(11) UNSIGNED NOT NULL,
  `last_name` varchar(50) NOT NULL COMMENT 'Фамилия',
  `first_name` varchar(50) NOT NULL COMMENT 'Имя',
  `patronymic` varchar(50) NOT NULL COMMENT 'Отчество',
  `birth_date` date NOT NULL COMMENT 'Дата рождения',
  `phone_number` bigint(11) NOT NULL COMMENT 'Номер телефона',
  `email` varchar(100) NOT NULL COMMENT 'Почта'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `admin_users`
--

INSERT INTO `admin_users` (`id_user`, `last_name`, `first_name`, `patronymic`, `birth_date`, `phone_number`, `email`) VALUES
(1, 'Смирнова', 'Марина', 'Александровна', '1993-09-02', 89101060546, 'marinasmirnova@kpfu.ru');

-- --------------------------------------------------------

--
-- Table structure for table `notes`
--

CREATE TABLE `notes` (
  `ID` int(11) NOT NULL,
  `subject` varchar(1000) NOT NULL,
  `notes` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `notes`
--

INSERT INTO `notes` (`ID`, `subject`, `notes`) VALUES
(1, 'Алгебра и геометрия', 'Мой любимый предмет'),
(2, 'Математический анализ', 'Мой любимый преподаватель');

-- --------------------------------------------------------

--
-- Table structure for table `student_schedule`
--

CREATE TABLE `student_schedule` (
  `id` int(11) NOT NULL,
  `group_number` int(10) NOT NULL COMMENT 'Номер группы',
  `faculty` varchar(255) NOT NULL COMMENT 'Направление',
  `week_day` varchar(20) NOT NULL COMMENT 'День недели',
  `class_number` int(1) NOT NULL COMMENT 'Номер пары',
  `subject_name` varchar(255) NOT NULL COMMENT 'Предмет',
  `format` varchar(100) NOT NULL COMMENT 'Формат'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student_schedule`
--

INSERT INTO `student_schedule` (`id`, `group_number`, `faculty`, `week_day`, `class_number`, `subject_name`, `format`) VALUES
(1, 9322, 'Прикладная математика', 'Понедельник', 1, 'Математический анализ', 'Лекция'),
(2, 9322, 'Прикладная математика', 'Понедельник', 2, 'Иностранный язык', 'Семинар'),
(3, 9322, 'Прикладная математика', 'Понедельник', 3, 'Математический анализ', 'Семинар'),
(4, 9322, 'Прикладная математика', 'Понедельник', 4, 'История России', 'Семинар'),
(5, 9321, 'Прикладная математика', 'Вторник', 2, 'Физическая культура', 'Семинар'),
(6, 9322, 'Прикладная информатика', 'Вторник', 3, 'Математический анализ', 'Лекция'),
(7, 9301, 'Бизнес информатика', 'Среда', 1, 'Разработка приложений наC#', 'Практика'),
(8, 9311, 'Прикладная информатика', 'Пятница', 2, 'Физическая культура', 'Практика'),
(9, 9322, 'Прикладная математика', 'Суббота', 3, 'Ознакомительная практика', 'Практика'),
(10, 9322, 'Прикладная математика', 'Пятница', 3, 'История Росиии', 'Лекция'),
(11, 9321, 'Прикладная математика', 'Четверг', 2, 'Русский язык и культура речи', 'Практика');

-- --------------------------------------------------------

--
-- Table structure for table `student_users`
--

CREATE TABLE `student_users` (
  `student_id` int(11) UNSIGNED NOT NULL COMMENT 'ID студента',
  `last_name` varchar(50) NOT NULL COMMENT 'Фамилия',
  `first_name` varchar(50) NOT NULL COMMENT 'Имя',
  `patronymic` varchar(50) NOT NULL COMMENT 'Отчество',
  `birth_date` date NOT NULL COMMENT 'Дата рождения',
  `phone_number` bigint(11) NOT NULL COMMENT 'Номер телефона',
  `email` varchar(150) NOT NULL COMMENT 'Почта',
  `faculty` varchar(350) NOT NULL COMMENT 'Направление',
  `group_number` int(11) NOT NULL COMMENT 'Номер группы'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student_users`
--

INSERT INTO `student_users` (`student_id`, `last_name`, `first_name`, `patronymic`, `birth_date`, `phone_number`, `email`, `faculty`, `group_number`) VALUES
(2, 'Соколов', 'Никита', 'Андреевич', '2003-11-20', 89234567321, 'nikita.sokolov@kpfu.ru', 'Прикладная математика', 9321),
(3, 'Назипова', 'Айгуль', 'Маратовна', '2003-11-20', 89875422456, 'Aigul.Nazipova@kpfu.ru', 'Бизнес информатика', 9301),
(4, 'Богданова', 'Елизавета', 'Юрьевна', '2005-08-29', 89765433123, 'EBogdanova@kpfu.ru', 'Прикладная математика', 9322),
(5, 'Степанова', 'Анастасия', 'Алексеевна', '2005-09-05', 89213345566, 'nastyspnv@kpfu.ru', 'Прикладная информатика', 9311);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `role` varchar(15) NOT NULL,
  `id` int(11) UNSIGNED NOT NULL,
  `login` varchar(50) DEFAULT NULL,
  `password` varchar(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`role`, `id`, `login`, `password`) VALUES
('admin', 1, 'marinasmirnova@kpfu.ru', '123456'),
('student', 2, 'nikita.sokolov@kpfu.ru', '789789'),
('student', 3, 'alenapashina@kpfu.ru', '231204'),
('student', 4, 'beker.diana@kpfu.ru', '010704'),
('student', 5, 'sergeivanov@kpfu.ru', '9876543'),
('студент', 6, 'EMizulina@kpfu.ru', 'EMiz');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `about_classes`
--
ALTER TABLE `about_classes`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `admin_users`
--
ALTER TABLE `admin_users`
  ADD PRIMARY KEY (`id_user`) USING BTREE;

--
-- Indexes for table `notes`
--
ALTER TABLE `notes`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `student_schedule`
--
ALTER TABLE `student_schedule`
  ADD PRIMARY KEY (`id`),
  ADD KEY `group_number` (`group_number`,`faculty`);

--
-- Indexes for table `student_users`
--
ALTER TABLE `student_users`
  ADD PRIMARY KEY (`student_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`) USING BTREE;

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `about_classes`
--
ALTER TABLE `about_classes`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `admin_users`
--
ALTER TABLE `admin_users`
  MODIFY `id_user` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `notes`
--
ALTER TABLE `notes`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `student_schedule`
--
ALTER TABLE `student_schedule`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `student_users`
--
ALTER TABLE `student_users`
  MODIFY `student_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'ID студента', AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `admin_users`
--
ALTER TABLE `admin_users`
  ADD CONSTRAINT `admin_users_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `users` (`id`);

--
-- Constraints for table `student_users`
--
ALTER TABLE `student_users`
  ADD CONSTRAINT `student_users_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `users` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
