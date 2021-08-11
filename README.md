# Gerenciador de Serviços do Windows

Aplicação desenvolvida para quem trabalha criando e modificando os serviços do windows ou precisa manipular os serviços do windows, facilitando por meio de uma interface a instalação e remoção dentre outras coisas que irei descrever cada função abaixo.

Obs: Para facilitar a vida e usabilidade do programa, não é necessário usar nenhuma linha de comando pela interface e muito menos abrir o gerenciador de serviços nativo do windows para verificar o status do serviço, iniciar e parar o mesmo. Você irá conseguir gerenciar todo processo por essa aplicação.

## Interface

![image](https://user-images.githubusercontent.com/74942532/129113891-38e416c1-157a-4c77-8ef4-32d2681581f3.png)

## Quais são as funções?

Irei descrever as funções abaixo separando pelos boxes como no print acima, na aplicação temos o box do Projeto, Serviços e Processos em execução (Taskkill).

`?`: Todos os boxes na aplicação contém um botão de interrogação que explica superficialmente o que aquele box faz. 

### Projeto

Este box é responsável por instalar e desinstalar os serviços do windows localizando o executável compilado do serviço que deseja manipular. 

`...`: Botão que abre o explorador de arquivos do windows para localizar o executável compilado com os serviços. 

`Instalar`: Botão que executa a instalação dos serviços selecionados pelo executável encontrado com o botão acima. 

`Desinstalar`: Botão que executa a desinstalação dos serviços selecionados pelo executável encontrado com o botão acima. 
