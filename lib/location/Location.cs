namespace lib.location;

public class Location
{
	private int _id;
	private string _name;
	private LocationType _type;
	private string _effect;
	private int _turn;
	
	public Location(int id, string name, LocationType type, string effect, int turn)
	{
		_id = id;
		_name = name;
		_type = type;
		_effect = effect;
		_turn = turn;
	}
	
}
