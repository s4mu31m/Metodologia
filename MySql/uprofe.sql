-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 25, 2022 at 11:48 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `uprofe`
--

-- --------------------------------------------------------

--
-- Table structure for table `asignatura`
--

CREATE TABLE `asignatura` (
  `id_asignatura` int(11) NOT NULL,
  `nombre_asignatura` varchar(20) NOT NULL,
  `cantidad_horas` int(11) NOT NULL,
  `valor_hora` int(11) NOT NULL,
  `mes_impartido` varchar(45) NOT NULL,
  `profesor_asignatura` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `asignatura`
--

INSERT INTO `asignatura` (`id_asignatura`, `nombre_asignatura`, `cantidad_horas`, `valor_hora`, `mes_impartido`, `profesor_asignatura`) VALUES
(0, 'asdas', 121, 2500, 'mayo', 'ceasr'),
(1, 'chupar verga', 132, 100, 'diciembre', 'cesar');

-- --------------------------------------------------------

--
-- Table structure for table `clases_hrs`
--

CREATE TABLE `clases_hrs` (
  `cant_hrs` int(11) NOT NULL,
  `valor_hrs` int(11) DEFAULT NULL,
  `mes` date DEFAULT NULL,
  `hrs_clase` int(11) DEFAULT NULL,
  `asignatura` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `exp_profe`
--

CREATE TABLE `exp_profe` (
  `titulo` varchar(40) NOT NULL,
  `asignatura` varchar(30) DEFAULT NULL,
  `experiencia` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `profesor`
--

CREATE TABLE `profesor` (
  `id_profesor` int(11) NOT NULL,
  `nombre` varchar(20) DEFAULT NULL,
  `usuario` varchar(15) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `rut` varchar(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE `usuarios` (
  `id_usuario` int(11) NOT NULL,
  `usuario` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `tipo_usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`id_usuario`, `usuario`, `password`, `tipo_usuario`) VALUES
(1, 'admin', 'admin', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asignatura`
--
ALTER TABLE `asignatura`
  ADD PRIMARY KEY (`id_asignatura`),
  ADD KEY `profe_asoc_idx` (`nombre_asignatura`),
  ADD KEY `nombre` (`cantidad_horas`);

--
-- Indexes for table `clases_hrs`
--
ALTER TABLE `clases_hrs`
  ADD PRIMARY KEY (`cant_hrs`),
  ADD KEY `index` (`asignatura`);

--
-- Indexes for table `exp_profe`
--
ALTER TABLE `exp_profe`
  ADD PRIMARY KEY (`titulo`),
  ADD KEY `index` (`experiencia`);

--
-- Indexes for table `profesor`
--
ALTER TABLE `profesor`
  ADD PRIMARY KEY (`id_profesor`),
  ADD KEY `index` (`nombre`),
  ADD KEY `id_profesor` (`id_profesor`,`usuario`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `asignatura`
--
ALTER TABLE `asignatura`
  MODIFY `id_asignatura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
