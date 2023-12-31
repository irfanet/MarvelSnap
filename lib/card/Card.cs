namespace lib.card;

public class Card : ICard
{
	private int _id;
	private string _name;
	private string _image;
	private CardType _type;
	private int _power;
	private int _energyCost;
	private string _description;
	private bool _isUsed = false;

	private bool _isReveal = false;
	
	public Card(int id, string name, string image, CardType type, int energyCost, int power, string description)
	{
		_id = id;
		_name = name;
		_image = image;
		_type = type;
		_energyCost = energyCost;
		_power = power;
		_description = description;
	}

	public string GetDescription()
	{
		return _description;
	}

	public int GetEnergyCost()
	{
		return _energyCost;
	}

	public int GetId()
	{
		return _id;
	}

	public string GetImage()
	{
		return _image;
	}

	public string GetName()
	{
		return _name;
	}

	public int GetPower()
	{
		return _power;
	}

	public void Skill()
	{
		Console.WriteLine("doing demek");
	}
	
	public CardType GetType()
	{
		return _type;
	}
	
	public void UseCard(){
		_isUsed = true;
	}
	public bool isUsed()
	{
		return _isUsed;
	}

	public void RevealCard(){
		_isReveal = true;
	}
	public bool IsReveal(){
		return _isReveal;
	}
	
	



}
	






public interface ICardTemp
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public CardType Type { get; set; }
	public int Power { get; set; }
	public int EnergyCost { get; set; }

	void SpecialSkill(GameController game);
}
public class Sentinel : ICardTemp
{
    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public CardType Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Power { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int EnergyCost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void SpecialSkill(GameController game)
    {
		
        // game.AddCardsToDeck(game.GetCurrentPlayer(), )
    }
}


// Player ---

// Location :
// - A (player)
// 	Player --- total point :
// 	-
// 	-
// 	-
// 	Player --- total point : 
// 	-
// 	-
// 	-
// - B (player)
// 	Player --- total point :
// 	-
// 	-
// 	-
// 	Player --- total point : 
// 	-
// 	-
// 	-
// - C (player)
// 	Player --- total point :
// 	-
// 	-
// 	-
// 	Player --- total point : 
// 	-
// 	-
// 	-

// List Card :
// -
// -
// -
// -
// -

// Cara :
// - Skip Turn
// - Take Card
