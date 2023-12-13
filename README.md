# ShoppingCart
It is a sample project based on the Monolithic architecture for a shopping cart.

# Design
This software is implemented based on AOP so that I can handle errors and logs in the pipeline using MediatR. However, this architecture is created solely for this software. To view the logs, both Seq and Prometheus.net are used for error detection, and alerts are not set. Easy caching is implemented to detect issues in the pipeline, and a test for fake data is set. The class is created and available for products from IDs one to seven.

- Architecture:
  - [AOP](https://en.wikipedia.org/wiki/Aspect-oriented_programming) (example: caching concern)
  - [Vertical Slice Architecture](https://jimmybogard.com/vertical-slice-architecture/)
  - [UseCase Driven Development](https://paulallies.medium.com/use-case-driven-development-e9d2804dd769)

**Tip**: according to some trade-offs,If it is intended for a larger system, MediatR itself may cause an increase in the system load.

# Implementation
  * ### Back-end:
    <details>
      <summary>click for details</summary>


      - .Net 8  
      - C#
      - ASP.NET Web API
      - [xUnit](https://xunit.net/) : testing framework
      -	[FluenAssertion](https://fluentassertions.com/) : write fluent assertions
      -	[MediatR](https://github.com/jbogard/MediatR) : simple mediator implementation
      -	[EasyCaching](https://github.com/dotnetcore/EasyCaching) : caching 
      - [Serilog](https://serilog.net/):loging
      - [Seq](https://docs.datalust.co/docs): Monitoring log
      - [Prometheus.net](https://github.com/prometheus-net/prometheus-net): add metrics for error
    </details>
