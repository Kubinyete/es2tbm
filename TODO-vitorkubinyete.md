# TODO - Vitor Kubinyete
# Sistema TBM

- [X] Arrumar formulário de gerenciar endereços levantando Exception.
    Era um problema com a DALEndereco, devido a adição de uma linha vinda da branch mauricio.

- [X] Sinalizar os campos que são obrigatórios.
    Feito através da adição de uma * ao final do label de cada campo.

- [ ] Chamar a tela de parametrização após primeiro login do sistema, ao detectar a falta do objeto em banco.

- [ ] Usar dois parâmetros configurados na parametrização em algum local do sistema.
    - [ ] Utilizar a logo do sistema no login e tela inicial.
    - [ ] Utilizar o nome da empresa como título da tela inicial e em outros locais.

- [X] Permitir que clientes sejam desativados (utilizar um campo cli_ativado).
    - [X] Transformar o botão no formulário de cliente para que faça exclusão lógica.

- [X] Adicionar campos telefone e email aos clientes.

- [ ] Adicionar validações para dados críticos.
    - [X] Validar CPF corretamente através da StringUteis.validarCpf()
    - [ ] Validar CNPJ corretamente através da StringUteis.validarCnpj()
    - [ ] Validar RG corretamente através da StringUteis.validarRg()
    