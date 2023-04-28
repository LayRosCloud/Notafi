-- phpMyAdmin SQL Dump


CREATE TABLE `Address` (
  `ID` int(11) NOT NULL,
  `CountryID` int(11) NOT NULL DEFAULT 1,
  `RegionID` int(11) NOT NULL DEFAULT 1,
  `MailAddressID` int(11) NOT NULL DEFAULT 1,
  `CityID` int(11) NOT NULL DEFAULT 1,
  `StreetID` int(11) NOT NULL DEFAULT 1,
  `Corpus` varchar(5) DEFAULT NULL,
  `HomeNumber` int(11) NOT NULL DEFAULT 1,
  `Apartment` int(11) NOT NULL DEFAULT 1
);

--
-- Дамп данных таблицы `Address`
--

INSERT INTO `Address` (`ID`, `CountryID`, `RegionID`, `MailAddressID`, `CityID`, `StreetID`, `Corpus`, `HomeNumber`, `Apartment`) VALUES
(1, 2, 1, 1, 1, 1, '', 152, 1),
(2, 1, 1, 1, 1, 1, '2Б', 154, 2),
(3, 1, 1, 1, 2, 2, '', 21, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `City`
--

CREATE TABLE `City` (
  `ID` int(11) NOT NULL,
  `Name` varchar(30) NOT NULL
);

--
-- Дамп данных таблицы `City`
--

INSERT INTO `City` (`ID`, `Name`) VALUES
(2, 'Белый яр'),
(1, 'Очуры');

-- --------------------------------------------------------

--
-- Структура таблицы `Country`
--

CREATE TABLE `Country` (
  `ID` int(11) NOT NULL,
  `Name` varchar(30) NOT NULL
);

--
-- Дамп данных таблицы `Country`
--

INSERT INTO `Country` (`ID`, `Name`) VALUES
(2, 'Белорусь'),
(1, 'Российская Федерация');

-- --------------------------------------------------------

--
-- Структура таблицы `Deal`
--

CREATE TABLE `Deal` (
  `ID` int(11) NOT NULL,
  `Date` datetime NOT NULL,
  `WorkerID` int(11) NOT NULL,
  `PersonID` int(11) NOT NULL,
  `Comission` double NOT NULL
);

--
-- Дамп данных таблицы `Deal`
--

INSERT INTO `Deal` (`ID`, `Date`, `WorkerID`, `PersonID`, `Comission`) VALUES
(4, '2023-04-18 00:00:00', 1, 3, 0),
(5, '2023-04-18 00:00:00', 1, 1, 0),
(7, '2023-04-20 00:00:00', 1, 1, 0);

-- --------------------------------------------------------

--
-- Структура таблицы `DealResult`
--

CREATE TABLE `DealResult` (
  `ID` int(11) NOT NULL,
  `DealID` int(11) NOT NULL,
  `ResultID` int(11) NOT NULL
);

--
-- Дамп данных таблицы `DealResult`
--

INSERT INTO `DealResult` (`ID`, `DealID`, `ResultID`) VALUES
(7, 7, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `DealService`
--

CREATE TABLE `DealService` (
  `ID` int(11) NOT NULL,
  `DealID` int(11) NOT NULL,
  `ServiceID` int(11) NOT NULL,
  `Number` int(11) NOT NULL
);

--
-- Дамп данных таблицы `DealService`
--

INSERT INTO `DealService` (`ID`, `DealID`, `ServiceID`, `Number`) VALUES
(7, 7, 3, 1),
(8, 7, 4, 1),
(9, 7, 5, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `Discount`
--

CREATE TABLE `Discount` (
  `ID` int(11) NOT NULL,
  `Date` datetime NOT NULL,
  `Number` double NOT NULL
);

--
-- Дамп данных таблицы `Discount`
--

INSERT INTO `Discount` (`ID`, `Date`, `Number`) VALUES
(1, '2020-11-20 00:00:00', 0),
(2, '2020-11-20 00:00:00', 10),
(3, '2020-11-20 00:00:00', 20),
(4, '2020-11-20 00:00:00', 30),
(5, '2020-11-20 00:00:00', 40),
(6, '2020-11-20 00:00:00', 50),
(7, '2023-04-18 09:17:34', 10);

-- --------------------------------------------------------

--
-- Структура таблицы `FavoriteService`
--

CREATE TABLE `FavoriteService` (
  `ID` int(11) NOT NULL,
  `PersonID` int(11) NOT NULL,
  `ServiceID` int(11) NOT NULL,
  `Number` int(11) NOT NULL
);

--
-- Дамп данных таблицы `FavoriteService`
--

INSERT INTO `FavoriteService` (`ID`, `PersonID`, `ServiceID`, `Number`) VALUES
(1, 1, 3, 1),
(2, 1, 4, 1),
(3, 1, 5, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `IssuedByWhom`
--

CREATE TABLE `IssuedByWhom` (
  `ID` int(11) NOT NULL,
  `Code` char(7) NOT NULL,
  `Name` varchar(255) NOT NULL
);

--
-- Дамп данных таблицы `IssuedByWhom`
--

INSERT INTO `IssuedByWhom` (`ID`, `Code`, `Name`) VALUES
(1, '190-001', 'УФМС РОССИИ ПО РЕСПУБЛИКЕ ХАКАСИЯ'),
(2, '190-002', 'ОУФМС РОССИИ ПО РЕСПУБЛИКЕ ХАКАСИЯ В Г. АБАКАНЕ'),
(3, '190-003', 'ОУФМС РОССИИ ПО РЕСПУБЛИКЕ ХАКАСИЯ В Г. САЯНОГОРСКЕ'),
(4, '190-004', 'ОУФМС РОССИИ ПО РЕСПУБЛИКЕ ХАКАСИЯ В Г. ЧЕРНОГОРСКЕ'),
(5, '190-005', 'ОУФМС РОССИИ ПО РЕСПУБЛИКЕ ХАКАСИЯ В АСКИЗСКОМ Р-НЕ'),
(6, '190-006', 'ОУФМС РОССИИ ПО РЕСПУБЛИКЕ ХАКАСИЯ В УСТЬ-АБАКАНСКОМ Р-НЕ'),
(7, '190-007', 'ОУФМС РОССИИ ПО РЕСПУБЛИКЕ ХАКАСИЯ В ШИРИНСКОМ Р-НЕ'),
(8, '190-008', 'ТП УФМС РОССИИ ПО РЕСПУБЛИКЕ ХАКАСИЯ В Г. АБАЗА'),
(9, '190-009', 'ТП УФМС РОССИИ ПО РЕСПУБЛИКЕ ХАКАСИЯ В АЛТАЙСКОМ Р-НЕ'),
(10, '190-010', 'МП УФМС России по Республике Хакасия в Бейском р-не'),
(11, '190-010', 'ТП УФМС РОССИИ ПО РЕСПУБЛИКЕ ХАКАСИЯ В БЕЙСКОМ Р-НЕ'),
(12, '190-011', 'ТП УФМС РОССИИ ПО РЕСПУБЛИКЕ ХАКАСИЯ В БОГРАДСКОМ Р-НЕ'),
(13, '190-012', 'ТП УФМС РОССИИ ПО РЕСПУБЛИКЕ ХАКАСИЯ В ОРДЖОНИКИДЗЕВСКОМ Р-НЕ'),
(14, '190-013', 'ТП УФМС РОССИИ ПО РЕСПУБЛИКЕ ХАКАСИЯ В Г. СОРСКЕ'),
(15, '190-014', 'ТП УФМС РОССИИ ПО РЕСПУБЛИКЕ ХАКАСИЯ В ТАШТЫПСКОМ Р-НЕ'),
(16, '191-001', 'МВД РЕСПУБЛИКИ ХАКАСИЯ'),
(17, '192-001', 'УВД Г. АБАКАНА'),
(18, '192-002', 'ОВД Г. ЧЕРНОГОРСКА РЕСПУБЛИКИ ХАКАСИЯ'),
(19, '192-003', 'ОВД Г. САЯНОГОРСКА РЕСПУБЛИКИ ХАКАСИЯ'),
(20, '192-004', 'ОВД УСТЬ-АБАКАНСКОГО Р-НА РЕСПУБЛИКИ ХАКАСИЯ'),
(21, '192-005', 'ОВД АЛТАЙСКОГО Р-НА РЕСПУБЛИКИ ХАКАСИЯ'),
(22, '192-006', 'ОВД БЕЙСКОГО Р-НА РЕСПУБЛИКИ ХАКАСИЯ'),
(23, '192-007', 'ОВД АСКИЗСКОГО Р-НА РЕСПУБЛИКИ ХАКАСИЯ'),
(24, '192-008', 'ОВД ТАШТЫПСКОГО Р-НА РЕСПУБЛИКИ ХАКАСИЯ'),
(25, '192-009', 'ОВД БОГРАДСКОГО Р-НА РЕСПУБЛИКИ ХАКАСИЯ'),
(26, '192-010', 'ОВД ШИРИНСКОГО Р-НА РЕСПУБЛИКИ ХАКАСИЯ'),
(27, '192-011', 'ОВД ОРДЖОНИКИДЗЕВСКОГО Р-НА РЕСПУБЛИКИ ХАКАСИЯ'),
(28, '192-012', 'ОТДЕЛ ВНУТРЕННИХ ДЕЛ Г. АБАЗЫ РЕСПУБЛИКИ ХАКАСИЯ'),
(29, '192-013', 'ОТДЕЛ ВНУТРЕННИХ ДЕЛ Г. СОРСКА РЕСПУБЛИКИ ХАКАСИЯ');

-- --------------------------------------------------------

--
-- Структура таблицы `MailAddress`
--

CREATE TABLE `MailAddress` (
  `ID` int(11) NOT NULL,
  `Name` int(11) NOT NULL
);

--
-- Дамп данных таблицы `MailAddress`
--

INSERT INTO `MailAddress` (`ID`, `Name`) VALUES
(1, 655674);

-- --------------------------------------------------------

--
-- Структура таблицы `Person`
--

CREATE TABLE `Person` (
  `ID` int(11) NOT NULL,
  `LastName` varchar(30) NOT NULL,
  `FirstName` varchar(30) NOT NULL,
  `Patronymic` varchar(30) DEFAULT NULL,
  `AddressID` int(11) NOT NULL,
  `Phone` varchar(13) NOT NULL,
  `Sex` tinyint(1) NOT NULL DEFAULT 1,
  `BirthDay` date NOT NULL,
  `Series` int(11) NOT NULL,
  `NumberOfPassport` int(11) NOT NULL,
  `ISW_ID` int(11) NOT NULL
);

--
-- Дамп данных таблицы `Person`
--

INSERT INTO `Person` (`ID`, `LastName`, `FirstName`, `Patronymic`, `AddressID`, `Phone`, `Sex`, `BirthDay`, `Series`, `NumberOfPassport`, `ISW_ID`) VALUES
(1, 'Степанов', 'Виталий', 'Викторович', 1, '+79235812865', 0, '2000-01-01', 1111, 111111, 1),
(2, 'Иванов', 'Иван', 'Иванович', 2, '+79235812865', 0, '2000-02-09', 9612, 123254, 1),
(3, 'Лель', 'Виктор', 'Герасимович', 3, '+79762831399', 0, '1970-10-24', 2341, 231254, 10);

-- --------------------------------------------------------

--
-- Структура таблицы `Post`
--

CREATE TABLE `Post` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL
);

--
-- Дамп данных таблицы `Post`
--

INSERT INTO `Post` (`ID`, `Name`) VALUES
(1, 'Нотариус'),
(2, 'Менеджер по отделу кадров');

-- --------------------------------------------------------

--
-- Структура таблицы `Price`
--

CREATE TABLE `Price` (
  `ID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Number` double NOT NULL
);

--
-- Дамп данных таблицы `Price`
--

INSERT INTO `Price` (`ID`, `Date`, `Number`) VALUES
(1, '2020-11-21', 249.99),
(2, '2020-11-22', 209.99),
(3, '2020-11-23', 749.99),
(4, '2020-11-24', 349.99),
(5, '2020-11-25', 499.99),
(6, '2023-04-18', 249.99),
(8, '2023-04-18', 249.98),
(9, '2023-04-18', 249.96);

-- --------------------------------------------------------

--
-- Структура таблицы `Region`
--

CREATE TABLE `Region` (
  `ID` int(11) NOT NULL,
  `Name` varchar(30) NOT NULL
);

--
-- Дамп данных таблицы `Region`
--

INSERT INTO `Region` (`ID`, `Name`) VALUES
(1, 'Алтайский район');

-- --------------------------------------------------------

--
-- Структура таблицы `Result`
--

CREATE TABLE `Result` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL
);

--
-- Дамп данных таблицы `Result`
--

INSERT INTO `Result` (`ID`, `Name`) VALUES
(2, 'В процессе'),
(1, 'Закончена'),
(3, 'Провалена');

-- --------------------------------------------------------

--
-- Структура таблицы `Role`
--

CREATE TABLE `Role` (
  `ID` int(11) NOT NULL,
  `Name` varchar(30) NOT NULL
);

--
-- Дамп данных таблицы `Role`
--

INSERT INTO `Role` (`ID`, `Name`) VALUES
(1, 'Клиент'),
(2, 'Работник'),
(3, 'Редактор данных БД');

-- --------------------------------------------------------

--
-- Структура таблицы `Service`
--

CREATE TABLE `Service` (
  `ID` int(11) NOT NULL,
  `Title` varchar(30) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `TypeOfDocument` varchar(255) NOT NULL,
  `PriceID` int(11) NOT NULL,
  `DiscountID` int(11) NOT NULL,
  `ImageIcon` varchar(255) DEFAULT NULL
);

--
-- Дамп данных таблицы `Service`
--

INSERT INTO `Service` (`ID`, `Title`, `Description`, `TypeOfDocument`, `PriceID`, `DiscountID`, `ImageIcon`) VALUES
(3, 'Печать', 'Печатаем ваш документ', 'КЗ-201', 2, 2, ''),
(4, 'Подпись', 'Подписываем ваш документ', 'КЗ-201', 2, 4, '/Res/Images/imageErrorFull.png'),
(5, 'Защита на суде', 'Защищаем вас на суде', 'КЗ-201', 1, 3, '/Res/Images/imageErrorFull.png'),
(15, 'Тест', 'Тестовая беременность', 'Кз', 6, 4, '');

-- --------------------------------------------------------

--
-- Структура таблицы `Street`
--

CREATE TABLE `Street` (
  `ID` int(11) NOT NULL,
  `Name` varchar(20) NOT NULL
);

--
-- Дамп данных таблицы `Street`
--

INSERT INTO `Street` (`ID`, `Name`) VALUES
(2, 'Ленина'),
(1, 'Чкалова');

-- --------------------------------------------------------

--
-- Структура таблицы `User`
--

CREATE TABLE `User` (
  `ID` int(11) NOT NULL,
  `PersonID` int(11) NOT NULL,
  `Login` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `RoleID` int(11) NOT NULL DEFAULT 1
);

--
-- Дамп данных таблицы `User`
--

INSERT INTO `User` (`ID`, `PersonID`, `Login`, `Password`, `Email`, `RoleID`) VALUES
(1, 1, 'betrayal', 'sefikboom', 'vogistv@gmail.com', 1),
(2, 2, 'notarius', 'nota', 'notarius@gmail.ru', 2),
(3, 3, 'manager', 'mana', 'manager@manager.com', 3);

-- --------------------------------------------------------

--
-- Структура таблицы `Worker`
--

CREATE TABLE `Worker` (
  `ID` int(11) NOT NULL,
  `PersonID` int(11) NOT NULL,
  `PostID` int(11) NOT NULL
);

--
-- Дамп данных таблицы `Worker`
--

INSERT INTO `Worker` (`ID`, `PersonID`, `PostID`) VALUES
(1, 2, 1);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Address`
--
ALTER TABLE `Address`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FK_Address_City_ID` (`CityID`),
  ADD KEY `FK_Address_Country_ID` (`CountryID`),
  ADD KEY `FK_Address_MailAddress_ID` (`MailAddressID`),
  ADD KEY `FK_Address_Region_ID` (`RegionID`),
  ADD KEY `FK_Address_Street_ID` (`StreetID`);

--
-- Индексы таблицы `City`
--
ALTER TABLE `City`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `UQ` (`Name`);

--
-- Индексы таблицы `Country`
--
ALTER TABLE `Country`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Name` (`Name`);

--
-- Индексы таблицы `Deal`
--
ALTER TABLE `Deal`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FK_Deal_Person_ID` (`PersonID`),
  ADD KEY `FK_Deal_Workers_ID` (`WorkerID`);

--
-- Индексы таблицы `DealResult`
--
ALTER TABLE `DealResult`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `DealID` (`DealID`),
  ADD KEY `FK_DealResult_Result_ID` (`ResultID`);

--
-- Индексы таблицы `DealService`
--
ALTER TABLE `DealService`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FK_DealService_Deal_ID` (`DealID`),
  ADD KEY `FK_DealService_Service_ID` (`ServiceID`);

--
-- Индексы таблицы `Discount`
--
ALTER TABLE `Discount`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `FavoriteService`
--
ALTER TABLE `FavoriteService`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FK_PERSON` (`PersonID`),
  ADD KEY `FK_SERVICE` (`ServiceID`);

--
-- Индексы таблицы `IssuedByWhom`
--
ALTER TABLE `IssuedByWhom`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `MailAddress`
--
ALTER TABLE `MailAddress`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Name` (`Name`);

--
-- Индексы таблицы `Person`
--
ALTER TABLE `Person`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FK_Person_IssuedByWhom_ID` (`ISW_ID`),
  ADD KEY `FK_Person_Address_ID` (`AddressID`);

--
-- Индексы таблицы `Post`
--
ALTER TABLE `Post`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `Price`
--
ALTER TABLE `Price`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `Region`
--
ALTER TABLE `Region`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Name` (`Name`);

--
-- Индексы таблицы `Result`
--
ALTER TABLE `Result`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Name` (`Name`);

--
-- Индексы таблицы `Role`
--
ALTER TABLE `Role`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `Service`
--
ALTER TABLE `Service`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FK_Service_Price_ID` (`PriceID`),
  ADD KEY `FK_Service_Discount_ID` (`DiscountID`);

--
-- Индексы таблицы `Street`
--
ALTER TABLE `Street`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Name` (`Name`);

--
-- Индексы таблицы `User`
--
ALTER TABLE `User`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `Worker`
--
ALTER TABLE `Worker`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `Address`
--
ALTER TABLE `Address`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `City`
--
ALTER TABLE `City`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `Country`
--
ALTER TABLE `Country`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `Deal`
--
ALTER TABLE `Deal`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `DealResult`
--
ALTER TABLE `DealResult`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `DealService`
--
ALTER TABLE `DealService`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `Discount`
--
ALTER TABLE `Discount`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `FavoriteService`
--
ALTER TABLE `FavoriteService`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `IssuedByWhom`
--
ALTER TABLE `IssuedByWhom`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT для таблицы `MailAddress`
--
ALTER TABLE `MailAddress`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `Person`
--
ALTER TABLE `Person`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `Post`
--
ALTER TABLE `Post`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `Price`
--
ALTER TABLE `Price`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `Region`
--
ALTER TABLE `Region`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `Result`
--
ALTER TABLE `Result`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `Role`
--
ALTER TABLE `Role`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `Service`
--
ALTER TABLE `Service`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT для таблицы `Street`
--
ALTER TABLE `Street`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `User`
--
ALTER TABLE `User`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `Worker`
--
ALTER TABLE `Worker`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `DealResult`
--
ALTER TABLE `DealResult`
  ADD CONSTRAINT `FK_DealResult_Deal_Id` FOREIGN KEY (`DealID`) REFERENCES `Deal` (`ID`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `DealService`
--
ALTER TABLE `DealService`
  ADD CONSTRAINT `DK_DealService_Deal_ID` FOREIGN KEY (`DealID`) REFERENCES `Deal` (`ID`) ON DELETE CASCADE,
  ADD CONSTRAINT `DK_DealService_Service_Id` FOREIGN KEY (`ServiceID`) REFERENCES `Service` (`ID`);

--
-- Ограничения внешнего ключа таблицы `FavoriteService`
--
ALTER TABLE `FavoriteService`
  ADD CONSTRAINT `FK_PERSON` FOREIGN KEY (`PersonID`) REFERENCES `Person` (`ID`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_SERVICE` FOREIGN KEY (`ServiceID`) REFERENCES `Service` (`ID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
