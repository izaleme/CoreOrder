# CoreOrder — Modular Microservices Platform (.NET + Docker)

CoreOrder is a modular platform built with .NET, designed around a microservices architecture.
The project focuses on clean design, scalability, and real-world engineering practices commonly used in enterprise environments.

This repository serves as a professional reference for building distributed systems with .NET, Docker, and asynchronous communication patterns.

---

## Overview

CoreOrder demonstrates how to design and orchestrate independent services that communicate through well-defined APIs and events, while remaining loosely coupled and independently deployable.

The project emphasizes:

- Microservices-based architecture
- API Gateway as a unified entry point
- Asynchronous communication using messaging
- Independent databases per service
- Containerized infrastructure with Docker
- Clean Architecture and SOLID principles
- Domain-Driven Design (DDD – light approach)

---

## Architecture

The platform follows a gateway-based architecture with independent services and isolated data storage.

High-level architecture flow:

Gateway (YARP)  
→ AuthService (Authentication & Authorization)  
→ OrderService (Order processing and orchestration)  
→ Message Broker (RabbitMQ)  
→ Other services (future expansion)

Each microservice owns its own database and communicates with others either synchronously via HTTP or asynchronously via events.

---

## Technology Stack

- .NET 8 (ASP.NET Core Web API)
- Docker & Docker Compose
- PostgreSQL (per service database)
- RabbitMQ (asynchronous messaging)
- YARP (API Gateway)
- Swagger / OpenAPI
- Clean Architecture
- SOLID principles
- DDD (lightweight)

---

## Project Structure

~~~text
CoreOrder/
├── docs/               # Architecture and technical documentation
├── infrastructure/     # Database scripts and infrastructure configs
├── src/                # Application source code
│   ├── AuthService
│   ├── OrderService
│   ├── Gateway
│   └── Shared
├── docker-compose.yml
└── README.md
~~~

---

## Running the Project

### Prerequisites

- Docker Desktop
- .NET 8 SDK (for local development)

### Start the environment

From the project root:

```bash
docker compose up --build
```


This command will start:

- API Gateway
- AuthService
- OrderService
- PostgreSQL
- RabbitMQ

### Available endpoints

- API Gateway: http://localhost:5000  
- AuthService: http://localhost:5001  
- OrderService: http://localhost:5002  
- RabbitMQ Management UI: http://localhost:15672  
  - User: guest  
  - Password: guest  

---

## Goals of the Project

CoreOrder is designed to be:

- A professional portfolio project
- A reference implementation for modern .NET microservices
- A foundation for future extensions (new services, observability, CI/CD)
- A realistic system suitable for technical interviews

---

## Roadmap (Planned Improvements)

- Implement JWT authentication and authorization
- Introduce domain events and message-based workflows
- Add Inventory and Payment services
- Implement centralized logging and observability
- Add distributed tracing
- Introduce CI/CD pipeline
- Improve resiliency and fault tolerance

---

## License

This project is licensed under the MIT License and is intended for educational and professional portfolio use.
