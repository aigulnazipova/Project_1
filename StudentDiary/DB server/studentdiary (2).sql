-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Мар 30 2024 г., 15:03
-- Версия сервера: 5.7.24
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `studentdiary`
--

-- --------------------------------------------------------

--
-- Структура таблицы `about_classes`
--

CREATE TABLE `about_classes` (
  `ID` int(11) NOT NULL,
  `subject_name` varchar(100) NOT NULL COMMENT 'Название',
  `format` varchar(100) NOT NULL COMMENT 'Формат',
  `info` varchar(1000) NOT NULL COMMENT 'Информация'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `about_classes`
--

INSERT INTO `about_classes` (`ID`, `subject_name`, `format`, `info`) VALUES
(1, 'Алгебра и геометрия', 'Лекция', 'Преподаватель: Карчевский Е.М. Количество учебных часов:54. Зачет:+. Экзамен:+'),
(2, 'Алгебра и геометрия', 'Семинар', 'Преподаватели: Гиниятова Д.Х., Александрова И.Л. Количество учебных часов:54\r\n\r\n'),
(3, 'Математический анализ', 'Лекция', 'Преподаватель: Сидоров А.М. Количество учебных часов:54. Зачет:+. Экзамен:+'),
(4, 'Математический анализ', 'Семинар', 'Преподаватели: Сидоров А.М., Тумаков М.Д.. Количество учебных часов:54');

-- --------------------------------------------------------

--
-- Структура таблицы `admin_users`
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
-- Дамп данных таблицы `admin_users`
--

INSERT INTO `admin_users` (`id_user`, `last_name`, `first_name`, `patronymic`, `birth_date`, `phone_number`, `email`) VALUES
(1, 'Смирнова', 'Марина', 'Александровна', '1993-09-02', 89101060546, 'marinasmirnova@kpfu.ru');

-- --------------------------------------------------------

--
-- Структура таблицы `student_schedule`
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
-- Дамп данных таблицы `student_schedule`
--

INSERT INTO `student_schedule` (`id`, `group_number`, `faculty`, `week_day`, `class_number`, `subject_name`, `format`) VALUES
(1, 9322, 'Прикладная математика', 'Понедельник', 1, 'Математический анализ', 'Лекция'),
(2, 9322, 'Прикладная математика', 'Понедельник', 2, 'Иностранный язык', 'Семинар'),
(3, 9322, 'Прикладная математика', 'Понедельник', 3, 'Математический анализ', 'Семинар'),
(4, 9322, 'Прикладная математика', 'Понедельник', 4, 'История России', 'Семинар'),
(5, 9321, 'Прикладная математика', 'Вторник', 2, 'Физическая культура', 'Семинар');

-- --------------------------------------------------------

--
-- Структура таблицы `student_users`
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
-- Дамп данных таблицы `student_users`
--

INSERT INTO `student_users` (`student_id`, `last_name`, `first_name`, `patronymic`, `birth_date`, `phone_number`, `email`, `faculty`, `group_number`) VALUES
(2, 'Соколов', 'Никита', 'Андреевич', '2003-11-20', 89765433123, 'nikita.sokolov@kpfu.ru', 'Прикладная математика', 9321),
(3, 'Соколов', 'Никита', 'Андреевич', '2003-11-20', 89765433123, 'nikita.sokolov@kpfu.ru', 'Бизнес информатика', 9301),
(4, 'Соколов', 'Никита', 'Андреевич', '2003-11-20', 89765433123, 'nikita.sokolov@kpfu.ru', 'Прикладная математика', 9322),
(5, 'Соколов', 'Никита', 'Андреевич', '2003-11-20', 89765433123, 'nikita.sokolov@kpfu.ru', 'Прикладная информатика', 9311);

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `role` varchar(15) NOT NULL,
  `id` int(11) UNSIGNED NOT NULL,
  `login` varchar(50) DEFAULT NULL,
  `password` varchar(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`role`, `id`, `login`, `password`) VALUES
('admin', 1, 'marinasmirnova@kpfu.ru', '123456'),
('student', 2, 'nikita.sokolov@kpfu.ru', '789789'),
('student', 3, 'alenapashina@kpfu.ru', '231204'),
('student', 4, 'beker.diana@kpfu.ru', '010704'),
('student', 5, 'sergeivanov@kpfu.ru', '9876543');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `about_classes`
--
ALTER TABLE `about_classes`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `admin_users`
--
ALTER TABLE `admin_users`
  ADD PRIMARY KEY (`id_user`) USING BTREE;

--
-- Индексы таблицы `student_schedule`
--
ALTER TABLE `student_schedule`
  ADD PRIMARY KEY (`id`),
  ADD KEY `group_number` (`group_number`,`faculty`);

--
-- Индексы таблицы `student_users`
--
ALTER TABLE `student_users`
  ADD PRIMARY KEY (`student_id`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`) USING BTREE;

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `about_classes`
--
ALTER TABLE `about_classes`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `admin_users`
--
ALTER TABLE `admin_users`
  MODIFY `id_user` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `student_schedule`
--
ALTER TABLE `student_schedule`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `student_users`
--
ALTER TABLE `student_users`
  MODIFY `student_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'ID студента', AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `admin_users`
--
ALTER TABLE `admin_users`
  ADD CONSTRAINT `admin_users_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `users` (`id`);

--
-- Ограничения внешнего ключа таблицы `student_users`
--
ALTER TABLE `student_users`
  ADD CONSTRAINT `student_users_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `users` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
