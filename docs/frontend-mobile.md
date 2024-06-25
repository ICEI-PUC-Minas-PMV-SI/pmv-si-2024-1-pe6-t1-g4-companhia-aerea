# Front-end Móvel

A aplicação do sistema de reserva de voos da UaiFly visa proporcionar aos usuários uma experiência fácil e intuitiva para buscar, reservar e gerenciar voos. A aplicação foi feita utilizando flutter. Os objetivos principais do projeto são:

- Facilitar a busca por voos com base em diferentes critérios (data, destino, preço, etc.).
- Permitir a reserva de voos de maneira rápida e segura.
- Fornecer informações detalhadas sobre voos e reservas.
- Oferecer uma interface amigável e acessível em diversos dispositivos móveis.

## Tecnologias Utilizadas

- **Flutter**: Framework principal para desenvolvimento da aplicação mobile.
- **Dart**: Linguagem de programação utilizada no Flutter.
- **Firebase**: Para autenticação, banco de dados em tempo real e armazenamento.
- **REST API**: Para comunicação com os serviços de backend.
- **Provider**: Para gerenciamento de estado.
- **SQLite**: Para armazenamento de dados locais.
- **Git**: Para controle de versão.
- **CI/CD**: Para integração contínua e deploy contínuo.

## Arquitetura

A arquitetura da aplicação é baseada no padrão MVVM (Model-View-ViewModel), que promove a separação de responsabilidades e facilita a manutenção e escalabilidade do código.

- **Model**: Representa os dados e a lógica de negócio da aplicação.
- **View**: Componente responsável pela interface do usuário e exibição dos dados.
- **ViewModel**: Intermediário entre Model e View, gerencia os dados apresentados pela View e lida com a lógica de apresentação.

![](data:image/png;base64,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)

Arquitetura de uma aplicação que usa MVVM

## Modelagem da Aplicação

<img src="img/relacionamento-classes.png">


## Projeto da Interface

O projeto da interface móvel focará em proporcionar uma experiência visualmente agradável e funcional:

- **Design Visual**: Utilização de uma paleta de cores clara e moderna, tipografia legível e ícones intuitivos.
- **Layout das Páginas**: Estrutura clara com navegação simples entre as páginas principais (Busca de Voos, Detalhes do Voo, Reserva, Perfil do Usuário).
- **Interações do Usuário**: Animações suaves e transições fluidas entre telas.

### Wireframes

Os wireframes das páginas principais mostrarão a disposição dos elementos:

- **Tela de Login**: Tela inicial onde o usuário faz login ou se registra.
- **Tela de Voos disponíveis**: Lista de voos disponíveis.
- **Tela de Detalhes do Voo**: Informações detalhadas sobre o voo selecionado.
- **Página de Reserva**: Formulário para inserção de dados de reserva.
- **Página de Busca de reservas**: Informaçoes de uma reserva buscada por seu código ou origem.


### Design Visual

- **Paleta de Cores**: Azul para elementos de destaque, branco para fundo, cinza para texto secundário. Modo escuro disponível para conforto visual.
- **Tipografia**: Fonte roboto clara e moderna.
- **Ícones**: Ícones minimalistas e intuitivos para ações principais, seguindo o padrão por todas as telas.

### Layout Responsivo

A interface será adaptada para diferentes tamanhos de tela e dispositivos, garantindo uma experiência consistente em smartphones e tablets:

- **Grid Flexível**: Utilização de flexbox para adaptar os layouts.
- **Elementos Escaláveis**: Imagens e botões redimensionáveis conforme a tela

### Interações do Usuário

As interações incluirão:

- **Animações**: Animações suaves ao carregar dados e mudar de página.
- **Transições**: Transições fluidas entre telas para uma navegação agradável.
- **Feedback Visual**: Indicações visuais de ações realizadas, como cliques e carregamento e modais para confirmações.

## Fluxo de Dados

- **Autenticação**: O usuário interage com a aplicação para realizar login ou registro, a aplicação se comunica com o Firebase Authentication para validar o usuário.
- **Busca de Voos**: O usuário insere critérios de busca, a aplicação se comunica com a API de voos que consulta o banco de dados e retorna os resultados.
- **Detalhes e Reserva**: O usuário seleciona um voo, visualiza os detalhes e pode realizar uma reserva. A aplicação envia a requisição de reserva para a API, que atualiza o banco de dados e confirma a reserva.
- **Gestão de Reservas**: O usuário pode ver suas reservas ativas e histórico, a aplicação solicita esses dados da API, que consulta o banco de dados e retorna as informações.
- **Notificações**: O backend monitora eventos importantes e utiliza o Firebase Cloud Messaging para enviar notificações push para os dispositivos dos usuários.

## Requisitos Funcionais

- Busca de voos com base em critérios.
- Visualização de detalhes dos voos.
- Realização de reservas.
- Gestão de Reservas Ativas 
- Histórico de Reservas 
- Autenticação de usuários.
- Gerenciamento de perfil do usuário.
- Notificações de Atualizações e Promoções 

## Requisitos Não Funcionais

- **Desempenho**: Resposta rápida às interações do usuário.
- **Segurança**: Proteção dos dados do usuário.
- **Escalabilidade**: Suporte a um grande número de usuários.
- **Usabilidade**: Interface intuitiva e fácil de usar.

## Considerações de Segurança

- **Autenticação e Autorização**: Uso do Firebase Authentication para autenticação segura.
- **Proteção contra Ataques**: Implementação de medidas contra ataques comuns, como SQL Injection e Cross-Site Scripting.
- **Criptografia**: Dados sensíveis como senhas criptografados em trânsito e em repouso

### **Implantação**

- **Requisitos de Hardware e Software**:
  - Servidor de aplicação (Firebase ou similar)
  - Banco de dados (Firebase Firestore ou similar)
  - Configuração de CI/CD para deploy contínuo
- **Plataforma de Hospedagem**:
  - Firebase Hosting para front-end
  - Google Cloud ou AWS para backend e banco de dados
- **Configuração do Ambiente de Implantação**:
  - Instalação de dependências via flutter pub get
  - Configuração de variáveis de ambiente no Firebase
- **Deploy da Aplicação**:
  - Seguir instruções do Firebase CLI para deploy
  - Testes pós-deploy para garantir o funcionamento correto

### **Testes**

- **Estratégia de Teste**:
  - Testes Unitários
  - Testes de Integração
  - Testes de Carga
- **Casos de Teste**:
  - Cobertura de todos os requisitos funcionais e não funcionais
- **Implementação de Testes**:
  - Utilização do pacote flutter_test para testes unitários
  - Testes de integração com Firebase Emulator Suite
  - Testes de carga utilizando ferramentas como Apache JMeter
- **Ferramentas de Teste**:
  - Flutter Test
  - Firebase Test Lab
  - JMeter

# Referências

Inclua todas as referências (livros, artigos, sites, etc) utilizados no desenvolvimento do trabalho.