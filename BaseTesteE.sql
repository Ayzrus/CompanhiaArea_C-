-- --------------------------------------------------------
-- Anfitrião:                    127.0.0.1
-- Versão do servidor:           10.4.32-MariaDB - mariadb.org binary distribution
-- SO do servidor:               Win64
-- HeidiSQL Versão:              12.6.0.6765
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- A despejar estrutura da base de dados para companhiaarea
CREATE DATABASE IF NOT EXISTS `companhiaarea` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `companhiaarea`;

-- A despejar estrutura para tabela companhiaarea.aeroportos
CREATE TABLE IF NOT EXISTS `aeroportos` (
  `Codigo` int(11) NOT NULL,
  `Nome` text NOT NULL,
  `Latitude` float NOT NULL,
  `Longitude` float NOT NULL,
  `Local` text NOT NULL,
  `Pais` text NOT NULL,
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela companhiaarea.avioes
CREATE TABLE IF NOT EXISTS `avioes` (
  `Numero_Aviao` int(11) NOT NULL,
  `Marca` text NOT NULL,
  `Modelo` text NOT NULL,
  `Horas_Total` float NOT NULL,
  `Horas_Revisao` float NOT NULL,
  `Capacidade` int(11) NOT NULL,
  PRIMARY KEY (`Numero_Aviao`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela companhiaarea.opera
CREATE TABLE IF NOT EXISTS `opera` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `N_Voo` int(11) NOT NULL,
  `Id_Tripulacao` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `N_Voo` (`N_Voo`),
  KEY `Id_Tripulacao` (`Id_Tripulacao`),
  CONSTRAINT `opera_ibfk_1` FOREIGN KEY (`N_Voo`) REFERENCES `voo` (`Numero_Voo`),
  CONSTRAINT `opera_ibfk_2` FOREIGN KEY (`Id_Tripulacao`) REFERENCES `tripulantes` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela companhiaarea.passageiros
CREATE TABLE IF NOT EXISTS `passageiros` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Milhas` float NOT NULL,
  `Id_Pessoa` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `FK_passageiros_pessoas` (`Id_Pessoa`),
  CONSTRAINT `FK_passageiros_pessoas` FOREIGN KEY (`Id_Pessoa`) REFERENCES `pessoas` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela companhiaarea.pessoas
CREATE TABLE IF NOT EXISTS `pessoas` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` text NOT NULL,
  `Contacto` text NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela companhiaarea.tripulantes
CREATE TABLE IF NOT EXISTS `tripulantes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Categoria` text NOT NULL,
  `Funcao` text NOT NULL,
  `Horas` float NOT NULL,
  `Id_Pessoa` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `FK_tripulantes_pessoas` (`Id_Pessoa`),
  CONSTRAINT `FK_tripulantes_pessoas` FOREIGN KEY (`Id_Pessoa`) REFERENCES `pessoas` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela companhiaarea.viagens
CREATE TABLE IF NOT EXISTS `viagens` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `N_Voo` int(11) NOT NULL,
  `Id_Passageiro` int(11) NOT NULL,
  `Lugar` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `N_Voo` (`N_Voo`),
  KEY `Id_Passageiro` (`Id_Passageiro`),
  CONSTRAINT `viagens_ibfk_1` FOREIGN KEY (`N_Voo`) REFERENCES `voo` (`Numero_Voo`),
  CONSTRAINT `viagens_ibfk_2` FOREIGN KEY (`Id_Passageiro`) REFERENCES `passageiros` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

-- A despejar estrutura para tabela companhiaarea.voo
CREATE TABLE IF NOT EXISTS `voo` (
  `Numero_Voo` int(11) NOT NULL,
  `Data` date NOT NULL,
  `Origem` int(11) NOT NULL,
  `Destino` int(11) NOT NULL,
  `N_Aviao` int(11) NOT NULL,
  PRIMARY KEY (`Numero_Voo`),
  KEY `N_Aviao` (`N_Aviao`),
  KEY `Origem` (`Origem`),
  KEY `Destino` (`Destino`),
  CONSTRAINT `voo_ibfk_1` FOREIGN KEY (`N_Aviao`) REFERENCES `avioes` (`Numero_Aviao`),
  CONSTRAINT `voo_ibfk_2` FOREIGN KEY (`Origem`) REFERENCES `aeroportos` (`Codigo`),
  CONSTRAINT `voo_ibfk_3` FOREIGN KEY (`Destino`) REFERENCES `aeroportos` (`Codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados não seleccionada.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
