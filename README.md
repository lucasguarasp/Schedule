# Desafio 01


Criar uma aplicação que simule uma agenda de compromissos de um consultório médico. <br />
Onde o(a) atendente poderá incluir, buscar, alterar e excluir os registros.<br />

Requisitos Funcionais
---
O sistema deve apresentar os seguintes campos: Nome do paciente, Data de nascimento, Data e hora inicial da consulta, Data e hora final da consulta, e um campo de Observações. <br />
O sistema não deve permitir o agendamento de duas ou mais consultas no mesmo range de datas. <br />

A data final não pode ser menor que a data inicial. <br />


Requisitos Técnicos
---
Linguagem C#. <br />
Banco de dados MS SQL Server. <br />
Criar testes unitários para a solução.<br />
Desenvolver a interface gráfica utilizando o framework Angular.<br />

---
Diferencial
Utilizar o .NET Core 

Para rodar o projeto
---
No Packege Manager Console, digitar: "Add-Migration Initialize" depois: "Update-Database"