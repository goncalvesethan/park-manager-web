# 📘 Documentation fonctionnelle - Gestion de parc (Web)

## 🧩 Présentation générale

**Gestion de parc (web)** est une application web développée avec **Blazor** qui permet de **gérer un parc informatique de manière centralisée**.  
L'application est construite selon une architecture **frontend (Blazor)** qui communique avec une **API distante (.NET également)**, responsable de la gestion des données.

Elle s’adresse principalement à des **utilisateurs ayant des droits d’accès spécifiques**, pour suivre, consulter et gérer des équipements informatiques répartis dans des **salles** et des **parcs**.

---

## 🔐 Système d’authentification et d’autorisation

- À l'ouverture de l'application, l’utilisateur est redirigé automatiquement vers la **page de connexion** (`/login`).
- Après validation des identifiants, un **token JWT** est généré par l’API, puis **stocké localement** (en mémoire ou dans le local storage).
- Ce token est utilisé à chaque appel API pour **authentifier les requêtes**.
- Les **pages protégées** sont inaccessibles tant que l’utilisateur n’est pas connecté.
- Une fois connecté, l’utilisateur est redirigé vers le **tableau de bord** (`/`).

---

## 🔁 Communication avec l'API

- Toute la gestion des données (**création, lecture, modification, suppression**) passe par une **API REST distante**.
- Chaque ressource (Device, Room, Park, Incident) a une **partie dédiée** qui centralise la logique de communication avec l’API.

---

## 📁 Ressources principales gérées

L’application repose sur **4 ressources principales** :


### 1. 🏞️ Parcs (Parks)
- Représentent des **regroupements logiques ou physiques** de salles (ex: un bâtiment, une école, un service).
- Permettent d’**organiser la gestion de manière plus macro**.

### 2. 🏢 Salles (Rooms)
- Représentent des **espaces physiques** où sont placés les équipements.
- **Associées à un parc**.
- Les **équipements (devices)** y sont localisés.

### 3. 💻 Postes (Devices)
- Équipements informatiques individuels (**PC, portables, tablettes…**).
- **Attribués à une salle**.
- Peuvent contenir des informations comme la **référence**, l’**état**, etc.

### 4. 🚨 Incidents
- Représentent des **problèmes techniques signalés** sur un poste.
- Permettent un **suivi des réparations ou interventions**.
- **Associés à un poste** précis.

---

## 📊 Tableau de bord

Le **tableau de bord** est la **première page visible** après connexion.

Il offre une **vue synthétique de l’état du parc informatique** avec :
- Le **nombre total** de parcs, salles, équipements et incidents.
- Des **statistiques visuelles** (graphiques, compteurs…).
- Une **aide rapide à la décision** pour voir où se concentrent les problèmes ou les besoins.

---

## 🎯 Objectif global de l'application

L'objectif de l’application **Gestion de parc** est de :
- **Faciliter la gestion** d’un parc informatique distribué dans plusieurs lieux.
- **Suivre les incidents** et interventions.
- Fournir une **interface moderne, fluide et sécurisée** pour l’équipe de gestion technique.
