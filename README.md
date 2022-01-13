# DogsAPI
In this soulution I create a REST API using C# and MS SQL database.
Core : in this directory we have our entities.
Infrastructure : in this folder we have two directory, Data(for store our data), EntityConfiguration(for validation our entities), and class DependencyInjection for dependency injection.
Application : in this folder we have two directory, CQRS(for realisation mediatR pattern), Common(for our intefaces and mappings), and class DependencyInjection for dependency injection.
UI : in this folder we have our API with DogController :
- method Ping https://localhost:5001/api/ping ( return messege "Dogs house service. Version 1.0.1" )
- method dogs https://localhost:5001/api/dogs ( return list of dogs )
- method dog https://localhost:5001/api/dog ( create a dog )
Tests : in this folder we create our test.
