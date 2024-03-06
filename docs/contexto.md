# Introdução

Este projeto aborda os desafios enfrentados pela companhia aérea Uaifly ao atender a uma ampla gama de perfis de passageiros. A meta é desenvolver uma aplicação que seja flexível, segura e eficiente, visando aprimorar a experiência de viagem oferecida. Os objetivos específicos incluem personalizar opções de viagem, implementar um sistema distribuído com integrações estratégicas, validar cupons de descontos e fortalecer a segurança da informação. Essas metas visam atender às expectativas diversificadas dos passageiros, oferecendo uma jornada de viagem personalizada e confiável. O público-alvo deste projeto são os clientes da Uaifly, buscando proporcionar uma experiência única e eficiente.

## Problema
A Uaifly enfrenta o desafio de atender a uma ampla diversidade de perfis de passageiros, que incluem estudantes, funcionários públicos, engenheiros de software e empresários. Cada perfil possui necessidades específicas, desde opções econômicas e flexibilidade de datas até eficiência, escalabilidade e integração tecnológica. 

Além disso, a aplicação deve ser escalável para lidar com picos de demanda, garantir a segurança dos dados dos passageiros e a confiabilidade do sistema, e eficientemente integrar-se com outros sistemas de check-in, gestão de voos e pagamento. 

Em resumo, o problema central consiste em desenvolver uma aplicação distribuída que seja flexível, segura e eficiente, proporcionando uma melhor experiência de viagem para os passageiros da Uaifly.


## Objetivos

### Objetivo Geral: 
Desenvolver um software abrangente e eficiente que atenda à diversidade de perfis de passageiros da Uaifly, visando aprimorar a experiência de viagem por meio da solução dos desafios apresentados, conforme detalhado no problema.

### Objetivos Específicos:
a. Personalização de Opções de Viagem:
Desenvolver funcionalidades específicas para cada perfil de passageiro (estudantes, funcionários públicos, engenheiros de software e empresários), proporcionando opções personalizadas que atendam às suas necessidades, tais como pacotes econômicos, flexibilidade de datas, conforto e integração tecnológica.

b. Implementação de Sistema Distribuído e Integrações:
Desenvolver uma arquitetura de sistema distribuído, incluindo integrações com serviços como Google Maps, previsão do tempo e outras APIs relevantes. Isso visa proporcionar informações em tempo real e otimizar a experiência do usuário durante o planejamento e a execução da viagem.

c. Validação de Cupons de Descontos e Integração com Parceiros:
Implementar um sistema de validação de cupons de descontos para hotéis, passeios e outros pacotes, promovendo ofertas personalizadas aos passageiros. Estabelecer integrações eficientes com parceiros para garantir a aplicação efetiva dos descontos e proporcionar benefícios adicionais aos clientes da Uaifly.
Estes objetivos específicos visam concentrar a prática investigativa na personalização das soluções oferecidas aos passageiros, na implementação de um sistema distribuído com integrações essenciais e na validação de cupons de descontos, contribuindo para uma experiência de viagem mais completa e alinhada com as necessidades diversificadas do público-alvo da Uaifly.


## Justificativa

A decisão de desenvolver uma aplicação para atender às diversas necessidades dos passageiros da Uaifly é motivada pela busca de uma experiência de viagem mais personalizada, eficiente e segura. Os objetivos específicos, como a personalização de opções de viagem, a implementação de um sistema distribuído com integrações estratégicas e a validação de cupons de descontos, são escolhas fundamentadas na diversidade do público-alvo. A ênfase na segurança da informação e confiabilidade visa construir a confiança dos passageiros, garantindo uma experiência de viagem alinhada com as expectativas variadas dos clientes.

## Público-Alvo

Através de pesquisas em literatura, benchmarking e em conhecimentos prévios adquiridos através de vivência na área, a equipe da UaiFly percebeu a amplitude do público-alvo que a empresa abrange. Este público varia desde jovens empreendedores até magnatas que valorizam a praticidade em suas viagens. Além disso, foram identificados outros perfis importantes, tais como universitários que estudam longe de suas cidades natais e desejam visitar suas famílias, assim como pais e mães que planejam viagens em família durante as férias. Ao longo deste documento, exploraremos detalhadamente cada um desses perfis, destacando suas necessidades e preferências específicas.

Para os jovens empreendedores, a UaiFly oferece flexibilidade e conveniência em suas viagens. Pois este públcio valoriza a eficiência e a praticidade na reserva de passagens, essenciais para sua vida dinâmica e em constante movimento.
Já para o perfil do empresário prático e objetivo, a UaiFly proporciona agilidade e eficiência no processo de reserva de passagens. Como tendem a serem viajantes frequentes, valorizam cada momento de sua jornada e precisam de uma companhia aérea que compreenda sua necessidade de rapidez e praticidade.

Os universitários que estão em busca de oportunidades acadêmicas, encontram na UaiFly opções econômicas e acessíveis para suas viagens, pois este grupo valoriza a flexibilidade de datas e tarifas competitivas, essenciais para viabilizar suas aspirações acadêmicas e explorar novos horizontes.

Para os pais e mães que desejam viajar com sua família, a UaiFly se destaca ao oferecer uma experiência especialmente projetada para atender às necessidades das crianças e facilitar a reserva de passagens para todos os membros da família. Este grupo de viajantes busca acima de tudo o conforto e a conveniência em suas jornadas, priorizando o bem-estar dos filhos e a praticidade durante todo o processo de viagem.

# Especificações do Projeto

## Personas

A fim de compreender melhor o perfil dos clientes ideais que nosso sistema almeja, foi elaborado o buyer persona de cada um das categorias encontradas no público-alvo, como podemos observar nas imagens abaixo.

<img src = "img/persona_001.png">

<img src = "img/persona_002.png">

<img src = "img/persona_003.png">

<img src = "img/persona_004.png">


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Ricardo Silva       | Reservar passagens nos mais diversos lugares  | Para viajar a trabalho como nomade digital                           |
|Bruno Mezenga       | Reservar passagens rapidamente                | Para não perder tempo com burocracia                                 |
|José Antônio        | Comprar passagens baratas                     | Poder ver minha família durante as férias da faculdade               |
|Maria Pereira       | Reservar passagens com segurança              | Viajar com meus filhos pequenos e ficar tranquila com sua segurança  |



## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicar uma técnica de priorização de requisitos e detalhar como a técnica foi aplicada.

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

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| O projeto deve integra apis próprias e de terceiros   |
|03| Deve ser desenvolvido uma aplicação web               |
|04| Deve ser desenvolvida uma aplicação mobile            |
|05| Deve-se fazer o deploy na nuvem           |

# Catálogo de Serviços

1. **Reserva de Voos:**
   - *Características:* Este serviço permite aos usuários pesquisar e reservar voos para diferentes destinos.
   - *Funcionalidades:*
     - Pesquisa de voos por destino, data e preferências de classe.
     - Visualização de opções de voos disponíveis com detalhes sobre horários, companhias aéreas e preços.
     - Reserva de assentos e conclusão do processo de compra.

2. **Gerenciamento de Reservas:**
   - *Características:* Este serviço permite aos usuários visualizar e gerenciar suas reservas de voos.
   - *Funcionalidades:*
     - Acesso ao histórico de reservas e detalhes dos voos agendados.
     - Possibilidade de fazer alterações nas reservas, como mudança de datas ou cancelamento.
     - Opções para adicionar serviços adicionais, como bagagem extra ou seleção de assentos preferenciais.

3. **Segurança de Dados:**
   - *Características:* Este serviço garante a proteção dos dados pessoais e financeiros dos usuários.
   - *Funcionalidades:*
     - Implementação de medidas robustas de segurança, como criptografia de dados.
     - Monitoramento contínuo para identificar e mitigar possíveis vulnerabilidades.
     - Conformidade com regulamentações de privacidade de dados, como GDPR e LGPD.

4. **Interface Usuário-Amigável:**
   - *Características:* Este serviço oferece uma interface intuitiva e fácil de usar para os usuários.
   - *Funcionalidades:*
     - Design responsivo para garantir uma experiência consistente em diferentes dispositivos e tamanhos de tela.
     - Navegação simplificada e organização lógica das informações.
     - Inclusão de recursos de acessibilidade para atender a diversos públicos.

# Gerenciamento de Projeto

De acordo com o PMBoK v6 as dez áreas que constituem os pilares para gerenciar projetos, e que caracterizam a multidisciplinaridade envolvida, são: Integração, Escopo, Cronograma (Tempo), Custos, Qualidade, Recursos, Comunicações, Riscos, Aquisições, Partes Interessadas. Para desenvolver projetos um profissional deve se preocupar em gerenciar todas essas dez áreas. Elas se complementam e se relacionam, de tal forma que não se deve apenas examinar uma área de forma estanque. É preciso considerar, por exemplo, que as áreas de Escopo, Cronograma e Custos estão muito relacionadas. Assim, se eu amplio o escopo de um projeto eu posso afetar seu cronograma e seus custos.

## Gerenciamento de Tempo

Com diagramas bem organizados que permitem gerenciar o tempo nos projetos, o gerente de projetos agenda e coordena tarefas dentro de um projeto para estimar o tempo necessário de conclusão.

![Diagrama de rede simplificado notação francesa (método francês)](img/02-diagrama-rede-simplificado.png)

O gráfico de Gantt ou diagrama de Gantt também é uma ferramenta visual utilizada para controlar e gerenciar o cronograma de atividades de um projeto. Com ele, é possível listar tudo que precisa ser feito para colocar o projeto em prática, dividir em atividades e estimar o tempo necessário para executá-las.

![Gráfico de Gantt](img/02-grafico-gantt.png)

## Gerenciamento de Equipe

O gerenciamento adequado de tarefas contribuirá para que o projeto alcance altos níveis de produtividade. Por isso, é fundamental que ocorra a gestão de tarefas e de pessoas, de modo que os times envolvidos no projeto possam ser facilmente gerenciados. 

![Simple Project Timeline](img/02-project-timeline.png)

# Arquitetura da Solução

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

![Arquitetura da Solução](img/02-mob-arch.png)

## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
