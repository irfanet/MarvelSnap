namespace lib.cards;

public class Cards : ICards
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
	
	public Cards(int id, string name, string image, CardType type, int energyCost, int power, string description)
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
	
