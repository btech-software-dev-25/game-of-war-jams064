using GameOfWar;

// Create an instance of the GameState class
// Shuffle CardDeck within your instance
// Deal 26 cards each from CardDeck to your instance's PlayerDeck and ComputerDeck


// Create a function with the signature: static bool PlayCards(GameState state, int playerCardIndex)
// The function should:
//     Pull the card at playerCardIndex from state.PlayerDeck
//     Pull the card at index 0 from state.ComputerDeck
//     Compare the two cards
//         If the player card is higher, the player gets both cards along with any in state.TableDeck
//         If the computer card is higher, the computer gets both cards along with any in state.TableDeck
//         If the player and computer cards are the same, both cards go into state.TableDeck
//     Check whether either state.PlayerDeck or state.ComputerDeck are empty
//         If the computer deck is empty, the player wins and state.Winner should be set to "Computer"
//         If the player deck is empty, the computer wins and state.Winner should be set to "Player"
//     return true


// Call Lib.RunGame(), passing two parameters: the state object you instantiated above and the name of your PlayCards function

namespace GameOfWar
{
    public class GameState
    {
        // Create a public Deck property called CardDeck


        // Create a public Deck property called PlayerDeck


        // Create a public Deck property called ComputerDeck


        // Create a public Deck property called TableDeck


        // Create a public string property called Winner


        // Create a public constructor that accepts no parameters. It should:
        //    Initialize Winner to be empty (not null)
        //    Initialize CardDeck to be a new, fresh deck of 52 cards
        //    Initialize PlayerDeck, ComputerDeck, and TableDeck to be empty Deck objects (no cards)
    }
}