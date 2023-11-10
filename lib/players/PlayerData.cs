using lib.cards;

namespace lib.players;

public class PlayerData
{
	private List<Cards> _listCard;
	private int _score;
	private int _energy;
	private PlayerStatus _status;
	
	public PlayerData(List<Cards> cards, int score, int energy, PlayerStatus status)
	{
		_listCard = cards;
		_score = score;
		_energy = energy;
		_status = status;
	}
	
}
