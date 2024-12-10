Visão Geral
Este repositório contém uma API desenvolvida em .NET e um chatbot configurado na plataforma Blip. A API fornece informações sobre os repositórios mais antigos de um usuário do GitHub, enquanto o chatbot do Blip utiliza essa API para responder a consultas e fornecer informações aos usuários.

Estrutura do Repositório
API: Contém o código-fonte da API em .NET.

Chatbot: Contém as configurações e scripts utilizados no chatbot do Blip.

Configuração da API
Requisitos
.NET 8.0

Visual Studio ou qualquer editor de código de sua preferência

Conta no Azure (opcional para publicação)

assos para Configuração
Clone o Repositório:

sh
git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio/API
Restaurar Dependências:

sh
dotnet restore
Compilar o Projeto:

sh
dotnet build
Executar a API:

sh
dotnet run
A API estará disponível em http://localhost:5000.

Publicação no Azure
Criar um App Service no Azure.

Publicar a API:

sh
dotnet publish -c Release -o bin/release/net8.0
Utilizar o Visual Studio para Publicar no Azure.

Configuração do Chatbot no Blip
Requisitos
Conta no Blip

Acesso ao portal do Blip

Passos para Configuração
Criar um Bot no Blip:

Acesse o portal do Blip e crie um novo bot.
