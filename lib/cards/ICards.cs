namespace lib.cards;

public interface ICards
{
	int GetId();
	string GetImage();
	string GetName();
	CardType GetType();
	int GetPower();
	int GetEnergyCost();
	string GetDescription();
	void Skill();
	
	bool IsReveal();
}
