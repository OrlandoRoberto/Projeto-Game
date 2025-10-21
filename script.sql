-- CRIANDO O BANCO DE DADOS
CREATE DATABASE projetoGames;
use projetoGames;



/*Criando as Tabelas do Banco de Dados*/ 
CREATE TABLE TBpedido (codPedido int primary key auto_increment,
    Valorjogo varchar(50),
    Valoropcionais varchar(50),
    Valorpagar varchar(50)
  
);
SELECT * FROM  TBpedido;