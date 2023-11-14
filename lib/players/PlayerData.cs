using lib.cards;

namespace lib.players;

public class PlayerData
{
	private List<Cards> _listCard;
	private int _score;
	private int _energy;
	private PlayerStatus _status;


	
	public PlayerData(List<Cards> cards, PlayerStatus status)
	{
		_listCard = cards;
		_score = 0;
		_energy = 1;
		_status = status;
	}

	public List<Cards> GetPlayerCards(){
		return _listCard;
	}

	public void SetStatus(PlayerStatus status){
		_status = status;
	}

	public PlayerStatus GetStatus(){
		return _status;
	}
	
	public void SetEnergy(int energy){
		_energy = energy;
	}

	public int GetEnergy(){
		return _energy;
	}

	public void SetScore(int score){
		_score = score;
	}

	public int GetScore(){
		return _score;
	}

	public Cards GetCard(int id){
		return _listCard.Find(x => x.GetId() == id);
	}
}
