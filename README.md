# BackEndApp

Este es un proyecto de **API REST** construido con **ASP.NET Core** y **Entity Framework Core**, utilizando **PostgreSQL** como base de datos. La API maneja las marcas de autos y proporciona operaciones CRUD para interactuar con la base de datos.

## Requisitos

- **.NET 8.0 o superior**: Necesario para ejecutar la aplicación.
- **Docker**: Para ejecutar la base de datos y la aplicación en contenedores.
- **Docker-Compose**: Para orquestar los contenedores.


## Instalación

### 1. Clona el Repositorio

Primero, clona el repositorio en tu máquina local:

```bash
git clone https://github.com/Sergio-bb/BackEndApp.git
cd BackEndApp

docker-compose build
docker-compose up -d
