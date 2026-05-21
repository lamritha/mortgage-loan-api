# Mortgage Loan Management API

A backend REST API built with ASP.NET Core for processing 
mortgage loan applications, automating approval decisions, 
and generating amortization schedules.

> 🚧 Status: In Progress

---

## Features (In Development)

- Applicant registration and management
- Mortgage application submission
- Automated approval/rejection based on credit score, 
  income, and down payment rules
- Monthly payment calculation using amortization formula
- Full repayment schedule generation per approved loan

---

## Tech Stack

- C# / .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- Swagger UI for API documentation

---

## Project Structure

```bash
BankingAPI/
├── Controllers/
├── Services/
├── Repositories/
├── Models/
├── DTOs/
└── Data/
```

---

## Business Rules

- Minimum credit score: 650
- Minimum down payment: 10% of property value
- Maximum loan amount: 4x annual income
- Interest rates assigned by credit score tier

---

## Endpoints (Planned)

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | /api/applicants | Register applicant |
| POST | /api/applications | Submit mortgage application |
| GET | /api/applications/{id} | Get application status |
| PUT | /api/applications/{id}/process | Process approval |
| GET | /api/applications/{id}/loan-details | Get loan details |
| GET | /api/applications/{id}/repayment-schedule | Get amortization table |

---

## Getting Started

*Setup instructions will be added upon completion*

---

## Author

Amritha Lingeswaran
