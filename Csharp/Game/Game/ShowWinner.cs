using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public interface IShowWinner
    {
        void GetShowWinner();
    }
    public class ShowWinner : IShowWinner
    {
        private readonly IComparisor _comparisor;
        private readonly IUserInputService _userInputService;
        private readonly IRandomChoice _randomChoice;
        public ShowWinner(IComparisor comparisor, IUserInputService userInputService, IRandomChoice randomChoice)
        {
            _comparisor = comparisor;
            _userInputService = userInputService;
            _randomChoice = randomChoice;
        }
        public void GetShowWinner()
        {
            string userChoice = _userInputService.GetUserInput();
            string computerChoice = _randomChoice.GetRandomChoice();

            Winner player = _comparisor.FindWinner(computerChoice, userChoice);
            
            if(player == Winner.Computer)
            {
                Console.WriteLine("Computer win! He's going to start a game.");
            }
            if (player == Winner.User)
            {
                Console.WriteLine("You win! You're going to start a game.");
            }
            if (player == Winner.Noone)
            {
                Console.WriteLine("Noone won! Let's start one more time.");
            }
        }
    }
}
