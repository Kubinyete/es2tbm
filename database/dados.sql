-- FAVOR COLOCAR OS DELETES
DELETE FROM usuario;
DELETE FROM cliente;
DELETE FROM parametrizacao;

DELETE FROM produtoemitemcardapio;
DELETE FROM itempedido;
DELETE FROM pedido;

DELETE FROM comanda;
DELETE FROM mesa;
DELETE FROM estadopedido;
DELETE FROM itemcardapio;
DELETE FROM categoriacardapio;
DELETE FROM produto;
DELETE FROM categoriaproduto;
DELETE FROM unidademedida;
DELETE FROM marca;

DELETE FROM funcionario;
DELETE FROM cargo;
DELETE FROM pessoafisica;

DELETE FROM endereco;
DELETE FROM bairro;
DELETE FROM cidade;
DELETE FROM estado;

-- ENDEREÇOS...

INSERT INTO estado (est_uf, est_nome) VALUES (
    'SP', 
    'São Paulo'
);

INSERT INTO cidade (cid_nome, estado_est_uf) VALUES (
    'Presidente Bernardes', 
    'SP'
);

INSERT INTO cidade (cid_nome, estado_est_uf) VALUES (
    'Presidente Epitácio', 
    'SP'
);

INSERT INTO cidade (cid_nome, estado_est_uf) VALUES (
    'Presidente Prudente', 
    'SP'
);

INSERT INTO cidade (cid_nome, estado_est_uf) VALUES (
    'Presidente Venceslau', 
    'SP'
);

INSERT INTO cidade (cid_nome, estado_est_uf) VALUES (
    'Santo Anastácio', 
    'SP'
);

INSERT INTO bairro (bai_nome, cidade_cid_id) VALUES (
    'Bairro Batata Doce', 
    (SELECT cid_id FROM cidade WHERE cid_nome = 'Presidente Prudente')
);

INSERT INTO bairro (bai_nome, cidade_cid_id) VALUES (
    'Bairro Frango', 
    (SELECT cid_id FROM cidade WHERE cid_nome = 'Presidente Prudente')
);

INSERT INTO endereco (end_logradouro, end_numero, end_observacoes, bairro_bai_id) VALUES (
    'Av. Teste', 
    7777, 
    'Observação de teste!', 
    (SELECT bai_id FROM bairro WHERE bai_nome = 'Bairro Batata Doce')
);

-- PARAMETRIZACAO

INSERT INTO parametrizacao (par_nome_fantasia, par_razao_social, par_cnpj, par_ie, par_email, par_telefone, par_data_ativacao, endereco_end_id) VALUES (
    'Top Burguer', 
    'TOP BURGUER LTDA.', 
    '62246009000134', 
    225450934645, 
    'contato@topburguer.com.br', 
    '1832639999', 
    NOW(), 
    (SELECT end_id FROM endereco WHERE end_logradouro = 'Av. Teste')
);

-- CARGOS, PESSOAS, FUNCIONARIOS e USUARIOS

INSERT INTO cargo (car_nome, car_descricao, car_sal_base, car_nivel_permissao) VALUES (
    'Administrador',
    'Gerencia do Restaurante', 
    3000.00, 
    0
);

INSERT INTO cargo (car_nome, car_descricao, car_sal_base, car_nivel_permissao) VALUES (
    'Atendente',
    'Atende clientes', 
    1200.00, 
    1
);

INSERT INTO cargo (car_nome, car_descricao, car_sal_base, car_nivel_permissao) VALUES (
    'Garçom',
    'Entrega Comidas', 
    1200.00, 
    2
);

INSERT INTO cargo (car_nome, car_descricao, car_sal_base, car_nivel_permissao) VALUES (
    'Cozinheiro',
    'Prepara Comidas', 
    1900.00, 
    3
);

-- V2

INSERT INTO pessoafisica VALUES (
    '11111111111',
    NULL,
    'Administrador',
    NULL,
    (SELECT end_id FROM endereco WHERE end_logradouro = 'Av. Teste')
);

INSERT INTO funcionario VALUES (
    2000.00,
    'contato@topburguer.com.br',
    '1833333333',
    (SELECT car_id FROM cargo WHERE car_nome = 'Administrador'),
    '11111111111'
);

INSERT INTO usuario VALUES (
    'TBM',
    MD5('tbm'),
    1,
    '11111111111'
);

-- ADMINISTRADOR DO SISTEMA:
-- username=TBM
-- password=tbm

-- PRODUTOS E CARDAPIO

INSERT INTO marca VALUES (
    1,
    'Marca A'
);

INSERT INTO categoriaproduto VALUES (
    1,
    'Categoria A'
);

INSERT INTO unidademedida VALUES (
    1,
    'Sacos de 1Kg', 
    'Descrição...'
);

INSERT INTO produto VALUES (
    1,
    'Pão',
    2000,
    100,
    (SELECT mar_id FROM marca WHERE mar_nome = 'Marca A'),
    (SELECT cap_id FROM categoriaproduto WHERE cap_nome = 'Categoria A'),
    (SELECT uni_id FROM unidademedida WHERE uni_nome = 'Sacos de 1Kg')
);

INSERT INTO categoriacardapio VALUES (
    1,
    'Lanches'
);

INSERT INTO itemcardapio VALUES (
    1,
    'X-Só-Pão',
    25.00,
    'Um lanche blah, blah, blah...!',
    1,
    (SELECT cac_id FROM categoriacardapio WHERE cac_nome = 'Lanches')
);

INSERT INTO produtoemitemcardapio VALUES (
    2,
    0,
    (SELECT itc_id FROM itemcardapio WHERE itc_nome = 'X-Só-Pão'),
    (SELECT pro_id FROM produto WHERE pro_nome = 'Pão')
);

-- MESAS, COMANDAS E AFINS...

INSERT INTO mesa VALUES (
    1,
    'A primeira mesa do sistema!',
    4,
    0
);

INSERT INTO mesa VALUES (
    2,
    'A segunda mesa do sistema!',
    6,
    1
);

INSERT INTO comanda VALUES (
    1,
    'Comanda #1',
    'Observação...',
    50.00,
    '11111111111',
    NULL,
    1,
    NOW(),
    NULL
);

INSERT INTO estadopedido VALUES (
    1,
    'Solicitado'
);

INSERT INTO estadopedido VALUES (
    2,
    'Em preparo'
);

INSERT INTO estadopedido VALUES (
    3,
    'Finalizado'
);

INSERT INTO pedido VALUES (
    1,
    NOW(),
    50.00,
    (SELECT com_id FROM comanda WHERE com_apelido = 'Comanda #1'),
    (SELECT esp_id FROM estadopedido WHERE esp_nome = 'Solicitado')
);

INSERT INTO itempedido VALUES (
    (SELECT itc_id FROM itemcardapio WHERE itc_nome = 'X-Só-Pão'),
    (SELECT ped_id FROM pedido ORDER BY ped_data_efetuado ASC LIMIT 1),
    2,
    25.00,
    50.00
);
