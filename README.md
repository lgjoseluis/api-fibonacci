# api-fibonacci
Fibonacci rest API: Devuelve el valor de la serie de Fibonacci dado un índice o posisción


# Sobre la implementación
Se utilizó lenguaje C#, ya que es el que actualmente estoy utilizando  

## Liberías/Herramientas de desarrollo

### IDE
- Visual Studio 2022

### Librerías
- Framework: .Net 6
- API versioning: Microsoft.AspNetCore.Mvc.Versioning
- Test: NUnit 

## Proceso de implementación
El proyecto es una Web API que usa el verbo GET para obtener el valor de la serie dada la posición.

Se creó un proyecto para simular una arquitectura en capas, en este caso, en la capa de aplñicación se encuentra la lógica de Fobonacci.

Se implemento un proyecto de pruebas utilizando NUnit.