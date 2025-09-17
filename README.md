# MauiHybrid con Web API

Este proyecto nace como una evolución de un **Maui Hybrid con SQLite** hacia una arquitectura más escalable y distribuida.  

## 📌 Cambios principales

- **Antes:**  
  - La aplicación **MAUI Hybrid** utilizaba una base de datos **SQLite local** para el almacenamiento.  

- **Ahora:**  
  - Se reemplazó SQLite por una **Web API** desarrollada en .NET.  
  - La **API está desplegada en [SOMEE](https://somee.com/)** junto con la base de datos.  
  - La aplicación **MAUI Hybrid** ahora **consume los datos a través de la API**, dejando de lado el almacenamiento local.  

## 🏗️ Estructura del repositorio

/MauiHybridConApi
│── MauiHybridWebApi → Proyecto Web API (publicado en SOMEE)
│── MauiHybridSqlite → Proyecto original basado en SQLite (referencia histórica)
│── MauiHybridConApi.sln → Solución que integra ambos proyectos


## 🚀 Objetivo

El objetivo de este cambio es permitir:  
- Un **modelo cliente-servidor**, donde los datos se gestionan centralmente.  
- **Acceso multiplataforma** sin depender de la base de datos local.  
- Mayor **escalabilidad y mantenibilidad** para el futuro desarrollo.  

## 🔗 Despliegue

- **Web API + Base de Datos:** alojados en **SOMEE**.  
- **Cliente MAUI Hybrid:** configurado para consumir los endpoints de la API.  

---
✍️ Este repositorio conserva la versión original con SQLite como referencia, pero la versión activa es la que integra la **Web API**.

<picture>
  <img alt="ITES LOGO" src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS97jZMwUyg5uSZ94md-e_Di8CuvaJ5ipm0WA&s">
</picture>
