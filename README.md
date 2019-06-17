Projeto ASP.NET Core + Entity Framework Core + Dapper, demonstrando o uso de ambos separadamente e em um cenário híbrido.

Estrutura
AspnetCore.EFCore_Dapper.Domain
Entidades de domínio e interfaces.
AspnetCore.EFCore_Dapper.Data
Entity Framework Context com aplicação dos mapeamentos das entidades e configurações para o uso de Migrations;

DbInitializer para a criação de dados de exemplo na inicialização do projeto;
Mapeamentos das entidades (Configuração do tipo e tamanho das colunas, chaves primárias, relacionamentos, etc) tanto do EF Core, quanto do Dapper;
Repositórios EF Core e Dapper para a manipulação de dados do banco de dados.
Configuração do mecanismo nativo de injeção de dependência do ASP.NET Core.

Controles
Login retornando um token de acesso
Cadastro simples de Reservas utilizando exclusivamente o EF Core;
Lista simples de Reservas utilizando exclusivamente o Dapper;
Cadastro simples de Filial, Sala utilizando o Dapper para consulta e o EF Core para inclusão, atualização e exclusão e listar.
