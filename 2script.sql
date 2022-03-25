-- MySQL Script generated by MySQL Workbench
-- Thu Mar 24 21:33:23 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema 2examen
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema 2examen
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `2examen` DEFAULT CHARACTER SET utf8 ;
USE `2examen` ;

-- -----------------------------------------------------
-- Table `2examen`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `2examen`.`usuario` (
  `Codigo` VARCHAR(45) NOT NULL,
  `Nombre` VARCHAR(45) NULL,
  `Clave` VARCHAR(45) NULL,
  PRIMARY KEY (`Codigo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `2examen`.`producto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `2examen`.`producto` (
  `Codigo` VARCHAR(45) NOT NULL,
  `Descripcion` VARCHAR(45) NULL,
  `Precio` DECIMAL(18,2) NULL,
  `Existencia` INT NULL,
  PRIMARY KEY (`Codigo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `2examen`.`pedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `2examen`.`pedido` (
  `CodigoProducto` VARCHAR(45) NOT NULL,
  `Nombre_Producto` VARCHAR(45) NULL,
  `Cantidad` INT NULL,
  `Nombre` VARCHAR(45) NULL,
  PRIMARY KEY (`CodigoProducto`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;