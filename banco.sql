-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: 26-Mar-2020 às 12:58
-- Versão do servidor: 8.0.13-4
-- versão do PHP: 7.2.24-0ubuntu0.18.04.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `P3P5FburXL`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `Cidade`
--

CREATE TABLE `Cidade` (
  `idCidade` int(11) NOT NULL,
  `descricao` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `fkidEstado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `Estado`
--

CREATE TABLE `Estado` (
  `idEstado` int(11) NOT NULL,
  `descricao` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `fkidPais` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `Paciente`
--

CREATE TABLE `Paciente` (
  `idPaciente` int(11) NOT NULL,
  `nome` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `cpf` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `fkidPais` int(11) NOT NULL,
  `fkidEstado` int(11) NOT NULL,
  `fkidCidade` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `Pais`
--

CREATE TABLE `Pais` (
  `idPais` int(11) NOT NULL,
  `descricao` varchar(30) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Cidade`
--
ALTER TABLE `Cidade`
  ADD PRIMARY KEY (`idCidade`),
  ADD KEY `fkidEstado` (`fkidEstado`);

--
-- Indexes for table `Estado`
--
ALTER TABLE `Estado`
  ADD PRIMARY KEY (`idEstado`),
  ADD KEY `fkidPais` (`fkidPais`);

--
-- Indexes for table `Paciente`
--
ALTER TABLE `Paciente`
  ADD PRIMARY KEY (`idPaciente`),
  ADD KEY `fkidPais` (`fkidPais`),
  ADD KEY `fkidEstado` (`fkidEstado`),
  ADD KEY `fkidCidade` (`fkidCidade`);

--
-- Indexes for table `Pais`
--
ALTER TABLE `Pais`
  ADD PRIMARY KEY (`idPais`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Cidade`
--
ALTER TABLE `Cidade`
  MODIFY `idCidade` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `Estado`
--
ALTER TABLE `Estado`
  MODIFY `idEstado` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `Paciente`
--
ALTER TABLE `Paciente`
  MODIFY `idPaciente` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `Pais`
--
ALTER TABLE `Pais`
  MODIFY `idPais` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `Cidade`
--
ALTER TABLE `Cidade`
  ADD CONSTRAINT `Cidade_ibfk_1` FOREIGN KEY (`fkidEstado`) REFERENCES `Estado` (`idestado`);

--
-- Limitadores para a tabela `Estado`
--
ALTER TABLE `Estado`
  ADD CONSTRAINT `Estado_ibfk_1` FOREIGN KEY (`fkidPais`) REFERENCES `Pais` (`idpais`);

--
-- Limitadores para a tabela `Paciente`
--
ALTER TABLE `Paciente`
  ADD CONSTRAINT `Paciente_ibfk_1` FOREIGN KEY (`fkidPais`) REFERENCES `Pais` (`idpais`),
  ADD CONSTRAINT `Paciente_ibfk_2` FOREIGN KEY (`fkidEstado`) REFERENCES `Estado` (`idestado`),
  ADD CONSTRAINT `Paciente_ibfk_3` FOREIGN KEY (`fkidCidade`) REFERENCES `Cidade` (`idcidade`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
