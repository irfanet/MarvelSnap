namespace lib;
using lib.cards;
using lib.location;
using lib.players;

public class GameController
{
	private Dictionary <Players, PlayerData> _players;
	
	private List<Location> _locations;
	

	Cards card1 = new(1,"Hawkeys","Hawkeys",CardType.Attack,1,1,"Location next turn, +3 Power");
	Cards card2 = new(2,"Medusa","Medusa",CardType.Attack,2,2,"If this is at middle location, +3 Power");
	Cards card3 = new(3,"Sentinel","Sentinel",CardType.Attack,2,3,"Add another Sentinel to your hand");
	Cards card4 = new(4,"Iron Man","Iron Man",CardType.Attack,5,0,"Your total Power is doubled at this location");
	Cards card5 = new(5,"Hulk","Hulk",CardType.Attack,6,12,"HULK SMASH!");
	List<Cards> kartu = new List<Cards>();
	
	Players p1 = new(1, "Irfan");
	Players p2 = new(2, "Nafri");
	

	
		
}
