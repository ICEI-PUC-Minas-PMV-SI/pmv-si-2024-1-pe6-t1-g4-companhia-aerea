# APIs e Web Services

A Uaifly está desenvolvendo uma aplicação web para reservas de passagens aéreas, visando atender um público variado. Para garantir uma experiência robusta, a empresa adota uma arquitetura com ampla utilização de APIs e Web Services. Esses recursos são cruciais para integrar sistemas, realizar operações como pesquisa e reserva de voos, e garantir uma interação eficiente entre os módulos da aplicação. Com essa abordagem, a Uaifly busca oferecer uma plataforma escalável, segura e altamente integrada para seus clientes, independentemente de suas necessidades de viagem.

## Objetivos da API

#### Customers API: 
<strong> Objetivo: </strong> Fornecer funcionalidades para manipulação do cadastro de clientes. <br>
Destinada tanto para uso interno da empresa quanto para clientes externos, como aplicativos de parceiros ou sistemas de terceiros. <br>
<strong> Recursos Esperados: </strong> <br>
* Exclusão de clientes: Permitir a exclusão de registros de clientes do sistema. <br>
* Inclusão de clientes: Possibilitar a inclusão de novos clientes no banco de dados. <br>
* Atualização de cadastros: Permitir a atualização de informações dos clientes, como endereço, telefone, e-mail, etc.

#### Login API:
<strong> Objetivo: </strong> Realizar o processo de autenticação e autorização de usuários. <br>
Destinada a todos os usuários do sistema, sejam clientes externos ou internos da empresa. <br>
<strong> Recursos Esperados: </strong> 
* Autenticação de usuários: Verificar as credenciais de login (usuário/senha) e gerar um token de acesso válido. <br>
* Autorização de acesso: Controlar o acesso a recursos específicos com base nas permissões do usuário.

#### Users API: 
<strong> Objetivo: </strong> Gerenciar o cadastro e as informações dos usuários do sistema. <br>
Destinada a usuários internos da empresa, como administradores e equipes de suporte. <br>
<strong> Recursos Esperados: </strong> 
* Cadastro de usuários: Permitir a criação de novos usuários no sistema, especificando seus dados básicos, funções e permissões. <br>
* Gerenciamento de usuários: Oferecer funcionalidades para atualização, exclusão e listagem de usuários cadastrados.

## Arquitetura

[Descrição da arquitetura das APIs, incluindo os componentes e suas interações.]

## Modelagem da Aplicação
[Descreva a modelagem da aplicação, incluindo a estrutura de dados, diagramas de classes ou entidades, e outras representações visuais relevantes.]


## Fluxo de Dados

[Diagrama ou descrição do fluxo de dados na aplicação.]

## Requisitos Funcionais

[Liste os principais requisitos funcionais da aplicação.]

## Requisitos Não Funcionais

[Liste os principais requisitos não funcionais da aplicação, como desempenho, segurança, escalabilidade, etc.]

## Tecnologias Utilizadas

Existem muitas tecnologias diferentes que podem ser usadas para desenvolver APIs Web. A tecnologia certa para o seu projeto dependerá dos seus objetivos, dos seus clientes e dos recursos que a API deve fornecer.

[Lista das tecnologias principais que serão utilizadas no projeto.]

## API Endpoints

[Liste os principais endpoints da API, incluindo as operações disponíveis, os parâmetros esperados e as respostas retornadas.]

### Endpoint 1
- Método: GET
- URL: /endpoint1
- Parâmetros:
  - param1: [descrição]
- Resposta:
  - Sucesso (200 OK)
    ```
    {
      "message": "Success",
      "data": {
        ...
      }
    }
    ```
  - Erro (4XX, 5XX)
    ```
    {
      "message": "Error",
      "error": {
        ...
      }
    }
    ```


## Considerações de Segurança

[Discuta as considerações de segurança relevantes para a aplicação distribuída, como autenticação, autorização, proteção contra ataques, etc.]

## Implantação

[Instruções para implantar a aplicação distribuída em um ambiente de produção.]

1. Defina os requisitos de hardware e software necessários para implantar a aplicação em um ambiente de produção.
2. Escolha uma plataforma de hospedagem adequada, como um provedor de nuvem ou um servidor dedicado.
3. Configure o ambiente de implantação, incluindo a instalação de dependências e configuração de variáveis de ambiente.
4. Faça o deploy da aplicação no ambiente escolhido, seguindo as instruções específicas da plataforma de hospedagem.
5. Realize testes para garantir que a aplicação esteja funcionando corretamente no ambiente de produção.

## Testes

Para abranger todos os requisitos, tanto funcionais quanto não funcionais, foram conduzidos testes manuais utilizando a ferramenta Postman, seguindo os cenários de teste definidos no Qase. Estes cenários foram redigidos conforme o formato do Gherkin, garantindo uma abordagem estruturada e compreensível.

Os testes mapeados no Qase abrangem diferentes tipos, incluindo testes funcionais para validação das funcionalidades e testes de integração para verificar a interação entre os componentes do sistema. Essa abordagem abrangente visa assegurar a qualidade e a robustez do software em todos os aspectos importantes.



![qase](https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2024-1-pe6-t1-g4-companhia-aerea/assets/89879720/af9ab9e0-e237-4112-ae21-b910d2869789)
Print de tela da ferramenta Qase com mapeamento dos casos de testes:


[CA-2024-04-23.pdf](https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2024-1-pe6-t1-g4-companhia-aerea/files/15082485/CA-2024-04-23.pdf) <br>
PDF com todos os testes realizados

# Referências

Inclua todas as referências (livros, artigos, sites, etc) utilizados no desenvolvimento do trabalho.
