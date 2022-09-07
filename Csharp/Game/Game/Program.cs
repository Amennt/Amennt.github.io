using Game;

UserInputService userInputService = new UserInputService();
CurrentRound currentRound = new CurrentRound();
RandomNumber randomNumber = new RandomNumber();
RandomChoice randomChoice = new RandomChoice(randomNumber);
Comparisor comparisor = new Comparisor();
ShowWinner showWinner = new ShowWinner(comparisor, userInputService, randomChoice);

Game.Game game = new Game.Game(userInputService, currentRound, randomChoice, comparisor, showWinner);

game.Start();
