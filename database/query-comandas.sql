SELECT 
com_id,
com_apelido,
com_observacoes,
com_valor_total,
com_data_abertura,
com_data_fechamento,

fun_salario_atual AS a_fun_salario_atual,
fun_email AS a_fun_email,
fun_telefone AS a_fun_telefone,

car_id AS a_car_id,
car_nome AS a_car_nome,
car_descricao AS a_car_descricao,
car_nivel_permissao AS a_car_nivel_permissao,
car_sal_base AS a_car_sal_base,

fpessoafisica.pes_cpf AS a_pes_cpf,
fpessoafisica.pes_rg AS a_pes_rg,
fpessoafisica.pes_nome AS a_pes_nome,
fpessoafisica.pes_data_nascimento AS a_pes_data_nascimento,
fpessoafisica.endereco_end_id AS a_endereco_end_id,

fendereco.end_id AS a_end_id,
fendereco.end_logradouro AS a_end_logradouro,
fendereco.end_numero AS a_end_numero,
fendereco.end_observacoes AS a_end_observacoes,

fbairro.bai_id AS a_bai_id,
fbairro.bai_nome AS a_bai_nome,

fcidade.cid_id AS a_cid_id,
fcidade.cid_nome AS a_cid_nome,

festado.est_uf AS a_est_uf,
festado.est_nome AS a_est_nome,

mes_id,
mes_observacoes,
mes_capacidade,
mes_disponivel,

cli_divida_acumulada AS b_cli_divida_acumulada,
cli_email AS b_cli_email,
cli_telefone AS b_cli_telefone,
cli_ativado AS b_cli_ativado,

cpessoafisica.pes_cpf AS b_pes_cpf,
cpessoafisica.pes_rg AS b_pes_rg,
cpessoafisica.pes_nome AS b_pes_nome,
cpessoafisica.pes_data_nascimento AS b_pes_data_nascimento,
cpessoafisica.endereco_end_id AS b_endereco_end_id,

cendereco.end_id AS b_end_id,
cendereco.end_logradouro AS b_end_logradouro,
cendereco.end_numero AS b_end_numero,
cendereco.end_observacoes AS b_end_observacoes,

cbairro.bai_id AS b_bai_id,
cbairro.bai_nome AS b_bai_nome,

ccidade.cid_id AS b_cid_id,
ccidade.cid_nome AS b_cid_nome,

cestado.est_uf AS b_est_uf,
cestado.est_nome AS b_est_nome

FROM comanda 
INNER JOIN mesa ON comanda.mesa_mes_id = mesa.mes_id
INNER JOIN funcionario ON comanda.funcionario_pessoafisica_pes_cpf = funcionario.pessoafisica_pes_cpf
INNER JOIN cargo ON funcionario.cargo_car_id = cargo.car_id
INNER JOIN pessoafisica AS fpessoafisica ON funcionario.pessoafisica_pes_cpf = fpessoafisica.pes_cpf
LEFT JOIN endereco AS fendereco ON fpessoafisica.endereco_end_id = fendereco.end_id
LEFT JOIN bairro AS fbairro ON fendereco.bairro_bai_id = fbairro.bai_id
LEFT JOIN cidade AS fcidade ON fbairro.cidade_cid_id = fcidade.cid_id
LEFT JOIN estado AS festado ON fcidade.estado_est_uf = festado.est_uf
LEFT JOIN cliente ON comanda.cliente_pessoafisica_pes_cpf = cliente.pessoafisica_pes_cpf
LEFT JOIN pessoafisica AS cpessoafisica ON cliente.pessoafisica_pes_cpf = cpessoafisica.pes_cpf
LEFT JOIN endereco AS cendereco ON cpessoafisica.endereco_end_id = cendereco.end_id
LEFT JOIN bairro AS cbairro ON cendereco.bairro_bai_id = cbairro.bai_id
LEFT JOIN cidade AS ccidade ON cbairro.cidade_cid_id = ccidade.cid_id
LEFT JOIN estado AS cestado ON ccidade.estado_est_uf = cestado.est_uf;
