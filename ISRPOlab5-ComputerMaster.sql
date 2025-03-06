-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Мар 06 2025 г., 17:07
-- Версия сервера: 10.8.4-MariaDB
-- Версия PHP: 7.4.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `ISRPOlab5-ComputerMaster`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Client`
--

CREATE TABLE `Client` (
  `Id` int(11) NOT NULL,
  `Surname` varchar(63) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Name` varchar(63) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Patronimyc` varchar(63) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Email` varchar(63) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Telephone` varchar(63) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Address` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `Commission`
--

CREATE TABLE `Commission` (
  `Id` int(11) NOT NULL,
  `Computer_Id` int(11) NOT NULL,
  `Commission_Date` date NOT NULL,
  `Commission_Price` decimal(10,2) NOT NULL,
  `Client_Id` int(11) NOT NULL,
  `Status` varchar(63) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Note` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `Computer`
--

CREATE TABLE `Computer` (
  `Id` int(11) NOT NULL,
  `Model` varchar(127) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Processor` varchar(127) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Ram` varchar(127) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Hdd` varchar(127) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `Amount` int(11) NOT NULL,
  `Description` text COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Client`
--
ALTER TABLE `Client`
  ADD PRIMARY KEY (`Id`);

--
-- Индексы таблицы `Commission`
--
ALTER TABLE `Commission`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `fk_commission_computer` (`Computer_Id`),
  ADD KEY `fk_commission_client` (`Client_Id`);

--
-- Индексы таблицы `Computer`
--
ALTER TABLE `Computer`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `Client`
--
ALTER TABLE `Client`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `Commission`
--
ALTER TABLE `Commission`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `Computer`
--
ALTER TABLE `Computer`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `Commission`
--
ALTER TABLE `Commission`
  ADD CONSTRAINT `fk_commission_client` FOREIGN KEY (`Client_Id`) REFERENCES `Client` (`Id`),
  ADD CONSTRAINT `fk_commission_computer` FOREIGN KEY (`Computer_Id`) REFERENCES `Computer` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
