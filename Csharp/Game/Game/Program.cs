using Game;
using System;

Game.Game game = new Game.Game(new UserInputService(), new CurrentRound(), new RandomChoice(new RandomNumber()), new Comparisor(), new ShowWinner(new Comparisor()));

game.Start();
