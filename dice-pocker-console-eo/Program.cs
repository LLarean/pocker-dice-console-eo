﻿// See https://aka.ms/new-console-template for more information

using PockerDice;

var players = new Player[2];
var random = new Random();

var dices = new Deck(random, 6).Dices();
var player = new Player(dices);
players[0] = player;

dices = new Deck(random, 6).Dices();
player = new Player(dices);
players[1] = player;


GameTable gameTable = new GameTable(players);


gameTable.Start();