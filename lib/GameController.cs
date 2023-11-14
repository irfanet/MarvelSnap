namespace lib;

using System.ComponentModel;
using lib.cards;
using lib.location;
using lib.players;

public delegate void TurnNotification();
public delegate void ScoreNotification();
public class GameController
{
	private Dictionary<Players, PlayerData> _playersData = new();

	private Dictionary<Players, Cards> _listCardsOnLocation = new();
	private Dictionary<Players, List<Cards>> _listCardsOnDeck = new();
	
	private List<Location> _locations = new();





	public void AddPlayer(Players players){

	}

	
	public void AddCardsToDeck(Players players, PlayerData playerData){
		_playersData.Add(players, playerData);
	}

	public Dictionary<Players, PlayerData> GetPlayerData(){
		return _playersData;
	}

	// public void AddCardsToLocation(Players players, PlayerData playerData, Location location){
	// 	location.GetId
	// }

	public void AddCardToDeck(Players players, int currentTurn){

		List<Cards> listCard = new();
		if(currentTurn != 1){	
			_listCardsOnDeck[players].Add(DrawCards(players,currentTurn));
		}
		// _listCardsOnDeck.Add(players, listCard.Add(DrawCards(players,currentTurn)));

	}

	public Dictionary<Players, List<Cards>> GetCardsFromDeck(){
		return _listCardsOnDeck;
	}

	public Cards DrawCards(Players players, int currentTurn){
		Random random = new Random();
		PlayerData? result;
		_playersData.TryGetValue(players, out result);

		// foreach(var element in result.GetPlayerCards()){
			int randomIndex = random.Next(result.GetPlayerCards().Count);
			return result.GetPlayerCards()[randomIndex];

		// }
	}

	public void CardsOnDeck(Dictionary<Players, PlayerData> playerData, Cards cards){
		// if(playerData.Contains(cards)){
			
		// }
	}

	public void CalculatePower(Location location){
		// Location

	}

	public void TurnManager(Players players){
		// _playersData[players] = 
	}

	public Dictionary<Players, PlayerData> GetPlayersData(){
		return _playersData;
	}
	
	public void Surrender(Players players)
	{
		_playersData[players].SetStatus(PlayerStatus.Lose);
		string result = _playersData[players].GetStatus().ToString();
		Console.WriteLine($"{players.GetName()} {result}");
	}



	
		
}
