-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 27-07-2022 a las 23:08:46
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `curso_db`
--

--
-- Volcado de datos para la tabla `alumno`
--

INSERT INTO `alumno` (`Id`, `CursoId`, `Nombre`, `Edad`) VALUES
(1, 1, 'Raimundo Battle', 6),
(2, 1, 'Gil Pujol', 6),
(3, 1, 'Joaquina Romeu', 6),
(4, 1, 'Emigdio Vilaplana', 6),
(5, 1, 'Margarita Mugica', 6),
(6, 1, 'Rosalia Hernando', 6),
(7, 1, 'Cruz Egea', 6),
(8, 1, 'Yago Estrada', 6),
(9, 1, 'Maximiliano Salvador', 6),
(10, 1, 'Ismael Crespo', 6),
(11, 2, 'Efrain Bautista', 7),
(12, 2, 'Rolandi Bustos', 7),
(13, 2, 'Baudelio Viana', 7),
(14, 2, 'Evita Camancho', 7),
(15, 2, 'Gaston Vara', 7),
(16, 2, 'Yesica Puig', 7),
(17, 2, 'Fabio Acedo', 7),
(18, 2, 'Mercedes Roldan', 7),
(19, 2, 'Abril Pozo', 7),
(20, 2, 'Luisa Jodar', 7),
(21, 3, 'Matilde Oliva', 8),
(22, 3, 'Yéssica Mata', 8),
(23, 3, 'Sebastian Cabrero', 8),
(24, 3, 'Eva Huerta', 8),
(25, 3, 'Salomon Fernandez', 8),
(26, 3, 'Benito Gimeno', 8),
(27, 3, 'Roberta Busquet', 8),
(28, 3, 'Humberto Rozas', 8),
(29, 3, 'Pricila Ureña', 8),
(30, 3, 'Belen Soler', 8);

--
-- Volcado de datos para la tabla `curso`
--

INSERT INTO `curso` (`Id`, `Descripcion`, `NroSala`, `FechaCreacion`, `Activo`) VALUES
(1, 'Primero Básico', 101, '2022-07-26 17:26:22', 1),
(2, 'Segundo Básico', 102, '2022-07-27 21:26:22', 1),
(3, 'Tercero Básico', 103, '2022-07-28 13:26:22', 1);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
