InnoCheffing
===============

## The aim of this project 

InnoCheffing is a web application designed to help me invent recipes and prepare dishes based on them.
The overall idea of the app is to make creating new recipes easy, interesting and fun. This is in some ways opposed to the traditional model of recipe sites consisting mainly of giant databases of recipes that other people have written.  
My site will focus more on innovation and improving the recipes we try. The site will also include a cooking assistance tool that will allow you to follow step-by-step the preparation of the recipe you have previously invented.

I am writing this program myself in my spare time. I started this project at the beginning of February 2024 and am still building it.  
The aim of this project is to achieve a functional, stable and secure version of the site so that it can be deployed online using a platform such as Azure or Google Cloud.  

## Guidelines

I'd like to follow three guidelines during the creation of this project: 

- Concerning the code: write simple, clear code.
- Concerning the design: make it as intuitive and minimalist as possible.
- Concerning security: make sure the application is totally safe to use and does not endanger user data.

## Architecture

This section presents the back-end server, consisting mainly of an ASP.NET API.  
I haven't separated this project into many different layers because it doesn't really have a business logic.
So I adopted a simpler architecture. The API communicates with the "Core", which is a library of classes that in turn communicates with the database located in PostgreSQL server.  

The database is created via Entity Framework from C# code. I quickly wrote a database seed to make my application data more "populated".  
This database is also accessed via Entity Framework.  

## Tools and tech stack

I plan to build the front end with a Angular project using Tailwind for styles.
My back end is essentially an ASP.NET API and a PostgreSQL database server.

## Early stages

This project is still in its early stages. Details will come later as the application is built.