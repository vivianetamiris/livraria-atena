-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.5.52-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.13.0.7147
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para livraria
CREATE DATABASE IF NOT EXISTS `livraria` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `livraria`;

-- Copiando estrutura para procedure livraria.sp_associar_autor_livro
DELIMITER //
CREATE PROCEDURE `sp_associar_autor_livro`(
    IN p_id_livro INT,
    IN p_id_autor INT
)
BEGIN
    IF NOT EXISTS (
        SELECT 1 FROM tb_lista
        WHERE id_livro = p_id_livro AND id_autor = p_id_autor
    ) THEN
        INSERT INTO tb_lista (id_livro, id_autor)
        VALUES (p_id_livro, p_id_autor);
    END IF;
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria.sp_cadastrar_autor
DELIMITER //
CREATE PROCEDURE `sp_cadastrar_autor`(
    IN p_nome VARCHAR(50),
    IN p_nacao VARCHAR(50),
    OUT p_id_autor INT
)
BEGIN
    DECLARE v_id INT;

    SELECT id INTO v_id
    FROM tb_autor
    WHERE nome = p_nome AND nacao = p_nacao
    LIMIT 1;

    IF v_id IS NULL THEN
        INSERT INTO tb_autor (nome, nacao)
        VALUES (p_nome, p_nacao);
        SET v_id = LAST_INSERT_ID();
    END IF;

    SET p_id_autor = v_id;
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria.sp_cadastrar_edicao
DELIMITER //
CREATE PROCEDURE `sp_cadastrar_edicao`(
    IN p_editora VARCHAR(50),
    IN p_ano INT,
    IN p_num_edicao INT,
    IN p_preco DECIMAL (10,2), 
    IN p_id_livro INT,
    OUT p_id_edicao INT
)
BEGIN      
    INSERT INTO tb_edicoes (editora, ano, num_edicao, preco, id_livro)
    VALUES (p_editora, p_ano, p_num_edicao, p_preco, p_id_livro);
           
    SET p_id_edicao = LAST_INSERT_ID();
END//
DELIMITER ;

-- Copiando estrutura para procedure livraria.sp_cadastrar_livro
DELIMITER //
CREATE PROCEDURE `sp_cadastrar_livro`(
    IN p_isbn VARCHAR(50),
    IN p_nome VARCHAR(50),
    IN p_genero VARCHAR(50),
    OUT p_id_livro INT
)
BEGIN
    DECLARE v_id INT;

    -- Verifica se o livro já existe pelo ISBN
    SELECT id INTO v_id
    FROM tb_livro
    WHERE isbn = p_isbn
    LIMIT 1;

    -- Se não existir, insere
    IF v_id IS NULL THEN
        INSERT INTO tb_livro (isbn, nome, genero)
        VALUES (p_isbn, p_nome, p_genero);
        SET v_id = LAST_INSERT_ID();
    END IF;

    -- Retorna o ID do livro
    SET p_id_livro = v_id;
END//
DELIMITER ;

-- Copiando estrutura para tabela livraria.tb_autor
CREATE TABLE IF NOT EXISTS `tb_autor` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `nacao` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `uq_autor_nome_nacao` (`nome`,`nacao`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela livraria.tb_autor: ~10 rows (aproximadamente)
INSERT INTO `tb_autor` (`id`, `nome`, `nacao`) VALUES
	(5, 'Neil Gaiman', 'Britânico'),
	(6, 'Gabriel Garcia Marquez', 'Colombia'),
	(7, 'Stephen King', 'Estados Unidos'),
	(8, 'Owen King', 'Estados Unidos'),
	(9, 'J. R. R. Tolkien', 'Inglaterra'),
	(10, 'Frank Herbert', 'Estados Unidos'),
	(11, 'João Guimarães Rosa', 'Brasil'),
	(12, 'Nelson Motta ', 'Brasileiro'),
	(13, 'Ana Maria Machado', 'Brasil'),
	(14, 'Aldous Huxley', 'Inglaterra ');

-- Copiando estrutura para tabela livraria.tb_edicoes
CREATE TABLE IF NOT EXISTS `tb_edicoes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `editora` varchar(50) NOT NULL DEFAULT '',
  `ano` int(11) NOT NULL DEFAULT '0',
  `num_edicao` int(11) NOT NULL DEFAULT '0',
  `preco` decimal(10,2) NOT NULL DEFAULT '0.00',
  `id_livro` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_edicoes_livro` (`id_livro`),
  CONSTRAINT `fk_edicoes_livro` FOREIGN KEY (`id_livro`) REFERENCES `tb_livro` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela livraria.tb_edicoes: ~9 rows (aproximadamente)
INSERT INTO `tb_edicoes` (`id`, `editora`, `ano`, `num_edicao`, `preco`, `id_livro`) VALUES
	(2, 'Record', 2010, 10, 45.00, 3),
	(3, 'Record', 2015, 12, 55.00, 4),
	(4, 'Record', 2006, 7, 59.99, 7),
	(5, 'Companhia das Letras', 2022, 2, 53.99, 8),
	(6, 'MartinsFontes', 2002, 10, 14.99, 9),
	(8, 'Nova Fronteira', 2015, 1, 105.99, 11),
	(9, 'Objetiva ', 2007, 1, 49.00, 12),
	(10, 'Ática', 2008, 9, 29.00, 13),
	(11, 'Biblioteca Azul', 2014, 1, 145.00, 14);

-- Copiando estrutura para tabela livraria.tb_lista
CREATE TABLE IF NOT EXISTS `tb_lista` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_livro` int(11) DEFAULT NULL,
  `id_autor` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `uq_lista_livro_autor` (`id_livro`,`id_autor`),
  KEY `id_livro` (`id_livro`),
  KEY `id_autor` (`id_autor`),
  CONSTRAINT `tb_lista_ibfk_1` FOREIGN KEY (`id_livro`) REFERENCES `tb_livro` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tb_lista_ibfk_2` FOREIGN KEY (`id_autor`) REFERENCES `tb_autor` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela livraria.tb_lista: ~11 rows (aproximadamente)
INSERT INTO `tb_lista` (`id`, `id_livro`, `id_autor`) VALUES
	(4, 3, 5),
	(5, 4, 5),
	(6, 7, 6),
	(7, 8, 6),
	(8, 8, 7),
	(9, 8, 8),
	(10, 9, 9),
	(13, 11, 11),
	(14, 12, 12),
	(15, 13, 13),
	(16, 14, 14);

-- Copiando estrutura para tabela livraria.tb_livro
CREATE TABLE IF NOT EXISTS `tb_livro` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `isbn` varchar(50) NOT NULL DEFAULT '',
  `nome` varchar(50) NOT NULL DEFAULT '',
  `genero` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`),
  UNIQUE KEY `uq_livro_isbn` (`isbn`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela livraria.tb_livro: ~11 rows (aproximadamente)
INSERT INTO `tb_livro` (`id`, `isbn`, `nome`, `genero`) VALUES
	(3, '875214963', 'Sandman', ''),
	(4, '258966745', 'Coraline', 'Fantasia'),
	(5, '875203964', 'As Crônicas Saxônicas', 'Romance'),
	(6, '9788-3256-10', 'Guerra do Fim do Mundo', 'Romance'),
	(7, '9788321045', 'Crônica de uma morte anunciada ', 'Romance'),
	(8, '12587469', 'Belas Adormecidas', 'Terror'),
	(9, '5245627271', 'O Hobbit', 'Romance'),
	(11, '52879645', 'Grande Sertão: Vereda', 'Romance'),
	(12, ' 9788573028744', 'Vale Tudo', 'Biografia'),
	(13, '9788508147595', 'Menina Bonita do Laço de Fita', 'Infantil'),
	(14, '9788525056009', 'Admirável Mundo Novo', 'Ficção');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
