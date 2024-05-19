# Front-end Web


Nesta fase do projeto da Uaifly, foi estabelecido a arquitetura com APIs e Web Services, iniciando o desenvolvimento do front-end usando React, react-router e Material-UI. Isso permite criar uma interface de usuário intuitiva e atraente, alinhada aos requisitos já estabelecidos, proporcionando uma experiência de reserva de passagens aéreas fluida e confiável, mantendo a integração com o back-end já implementado.

## Tecnologias Utilizadas
<strong> - React: </strong>
Framework JavaScript para a construção da interface de usuário.

<strong> - React-Router: </strong>
Biblioteca para gerenciamento de rotas e navegação em aplicativos React.

<strong> - Material-UI: </strong>
Biblioteca de componentes React que implementa as diretrizes de design do Material Design, fornecendo componentes pré-projetados para uma interface de usuário consistente e atraente.

<strong> - Vite: </strong>
Construtor de aplicações JavaScript rápido e leve que utiliza ESM (ECMAScript Modules) para um desenvolvimento mais eficiente.

## Arquitetura

[Descrição da arquitetura das aplicação web, incluindo os componentes e suas interações.]

## Modelagem da Aplicação
[Descreva a modelagem da aplicação, incluindo a estrutura de dados, diagramas de classes ou entidades, e outras representações visuais relevantes.]

## Projeto da Interface Web
A interface web da aplicação da Uaifly foi projetada seguindo as diretrizes do Material Design, com uma paleta de cores vibrantes e uma tipografia legível. O layout é organizado para facilitar a navegação, com interações responsivas e animações sutis para indicar transições entre páginas. As opções de viagem são apresentadas de forma clara e interativa, considerando a acessibilidade por meio de design responsivo, suporte a leitores de tela e opções de contraste ajustável. Em resumo, a interface web oferece uma experiência completa e agradável para a reserva de passagens aéreas, atendendo às necessidades de diversos usuários.

### Wireframes
[Inclua os wireframes das páginas principais da interface, mostrando a disposição dos elementos na página.]

### Design Visual
[Descreva o estilo visual da interface, incluindo paleta de cores, tipografia, ícones e outros elementos gráficos.]

### Layout Responsivo
A adoção do Material UI no site da UaiFly é uma estratégia consolidada e testada no mercado para o desenvolvimento web responsivo. A combinação da estrutura adaptativa do Material UI com princípios de layout fluído e escalável garante uma experiência consistente em diversos dispositivos. A arquitetura de grade simplifica a distribuição flexível de conteúdo em diferentes resoluções de tela, enquanto as media queries permitem a personalização do estilo e comportamento dos componentes conforme a largura da tela. A modularidade dos componentes oferece uma abordagem escalável para criar layouts versáteis e adaptáveis, garantindo uma experiência de usuário satisfatória e intuitiva em todos os contextos de visualização.

### Interações do Usuário
[Descreva as interações do usuário na interface, como animações, transições entre páginas e outras interações.]

## Fluxo de Dados

[Diagrama ou descrição do fluxo de dados na aplicação.]

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que os usuários criem contas para acessar a aplicação. | ALTA | 
|RF-002| Permitir que o usuário reserve passagens aéreas   | ALTA |
|RF-003| Permitir que os usuários busquem voos com base em critérios como origem, destino, data e preferências.   | ALTA |
|RF-004| Permitir que os usuários visualizem e editem suas reservas existentes, incluindo alterações de voo e cancelamentos.   | ALTA |
|RF-005| Mostrar informações detalhadas sobre os voos disponíveis, incluindo horários, companhias aéreas, preços e escalas.   | ALTA |
|RF-006| Enviar notificações de confirmação de reserva para os usuários após a conclusão bem-sucedida da reserva.   | MÉDIA |
|RF-007| Enviar notificações de lembretes de viagens marcardas.   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| Garantir tempos de resposta rápidos durante a busca de voos e processo de reserva, mesmo em horários de pico, garantindo desempenho. | ALTA | 
|RNF-002| Proteger os dados pessoais e financeiros dos usuários com medidas de segurança robustas, como criptografita assegurando confidenciabilidade e integridade  |  ALTA | 
|RNF-003| Criar uma interface intuitiva e fácil de usar, com design responsivo para suportar diferentes dispositivos e tamanhos de tela facilitando usabilidade. |  ALTA | 
|RNF-004| Suportar múltiplos idiomas e moedas para atender a uma base diversificada de usuários |  MÉDIA | 
|RNF-005|Integrar-se com Apis de terceiros como flightradar, AviationStack e outras |  MÉDIA | 




## Considerações de Segurança

Para garantir os requisitos de confidenciabilidade e integridade da api, foi utilizado o JWT, que é um token criptografado de autenticação, com declarações sobre um usuário e uma chave, além dos recursos de autorização do framework asp.net core para restringir o acesso a determinadas funcionalidades da api e recursos anti-fraude.

## Testes

Para abranger todos os requisitos, tanto funcionais quanto não funcionais, foram conduzidos testes manuais utilizando a ferramenta Postman, seguindo os cenários de teste definidos no Qase. Estes cenários foram redigidos conforme o formato do Gherkin, garantindo uma abordagem estruturada e compreensível.

Os testes mapeados no Qase abrangem diferentes tipos, incluindo testes funcionais para validação das funcionalidades e testes de integração para verificar a interação entre os componentes do sistema. Essa abordagem abrangente visa assegurar a qualidade e a robustez do software em todos os aspectos importantes.

![qase](https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2024-1-pe6-t1-g4-companhia-aerea/assets/89879720/af9ab9e0-e237-4112-ae21-b910d2869789)
Print de tela da ferramenta Qase com mapeamento dos casos de testes

[CA-2024-04-23.pdf](https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2024-1-pe6-t1-g4-companhia-aerea/files/15082485/CA-2024-04-23.pdf) <br>
PDF com todos os testes realizados

# Referências

As seguintes referências foram utilizadas para elaboração da Api:
.https://medium.com/beelabacademy/domain-driven-design-vs-arquitetura-em-camadas-d01455698ec5
.https://medium.com/beelabacademy/implementando-na-pr%C3%A1tica-rest-api-com-conceitos-de-ddd-net-core-sql-no-docker-ioc-2cb3a2e7c649
.https://medium.com/beelabacademy/implementando-na-pr%C3%A1tica-rest-api-com-conceitos-de-ddd-net-2160291a44b7
