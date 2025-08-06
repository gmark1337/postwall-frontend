# postwall-frontend

## Contents 

- [Introduction](#introduction)
- [Features](#features)
- [Technologies used](#technologies-used)
- [Where can I see the actual website?](#website)
- [What I learned](#what-i-learned)

## Introduction 

This is a Blazor WebAssembly (WASM) application for browsing weekly supermarket flyers. \
It connects to a backend API **[supermarket_API](https://github.com/gmark1337/Supermarket_API)** to fetch and display flyer data from different supermarkets (e.g., Lidl, Spar).


## Features

- A welcoming page for the User 
- Listing the flyers
- Refreshing the flyers to see the latest flyers
- 3 large supermarket flyer's available(Spar, 0Lidl, Penny)
- English and Hungarian language provided by browser settings

## Technologies used

- **[Blazor WebAssembly](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)** – Client-side web UI framework by Microsoft.
- **[Blazor Bootstrap](https://www.blazorbootstrap.com/)** – Bootstrap components for Blazor.
- **[Blazored.Toast](https://github.com/Blazored/Toast)** – Toast notifications for success and error messages.
- **[HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient)** – To communicate with the backend API.
- **[Microsoft localizer]()** - To provide native language for users.
- **[Github actions](https://github.com/features/actions)** - CI/CD pipeline for my website.
>My intention was to use **Azure Devops**, but I deployed firstly via github and sticked to it (*lazy to change*)
- **[Microsoft Azure](https://azure.microsoft.com/hu-hu)** - Free server hosting service

- 

## Website

The website can be reached **[here](https://thankful-rock-027ccfc03.2.azurestaticapps.net)**. The performance might be poor, because of the free plan. 
Please take note that this is a home project.

## What I learned
  - Got introduced to the world of **JavaScript**, especially in **Node.js**.
  - How webscraping works.
  - How to debug in the browser console.
  - The json structure
  - A more solid understanding in .net technology
  - Learned how to make and handle **HTTP** requests in both frontend and backend.
  - Testing API endpoints with **[Postman](https://www.postman.com)**
  - Always check for package compatibility! :)
  - Got familiar with **Blazor Bootstrap** for building responsive UI components.
  - Encountered the developer fate: *"What can go wrong, will go wrong."*
  - To never give up on ideas
  - how cloud service works for both mongoDb database and azure
  - configure then deploy
