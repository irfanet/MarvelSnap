namespace lib.players;

public class Players : IPlayers
{
	private int _id;
	private string _name;
	public Players(int id, string name){
		_id = id;
		_name = name;
	}
	public int GetId()
	{
		throw new NotImplementedException();
	}

	public int GetName()
	{
		throw new NotImplementedException();
	}

}