# Gerenciador de Serviços do Windows

Aplicação desenvolvida para quem trabalha criando e modificando os serviços do windows ou precisa manipular os serviços do windows, facilitando por meio de uma interface a instalação e remoção dentre outras coisas que irei descrever cada função abaixo.

Obs: Para facilitar a vida e usabilidade do programa, não é necessário usar nenhuma linha de comando pela interface e muito menos abrir o gerenciador de serviços nativo do windows para verificar o status do serviço, iniciar e parar o mesmo. Você irá conseguir gerenciar todo processo por essa aplicação.

## Interface

![image](https://user-images.githubusercontent.com/74942532/129115888-041d7b4e-fe98-492e-8539-52f41435fc26.png)

## Quais são as funções?

Irei descrever as funções abaixo separando pelos boxes como no print acima, na aplicação temos o box do Projeto, Serviços e Processos em execução (Taskkill).

`?`: Todos os boxes na aplicação contém um botão de interrogação que explica superficialmente o que aquele box faz. 

### Projeto
#
Este box é responsável por instalar e desinstalar os serviços do windows localizando o executável compilado do serviço que deseja manipular. 

`...`: Botão que abre o explorador de arquivos do windows para localizar o executável compilado com os serviços. 

`Instalar`: Botão que executa a instalação dos serviços selecionados pelo executável encontrado com o botão do explorador de arquivos. 

`Desinstalar`: Botão que executa a desinstalação dos serviços selecionados pelo executável encontrado com o botão do explorador de arquivos. 

### Serviços
#
Este box é responsável por gerenciar os serviços listados (os nomes dos serviços listados são da propriedade "ServiceName" dos serviços), podendo: 

`Iniciar`: Este botão executa o comando para que os serviços selecionados executem. 

`Parar`: Este botão executa o comando para que os serviços selecionados parem. 

`Remover`: Este botão executa o comando que remove os serviços selecionados, este método é usado caso você desinstale o serviço pelo box do projeto e mesmo assim ele permanece listado (Problema recorrente do windows), sendo assim como se forçasse a parada e executasse a função de desinatalar automaticamente em seguida.

### Processos em execução - TaskKill
#
Este box é responsável por gerenciar os processos listados (os nomes dos processos listados são da propriedade "ProcessName" dos processos), podendo: 

`Parar`: Este botão executa o comando para que os processos selecionados parem. Porém este método é usado caso os serviços não parem de executar pelo box de serviços (Problema recorrente do windows), funcionando assim como um "TaskKill" para o processo com os serviços, geralmente o nome do processo é o nome do executável que você selecionou na hora da instalação, ele estará listado no box referido caso os serviços estejam em execução.

