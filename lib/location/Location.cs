using lib.cards;
using lib.players;

namespace lib.location;

public class Location
{
	private int _id;
	private string _name;
	private LocationType _type;
	private string _effect;
	private int _turn;
	private List<Cards> _listCards = new();
	private Dictionary<Players, List<Cards>> _listCardsOnLocation = new();
	
	public Location(int id, string name, string effect, int turn)
	{
		_id = id;
		_name = name;
		_effect = effect;
		_turn = turn;
	}

	public void AddCardsToLocation(Players players, Cards cards){
		_listCardsOnLocation[players].Add(cards);
	}

	public Dictionary<Players, List<Cards>> GetCardsOnLocation(){
		return _listCardsOnLocation;
	}

	public string GetName(){
		return _name;
	}

	public string GetEffect(){
		return _effect;
	}

	public int GetId(){
		return _id;
	}
	
}
