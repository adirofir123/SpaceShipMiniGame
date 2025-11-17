## itch.io link : https://imrfatty.itch.io/spaceshipminigame

# Unity week 2: Formal elements

A project with step-by-step scenes illustrating some of the formal elements of game development in Unity, including: 
* Prefabs for instantiating new objects;
* Colliders for triggering outcomes of actions;
* Coroutines for setting time-based rules.

Text explanations are available 
[here](https://github.com/gamedev-at-ariel/gamedev-5782) in folder 04.

## Cloning
To clone the project, you may need to install git lfs first (if it is not already installed):

    git lfs install 

To clone faster, you can limit the depth to 1 like this:

    git clone --depth=1 https://github.com/<repository-name>.git

When you first open this project, you may not see the text in the score field.
This is because `TextMeshPro` is not in the project.
The Unity Editor should hopefully prompt you to import TextMeshPro;
once you do this, re-open the scenes, and you should be able to see the texts.



## Credits

Programming:
* Maoz Grossman
* Erel Segal-Halevi

Online courses:
* [The Ultimate Guide to Game Development with Unity 2019](https://www.udemy.com/the-ultimate-guide-to-game-development-with-unity/), by Jonathan Weinberger

Graphics:
* [Matt Whitehead](https://ccsearch.creativecommons.org/photos/7fd4a37b-8d1a-4d4c-80a2-4ca4a3839941)
* [Kenney's space kit](https://kenney.nl/assets/space-kit)
* [Ductman's 2D Animated Spacehips](https://assetstore.unity.com/packages/2d/characters/2d-animated-spaceships-96852)
* [Franc from the Noun Project](https://commons.wikimedia.org/w/index.php?curid=64661575)
* [Greek-arrow-animated.gif by Andrikkos is licensed under CC BY-SA 3.0](https://search.creativecommons.org/photos/2db102af-80d0-4ec8-9171-1ac77d2565ce)


# 🚀 SpaceShipMiniGame

Unity Week 3 Assignment – A 2D space mini-game where you pilot a spaceship, destroy satellites under time pressure, and manage limited ammo and health across two stages.

---

## 🎮 Game Overview

You control a spaceship in outer space with a simple mission:

**Destroy a required number of satellites within one minute per stage**,  
while managing:

- Limited health  
- Limited ammo  
- Time pressure  
- Two consecutive stages  

During gameplay, **green health orbs** spawn randomly and restore health when collected.

To complete a stage, you MUST destroy all required satellites before the timer reaches zero.

Failing to meet the target, running out of health, or running out of ammo results in game over.

---

## 🗂 Game Stages

### 🔹 Stage 1
- Target: **13 satellites**
- Time limit: **60 seconds**
- Ammo: Limited  
- Health: Limited  

### 🔹 Stage 2
- Target: **18 satellites**
- Time limit: **60 seconds**
- Ammo: **Does not replenish** from Stage 1  
- Health: Continues from previous state (restorable only via green orbs)

---

## 🎯 Win Conditions
- Destroy all required satellites within the 60-second timer.

## 💀 Loss Conditions
- Timer reaches zero  
- Health reaches zero  
- Ammo reaches zero before clearing the required target

---

## 🕹 Controls

| Action | Key |
|--------|-----|
| Shoot  | **SPACEBAR** |
| Move   | **Arrow Keys** |

---

## 📊 User Interface (UI)

- **Right-center of screen:** Player health  
- **Left-center of screen:** Ammo count (does NOT refill until the next stage)  
- **Top-center:** 60-second timer  
- **Green orbs:** Restore player health when collected  

---

## ▶️ How to Run the Game

1. Clone the repository:
   ```bash
   git clone https://github.com/adirrofir123/SpaceShipMiniGame.git
