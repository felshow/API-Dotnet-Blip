🌟 API e Chatbot do Blip
Visão Geral
Este repositório contém uma API desenvolvida em .NET e um chatbot configurado na plataforma Blip. 
A API fornece informações sobre os repositórios mais antigos de um usuário do GitHub,
enquanto o chatbot utiliza essa API para responder a consultas e fornecer informações.
De forma resumida o chatbot consome a API via https://github-old-repos20241209165708.azurewebsites.net/api/GitHub/oldest-repos/takenet?count=6
que retorna os 5 repositorios mais antigos em C# da conta Takenet.

Estrutura do Repositório
API: Contém o código-fonte da API em .NET.

Chatbot: Contém as configurações e scripts utilizados no chatbot do Blip.

🛠 Configuração da API
Requisitos
.NET 8.0
Visual Studio ou qualquer editor de código de sua preferência
Conta no Azure (opcional para publicação)

🤖 Configuração do Chatbot no Blip
Requisitos
Conta no Blip

Acesso ao portal do Blip

Passos para Configuração
Criar um Bot no Blip:

Acesse o portal do Blip e crie um novo bot.
