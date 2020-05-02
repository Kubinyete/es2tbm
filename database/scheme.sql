-- MySQL Script generated by MySQL Workbench
-- Tue Apr 21 11:51:29 2020
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema tbmdb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema tbmdb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `tbmdb` DEFAULT CHARACTER SET utf8 ;
USE `tbmdb` ;

-- -----------------------------------------------------
-- Table `tbmdb`.`cargo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`cargo` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`cargo` (
  `car_id` INT NOT NULL AUTO_INCREMENT,
  `car_nome` VARCHAR(32) NOT NULL,
  `car_descricao` VARCHAR(256) NULL,
  `car_nivel_permissao` TINYINT(8) NOT NULL DEFAULT 0,
  `car_sal_base` DOUBLE NOT NULL,
  PRIMARY KEY (`car_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`estado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`estado` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`estado` (
  `est_uf` CHAR(2) NOT NULL,
  `est_nome` VARCHAR(64) NOT NULL,
  PRIMARY KEY (`est_uf`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`cidade`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`cidade` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`cidade` (
  `cid_id` INT NOT NULL AUTO_INCREMENT,
  `cid_nome` VARCHAR(64) NOT NULL,
  `estado_est_uf` CHAR(2) NOT NULL,
  PRIMARY KEY (`cid_id`),
  CONSTRAINT `fk_cidade_estado1`
    FOREIGN KEY (`estado_est_uf`)
    REFERENCES `tbmdb`.`estado` (`est_uf`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`bairro`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`bairro` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`bairro` (
  `bai_id` INT NOT NULL AUTO_INCREMENT,
  `bai_nome` VARCHAR(64) NOT NULL,
  `cidade_cid_id` INT NOT NULL,
  PRIMARY KEY (`bai_id`),
  CONSTRAINT `fk_bairro_cidade1`
    FOREIGN KEY (`cidade_cid_id`)
    REFERENCES `tbmdb`.`cidade` (`cid_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`endereco`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`endereco` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`endereco` (
  `end_id` INT NOT NULL AUTO_INCREMENT,
  `end_logradouro` VARCHAR(75) NOT NULL,
  `end_numero` INT NOT NULL,
  `end_observacoes` VARCHAR(256) NULL,
  `bairro_bai_id` INT NOT NULL,
  PRIMARY KEY (`end_id`),
  CONSTRAINT `fk_endereco_bairro1`
    FOREIGN KEY (`bairro_bai_id`)
    REFERENCES `tbmdb`.`bairro` (`bai_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`pessoafisica`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`pessoafisica` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`pessoafisica` (
  `pes_cpf` CHAR(11) NOT NULL,
  `pes_rg` CHAR(9) NULL,
  `pes_nome` VARCHAR(75) NOT NULL,
  `pes_data_nascimento` DATE NULL,
  `endereco_end_id` INT NULL,
  PRIMARY KEY (`pes_cpf`),
  CONSTRAINT `fk_PessoaFisica_endereco1`
    FOREIGN KEY (`endereco_end_id`)
    REFERENCES `tbmdb`.`endereco` (`end_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`funcionario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`funcionario` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`funcionario` (
  `fun_salario_atual` DOUBLE NOT NULL,
  `cargo_car_id` INT NULL,
  `fun_email` VARCHAR(64) NULL,
  `fun_telefone` VARCHAR(16) NULL,
  `pessoafisica_pes_cpf` CHAR(11) NOT NULL,
  PRIMARY KEY (`pessoafisica_pes_cpf`),
  CONSTRAINT `fk_funcionario_Cargo`
    FOREIGN KEY (`cargo_car_id`)
    REFERENCES `tbmdb`.`cargo` (`car_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_funcionario_PessoaFisica1`
    FOREIGN KEY (`pessoafisica_pes_cpf`)
    REFERENCES `tbmdb`.`pessoafisica` (`pes_cpf`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`cliente`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`cliente` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`cliente` (
  `cli_divida_acumulada` DOUBLE NOT NULL DEFAULT 0,
  `cli_email` VARCHAR(64) NULL,
  `cli_telefone` VARCHAR(16) NULL,
  `cli_ativado` TINYINT(1) NOT NULL DEFAULT 1,
  `pessoafisica_pes_cpf` CHAR(11) NOT NULL,
  PRIMARY KEY (`pessoafisica_pes_cpf`),
  CONSTRAINT `fk_cliente_PessoaFisica1`
    FOREIGN KEY (`pessoafisica_pes_cpf`)
    REFERENCES `tbmdb`.`pessoafisica` (`pes_cpf`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`mesa`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`mesa` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`mesa` (
  `mes_id` INT NOT NULL,
  `mes_observacoes` VARCHAR(45) NULL,
  `mes_capacidade` INT NULL,
  `mes_disponivel` TINYINT NOT NULL,
  PRIMARY KEY (`mes_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`estadopedido`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`estadopedido` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`estadopedido` (
  `esp_id` INT NOT NULL AUTO_INCREMENT,
  `esp_nome` VARCHAR(64) NOT NULL,
  PRIMARY KEY (`esp_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`comanda`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`comanda` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`comanda` (
  `com_id` INT NOT NULL AUTO_INCREMENT,
  `com_apelido` VARCHAR(75) NULL,
  `com_observacoes` VARCHAR(256) NULL,
  `com_valor_total` DOUBLE NOT NULL,
  `funcionario_pessoafisica_pes_cpf` CHAR(11) NOT NULL,
  `cliente_pessoafisica_pes_cpf` CHAR(11) NULL,
  `mesa_mes_id` INT NOT NULL,
  PRIMARY KEY (`com_id`),
  CONSTRAINT `fk_comanda_funcionario1`
    FOREIGN KEY (`funcionario_pessoafisica_pes_cpf`)
    REFERENCES `tbmdb`.`funcionario` (`pessoafisica_pes_cpf`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_comanda_cliente1`
    FOREIGN KEY (`cliente_pessoafisica_pes_cpf`)
    REFERENCES `tbmdb`.`cliente` (`pessoafisica_pes_cpf`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_comanda_mesa1`
    FOREIGN KEY (`mesa_mes_id`)
    REFERENCES `tbmdb`.`mesa` (`mes_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`contareceber`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`contareceber` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`contareceber` (
  `con_id` INT NOT NULL AUTO_INCREMENT,
  `con_valor` DOUBLE NOT NULL,
  `con_valor_pago` DOUBLE NOT NULL,
  `con_data_recebimento` DATETIME NOT NULL,
  `con_data_vencimento` DATE NOT NULL,
  `comanda_com_id` INT NOT NULL,
  PRIMARY KEY (`con_id`),
  CONSTRAINT `fk_contareceber_comanda1`
    FOREIGN KEY (`comanda_com_id`)
    REFERENCES `tbmdb`.`comanda` (`com_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`pedido`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`pedido` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`pedido` (
  `ped_id` INT NOT NULL AUTO_INCREMENT,
  `ped_data_efetuado` DATETIME NOT NULL,
  `ped_valor_total` DOUBLE NOT NULL,
  `comanda_com_id` INT NOT NULL,
  `estadopedido_esp_id` INT NOT NULL,
  PRIMARY KEY (`ped_id`),
  CONSTRAINT `fk_pedido_comanda1`
    FOREIGN KEY (`comanda_com_id`)
    REFERENCES `tbmdb`.`comanda` (`com_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_pedido_estadopedido1`
    FOREIGN KEY (`estadopedido_esp_id`)
    REFERENCES `tbmdb`.`estadopedido` (`esp_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`categoriacardapio`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`categoriacardapio` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`categoriacardapio` (
  `cac_id` INT NOT NULL AUTO_INCREMENT,
  `cac_nome` VARCHAR(64) NOT NULL,
  PRIMARY KEY (`cac_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`itemcardapio`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`itemcardapio` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`itemcardapio` (
  `itc_id` INT NOT NULL AUTO_INCREMENT,
  `itc_nome` VARCHAR(75) NOT NULL,
  `itc_preco` DOUBLE NOT NULL,
  `itc_descricao` VARCHAR(256) NULL,
  `itc_disponivel` TINYINT NOT NULL,
  `categoriacardapio_cac_id` INT NOT NULL,
  PRIMARY KEY (`itc_id`),
  CONSTRAINT `fk_itemcardapio_categoriacardapio1`
    FOREIGN KEY (`categoriacardapio_cac_id`)
    REFERENCES `tbmdb`.`categoriacardapio` (`cac_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`caixa`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`caixa` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`caixa` (
  `cai_id` INT NOT NULL,
  `cai_valor_atual` DOUBLE NOT NULL,
  PRIMARY KEY (`cai_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`unidademedida`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`unidademedida` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`unidademedida` (
  `uni_id` INT NOT NULL AUTO_INCREMENT,
  `uni_nome` VARCHAR(64) NOT NULL,
  `uni_descricao` VARCHAR(256) NULL,
  PRIMARY KEY (`uni_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`marca`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`marca` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`marca` (
  `mar_id` INT NOT NULL AUTO_INCREMENT,
  `mar_nome` VARCHAR(64) NOT NULL,
  PRIMARY KEY (`mar_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`categoriaproduto`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`categoriaproduto` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`categoriaproduto` (
  `cap_id` INT NOT NULL AUTO_INCREMENT,
  `cap_nome` VARCHAR(64) NOT NULL,
  PRIMARY KEY (`cap_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`produto`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`produto` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`produto` (
  `pro_id` INT NOT NULL AUTO_INCREMENT,
  `pro_nome` VARCHAR(75) NOT NULL,
  `pro_quantidade` INT NOT NULL,
  `pro_quantidade_minima` INT NOT NULL,
  `unidademedida_uni_id` INT NOT NULL,
  `marca_mar_id` INT NULL,
  `categoriaproduto_cap_id` INT NULL,
  PRIMARY KEY (`pro_id`),
  CONSTRAINT `fk_produto_unidademedida1`
    FOREIGN KEY (`unidademedida_uni_id`)
    REFERENCES `tbmdb`.`unidademedida` (`uni_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_produto_marca1`
    FOREIGN KEY (`marca_mar_id`)
    REFERENCES `tbmdb`.`marca` (`mar_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_produto_categoriaproduto1`
    FOREIGN KEY (`categoriaproduto_cap_id`)
    REFERENCES `tbmdb`.`categoriaproduto` (`cap_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`produtoemitemcardapio`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`produtoemitemcardapio` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`produtoemitemcardapio` (
  `pic_quantidade` INT NOT NULL,
  `pic_efetuar_baixa` TINYINT NOT NULL,
  `itemcardapio_itc_id` INT NOT NULL,
  `produto_pro_id` INT NOT NULL,
  PRIMARY KEY (`itemcardapio_itc_id`, `produto_pro_id`),
  CONSTRAINT `fk_produtoemitemcardapio_itemcardapio1`
    FOREIGN KEY (`itemcardapio_itc_id`)
    REFERENCES `tbmdb`.`itemcardapio` (`itc_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_produtoemitemcardapio_produto1`
    FOREIGN KEY (`produto_pro_id`)
    REFERENCES `tbmdb`.`produto` (`pro_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`registrobaixa`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`registrobaixa` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`registrobaixa` (
  `reg_id` INT NOT NULL AUTO_INCREMENT,
  `reg_descricao` VARCHAR(256) NULL,
  `reg_quantidade` VARCHAR(45) NOT NULL,
  `produto_pro_id` INT NOT NULL,
  PRIMARY KEY (`reg_id`),
  CONSTRAINT `fk_registrobaixa_produto1`
    FOREIGN KEY (`produto_pro_id`)
    REFERENCES `tbmdb`.`produto` (`pro_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`tipodespesa`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`tipodespesa` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`tipodespesa` (
  `tdp_id` INT NOT NULL AUTO_INCREMENT,
  `tdp_nome` VARCHAR(64) NOT NULL,
  `tdp_descricao` VARCHAR(256) NULL,
  `tdp_acumulativa` TINYINT NOT NULL,
  PRIMARY KEY (`tdp_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`despesa`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`despesa` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`despesa` (
  `des_id` INT NOT NULL AUTO_INCREMENT,
  `des_nome` VARCHAR(64) NOT NULL,
  `des_descricao` VARCHAR(256) NULL,
  `des_data_inicio` DATE NOT NULL,
  `des_data_fim` DATE NOT NULL,
  `des_valor_total` DOUBLE NOT NULL,
  `des_valor_pago` DOUBLE NOT NULL,
  `tipodespesa_tdp_id` INT NOT NULL,
  PRIMARY KEY (`des_id`),
  CONSTRAINT `fk_despesa_tipodespesa1`
    FOREIGN KEY (`tipodespesa_tdp_id`)
    REFERENCES `tbmdb`.`tipodespesa` (`tdp_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`compra`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`compra` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`compra` (
  `com_id` INT NOT NULL AUTO_INCREMENT,
  `com_descricao` VARCHAR(64) NULL,
  `com_data_efetuada` DATETIME NOT NULL,
  `com_valor_total` DOUBLE NOT NULL,
  `despesa_des_id` INT NOT NULL,
  PRIMARY KEY (`com_id`),
  CONSTRAINT `fk_compra_despesa1`
    FOREIGN KEY (`despesa_des_id`)
    REFERENCES `tbmdb`.`despesa` (`des_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`itemcompra`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`itemcompra` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`itemcompra` (
  `ico_quantidade` INT NOT NULL,
  `ico_valor_unitario` DOUBLE NOT NULL,
  `ico_valor_subtotal` DOUBLE NOT NULL,
  `produto_pro_id` INT NOT NULL,
  `compra_com_id` INT NOT NULL,
  PRIMARY KEY (`produto_pro_id`, `compra_com_id`),
  CONSTRAINT `fk_itemcompra_produto1`
    FOREIGN KEY (`produto_pro_id`)
    REFERENCES `tbmdb`.`produto` (`pro_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_itemcompra_compra1`
    FOREIGN KEY (`compra_com_id`)
    REFERENCES `tbmdb`.`compra` (`com_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`contapagar`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`contapagar` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`contapagar` (
  `cpa_id` INT NOT NULL AUTO_INCREMENT,
  `cpa_data_vencimento` DATE NOT NULL,
  `cpa_valor` DOUBLE NOT NULL,
  `cpa_valor_pago` DOUBLE NOT NULL,
  `cpa_taxa_paga_adicional` DOUBLE NOT NULL,
  `cpa_data_pago` DATE NULL,
  `despesa_des_id` INT NOT NULL,
  PRIMARY KEY (`cpa_id`),
  CONSTRAINT `fk_contapagar_despesa1`
    FOREIGN KEY (`despesa_des_id`)
    REFERENCES `tbmdb`.`despesa` (`des_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`itempedido`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`itempedido` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`itempedido` (
  `itemcardapio_itc_id` INT NOT NULL,
  `pedido_ped_id` INT NOT NULL,
  `ipe_quantidade` INT NOT NULL,
  `ipe_valor_unitario` DOUBLE NOT NULL,
  `ipe_valor_subtotal` DOUBLE NOT NULL,
  PRIMARY KEY (`itemcardapio_itc_id`, `pedido_ped_id`),
  CONSTRAINT `fk_itempedido_itemcardapio1`
    FOREIGN KEY (`itemcardapio_itc_id`)
    REFERENCES `tbmdb`.`itemcardapio` (`itc_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_itempedido_pedido1`
    FOREIGN KEY (`pedido_ped_id`)
    REFERENCES `tbmdb`.`pedido` (`ped_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`parametrizacao`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`parametrizacao` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`parametrizacao` (
  `par_id` INT NOT NULL AUTO_INCREMENT,
  `par_nome_fantasia` VARCHAR(128) NOT NULL,
  `par_razao_social` VARCHAR(128) NOT NULL,
  `par_cnpj` CHAR(14) NOT NULL,
  `par_ie` BIGINT NOT NULL,
  `par_email` VARCHAR(64) NULL,
  `par_logomarca` MEDIUMBLOB NULL,
  `par_logomarca_path` VARCHAR(64) NULL,
  `par_telefone` VARCHAR(16) NULL,
  `par_data_ativacao` DATETIME NOT NULL,
  `endereco_end_id` INT NOT NULL,
  PRIMARY KEY (`par_id`),
  CONSTRAINT `fk_parametrizacao_endereco1`
    FOREIGN KEY (`endereco_end_id`)
    REFERENCES `tbmdb`.`endereco` (`end_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`fornecedor`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`fornecedor` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`fornecedor` (
  `for_cnpj` INT NOT NULL,
  `for_nome_fantasia` VARCHAR(128) NOT NULL,
  `for_razao_social` VARCHAR(128) NOT NULL,
  `for_ie` BIGINT NOT NULL,
  `for_email` VARCHAR(64) NULL,
  `for_telefone` VARCHAR(16) NULL,
  `endereco_end_id` INT NOT NULL,
  PRIMARY KEY (`for_cnpj`),
  CONSTRAINT `fk_fornecedor_endereco1`
    FOREIGN KEY (`endereco_end_id`)
    REFERENCES `tbmdb`.`endereco` (`end_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tbmdb`.`usuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tbmdb`.`usuario` ;

CREATE TABLE IF NOT EXISTS `tbmdb`.`usuario` (
  `usr_username` VARCHAR(32) NOT NULL,
  `usr_password` VARCHAR(32) NOT NULL,
  `usr_ativado` TINYINT(1) NOT NULL DEFAULT 1,
  `funcionario_pessoafisica_pes_cpf` CHAR(11) NOT NULL,
  PRIMARY KEY (`usr_username`),
  CONSTRAINT `fk_usuario_funcionario1`
    FOREIGN KEY (`funcionario_pessoafisica_pes_cpf`)
    REFERENCES `tbmdb`.`funcionario` (`pessoafisica_pes_cpf`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

---------------------------------------------------
--- PROCEDURES
-------- ------------ ------------- ---------------

-- Isso aqui é bizarro, mas fazer o que
DELIMITER //

-- BEGIN PROCEDURES -> Mauricio

DROP PROCEDURE IF EXISTS `login`//
CREATE PROCEDURE `login`(
  IN P_USR_USERNAME VARCHAR(32), 
    IN P_USR_PASSWORD VARCHAR(32), 
    OUT P_SUCESSFUL tinyint, 
    OUT P_MSG VARCHAR(32)
)
BEGIN 
    DECLARE usr_name varchar(32); 
    DECLARE usr_senha varchar(32);
    DECLARE usr_active tinyint(1);
    DECLARE p_password_md5 varchar(32);
    SELECT usr_username, usr_password,usr_ativado into usr_name,usr_senha,usr_active 
    from usuario where usr_username = P_USR_USERNAME;
    
    IF usr_name is null OR usr_active <> 1 then 
      SET P_SUCESSFUL := 0;
      set P_MSG := 'Usuario não encontrado';
  ELSE
    SET P_PASSWORD_MD5 = md5(P_USR_PASSWORD);
    IF usr_senha = P_PASSWORD_MD5 then 
      SET P_SUCESSFUL := 1;
            set P_MSG := 'OK';
        else 
            SET P_SUCESSFUL := 0;
            set P_MSG := 'Usuário Inválido';
        end if; 
    END IF;
END//

DROP PROCEDURE IF EXISTS `insere_usuario`//
CREATE PROCEDURE `insere_usuario`(
  in p_usr_username varchar(32), 
    in p_usr_password varchar(32), 
  in p_funcionario_pessoa_fisica_pes_cpf char(11), 
    out p_msg varchar(64), 
    out p_sucess tinyint(1)
)
BEGIN 
  IF(SELECT COUNT(*) FROM usuario where usuario.usr_username = p_usr_username) = 0 then
    IF(SELECT COUNT(*) FROM usuario where usuario.funcionario_pessoafisica_pes_cpf = p_funcionario_pessoa_fisica_pes_cpf) = 0 then
      insert into usuario(usr_username,usr_password,usr_ativado,funcionario_pessoafisica_pes_cpf) 
            values(p_usr_username,md5(p_usr_password),1,p_funcionario_pessoa_fisica_pes_cpf);
            set p_sucess := 1; 
            set p_msg := 'OK';
        ELSE
        set p_sucess := 0; 
        set p_msg := 'este funcionário já possui um usuário criado!';
        END IF;
    ELSE
    set p_sucess := 0; 
        set p_msg := 'Username já está em uso, insira outro';
  END IF;
END//

DROP PROCEDURE IF EXISTS `atualiza_funcionario`
CREATE PROCEDURE `atualiza_funcionario`(
  in p_pes_cpf char(11), 
    in p_pes_rg char(9), 
    in p_pes_nome varchar(75),
    in p_pes_data_nascimento date,
    in p_endereco_id int,
    in p_salario_atual double,
    in p_fun_email varchar(64), 
    in p_fun_telefone varchar(16),
    in p_cargo_id int,
    out p_sucess tinyint(1)
)
BEGIN 
  -- funcionário existe? 
  IF(select count(*) from funcionario where pessoafisica_pes_cpf = p_pes_cpf limit 1) = 1
    then 
        -- pessoafisica existe?
        if(select count(*) from pessoafisica where pes_cpf = p_pes_cpf limit 1) = 1
        then
      update pessoafisica set pes_rg= p_pes_rg, pes_nome = p_pes_nome,
            pes_data_nascimento = p_pes_data_nascimento,endereco_end_id = p_endereco_id
        WHERE pes_cpf = p_pes_cpf; 
            update funcionario set fun_salario_atual = p_salario_atual, fun_email = p_fun_email, 
            fun_telefone = fun_telefone,
            cargo_car_id = p_cargo_id WHERE pessoafisica_pes_cpf = p_pes_cpf;
            if p_cargo_id is null then 
        update usuario set usr_ativado = 0 
                where funcionario_pessoafisica_pes_cpf = p_pes_cpf;
      end if;
            COMMIT;
      set p_sucess := 1; 
    else
      set p_sucess := 0;
    end if;
  else
    set p_sucess := 0;
  end if;
END

-- END PROCEDURES -> Mauricio
-- BEGIN PROCEDURES -> Vitor

DROP PROCEDURE IF EXISTS `cadastrar_funcionario`//
CREATE PROCEDURE `cadastrar_funcionario`(IN proc_pes_cpf CHAR(11), IN proc_pes_rg CHAR(9), IN proc_pes_nome VARCHAR(75), IN proc_pes_data_nascimento DATE, IN proc_endereco_end_id INT, IN proc_fun_salario_atual DOUBLE, IN proc_cargo_car_id INT, OUT proc_result TINYINT(1))
BEGIN
  -- Funcionario não existe
  IF (SELECT COUNT(*) FROM funcionario WHERE pessoafisica_pes_cpf = proc_pes_cpf LIMIT 1) = 0 THEN
    -- Se não temos uma PessoaFisica ainda
    IF (SELECT COUNT(*) FROM pessoafisica WHERE pes_cpf = proc_pes_cpf LIMIT 1) = 0 THEN
      INSERT INTO pessoafisica VALUES (proc_pes_cpf, proc_pes_rg, proc_pes_nome, proc_pes_data_nascimento, proc_endereco_end_id);
    ELSE
      UPDATE pessoafisica SET pes_cpf = proc_pes_cpf, pes_rg = proc_pes_rg, pes_nome = proc_pes_nome, pes_data_nascimento = proc_pes_data_nascimento, endereco_end_id = proc_endereco_end_id WHERE pes_cpf = proc_pes_cpf;
    END IF;

    INSERT INTO funcionario VALUES (proc_fun_salario_atual, proc_cargo_car_id, proc_pes_cpf);
    SET proc_result := 1;
    COMMIT;
  ELSE
    SET proc_result := 0;
  END IF;
END//

DROP PROCEDURE IF EXISTS `cadastrar_cliente`//
CREATE PROCEDURE `cadastrar_cliente` (IN proc_pes_cpf CHAR(11), IN proc_pes_rg CHAR(9), IN proc_pes_nome VARCHAR(75), IN proc_pes_data_nascimento DATE, IN proc_endereco_end_id INT, IN proc_cli_email VARCHAR(64), IN proc_cli_telefone VARCHAR(16), OUT proc_result TINYINT(1))
BEGIN
  SET proc_result := 0;

  -- Se não temos uma PessoaFisica ainda
  IF (SELECT COUNT(*) FROM pessoafisica WHERE pes_cpf = proc_pes_cpf LIMIT 1) = 0 THEN
    -- Crie uma nova
    INSERT INTO pessoafisica VALUES (proc_pes_cpf, proc_pes_rg, proc_pes_nome, proc_pes_data_nascimento, proc_endereco_end_id);
  ELSE
    -- Atualize a existente
    UPDATE pessoafisica SET pes_cpf = proc_pes_cpf, pes_rg = proc_pes_rg, pes_nome = proc_pes_nome, pes_data_nascimento = proc_pes_data_nascimento, endereco_end_id = proc_endereco_end_id WHERE pes_cpf = proc_pes_cpf;
  END IF;

  -- Se nunca registramos esse cliente
  IF (SELECT COUNT(*) FROM cliente WHERE pessoafisica_pes_cpf = proc_pes_cpf LIMIT 1) = 0 THEN
    -- Insere um novo registro apontado pra essa pessoa
    INSERT INTO cliente (pessoafisica_pes_cpf, cli_email, cli_telefone) VALUES (proc_pes_cpf, proc_cli_email, proc_cli_telefone);
    SET proc_result := 1;  
  ELSE
    -- Existe um cliente já registrado (pode estar ativo ou não)
    -- Ele está desativado no momento?
    IF (SELECT cli_ativado FROM cliente WHERE pessoafisica_pes_cpf = proc_pes_cpf LIMIT 1) = 0 THEN
      UPDATE cliente SET cli_ativado = 1, cli_email = proc_cli_email, cli_telefone = proc_cli_telefone WHERE pessoafisica_pes_cpf = proc_pes_cpf;
      SET proc_result := 1;  
    END IF;
  END IF;
  COMMIT;
END//

DROP PROCEDURE IF EXISTS `atualizar_cliente`//
CREATE PROCEDURE `atualizar_cliente` (IN proc_pes_cpf CHAR(11), IN proc_pes_rg CHAR(9), IN proc_pes_nome VARCHAR(75), IN proc_pes_data_nascimento DATE, IN proc_endereco_end_id INT, IN proc_cli_ativado TINYINT(1), IN proc_cli_email VARCHAR(64), IN proc_cli_telefone VARCHAR(16), OUT proc_result TINYINT(1))
BEGIN
  SET proc_result := 0;
  -- Cliente existe
  IF (SELECT COUNT(*) FROM cliente WHERE pessoafisica_pes_cpf = proc_pes_cpf AND cli_ativado = 1 LIMIT 1) = 1 THEN
    UPDATE pessoafisica SET pes_cpf = proc_pes_cpf, pes_rg = proc_pes_rg, pes_nome = proc_pes_nome, pes_data_nascimento = proc_pes_data_nascimento, endereco_end_id = proc_endereco_end_id WHERE pes_cpf = proc_pes_cpf;
    UPDATE cliente SET cli_ativado = proc_cli_ativado, cli_email = proc_cli_email, cli_telefone = proc_cli_telefone WHERE pessoafisica_pes_cpf = proc_pes_cpf;
    SET proc_result := 1;
    COMMIT;
  END IF;
END//

-- END PROCEDURES -> Vitor

DELIMITER ;