using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using lib;
using lib.cards;
using lib.location;
using lib.players;

class Program
{
	static void Main()
	{
		Players p1 = new(1, "Irfan");
		Players p2 = new(2, "Nafri");

		Cards card1 = new(1, "Hawkeys", "Hawkeys", CardType.Attack, 1, 1, "Location next turn, +3 Power");
		Cards card2 = new(2, "Medusa", "Medusa", CardType.Attack, 2, 2, "If this is at middle location, +3 Power");
		Cards card3 = new(3, "Sentinel", "Sentinel", CardType.Attack, 2, 3, "Add another Sentinel to your hand");
		Cards card4 = new(4, "Iron Man", "Iron Man", CardType.Attack, 5, 0, "Your total Power is doubled at this location");
		Cards card5 = new(5, "Hulk", "Hulk", CardType.Attack, 6, 12, "HULK SMASH!");
		Cards card6 = new(6, "Hulk", "Hulk", CardType.Attack, 6, 12, "HULK SMASH!");
		Cards card7 = new(7, "Juggernaut", "Juggernaut", CardType.Attack, 3, 3, "If your opponent played cards here this turn, move them randomly.");
		Cards card8 = new(8, "Sandman", "Sandman", CardType.Attack, 5, 4, "Players can only play 1 card a turn");
		Cards card9 = new(9, "Aero", "Aero", CardType.Attack, 5, 8, "Move the last enemy card played this turn to this location.");
		Cards card10 = new(10, "Elektra", "Elektra", CardType.Attack, 1, 1, "Destroy a random enemy 1-Cost card at this location.");
		Cards card11 = new(11, "Nebula", "Nebula", CardType.Attack, 1, 1, "Each turn your opponent doesn't play a card here, +2 Power. (except the turn you play this)");
		Cards card12 = new(12, "Hulk", "Hulk", CardType.Attack, 6, 12, "HULK SMASH!");

		List<Cards> listCards = new()
		{
			card1,
			card2,
			card3,
			card4,
			card5,
			card6,
			card7,
			card8,
			card9,
			card10,
			card11,
			card12
		};

		PlayerData p1Data = new(listCards, PlayerStatus.OnGoing);
		PlayerData p2Data = new(listCards, PlayerStatus.OnGoing);

		GameController gameController = new GameController();
		gameController.AddCardsToDeck(p1, p1Data);
		gameController.AddCardsToDeck(p2, p2Data);

		Location location1 = new(1, "Altar of Death", "After you play a card here, destroy it to get +2 Energy next turn.", 1);
		Location location2 = new(2, "Asgard", "After turn 4, whoever is winning here draws 2.", 2);
		Location location3 = new(3, "Atlantis", "If you only have one card here, it has +5 Power.", 3);

		List<Location> listLocation = new(){
			location1,
			location2,
			location3
		};

		int maxTurn = 6;
		int turnCounter = 0;

		Dictionary<Players, PlayerData> playerData = gameController.GetPlayerData();
		// while (turnCounter <= maxTurn)
		// {
		// 	turnCounter++;
		// 	foreach (var currentPlayer in playerData)
		// 	{
		// 		Console.WriteLine("Turn = {0}", turnCounter);
		// 		currentPlayer.Key.GetName().Dump();
		// 		Console.WriteLine(currentPlayer.Value.GetEnergy());
		// 		Console.WriteLine(currentPlayer.Value.GetScore());
		// 		gameController.AddCardToDeck(currentPlayer.Key, turnCounter);
		// 		foreach (var element in gameController.GetCardsFromDeck())
		// 		{
		// 			element.Key.GetName().Dump();
		// 			foreach (var e in element.Value)
		// 			{
		// 				e.GetImage().Dump();
		// 			}
		// 		}
		// 	}
		// }

		while (turnCounter <= maxTurn)
		{
			turnCounter++;
			foreach (var e in playerData)
			{
				e.Value.SetEnergy(turnCounter);
				$"=================Player {e.Key.GetId()} : {e.Key.GetName()}===============".Dump();
				$"Turn = {turnCounter} / {maxTurn}".Dump();
				$"Energy: {e.Value.GetEnergy()}".Dump();
				// Console.WriteLine(e.Value.GetScore());

				int CardLimit = 0;
				foreach (var y in e.Value.GetPlayerCards())
				{
					if (turnCounter == 1)
					{
						$"-------------- Card Id : {y.GetId()} ---------------".Dump();
						$"Cost: {y.GetEnergyCost()} \t\t\t".DumpThis();
						$"Power: {y.GetPower()}".Dump();
						$"\t\t {y.GetName()}".Dump();
						$"< {y.GetDescription()} >".Dump();
						Console.WriteLine("------------------------------------------");
						y.RevealCard();
						CardLimit++;
						if (CardLimit == 4)
						{
							break;
						}
					}else{
						if (!y.IsReveal())
						{
							CardLimit = 0;
							$"-------------- Card Id : {y.GetId()} ---------------".Dump();
							$"Cost: {y.GetEnergyCost()} \t\t\t".DumpThis();
							$"Power: {y.GetPower()}".Dump();
							$"\t\t {y.GetName()}".Dump();
							$"< {y.GetDescription()} >".Dump();
							Console.WriteLine("------------------------------------------");
							y.RevealCard();
							CardLimit++;
							if (CardLimit == 1)
							{
								break;
							}
						}
					}

				}

				"".Dump();
				"===============Location===============".Dump();
				foreach (var locationElement in listLocation)
				{
					locationElement.GetId().Dump();
					locationElement.GetName().Dump();
					locationElement.GetEffect().Dump();
				}
				"Pick your card: ".Dump();
				int inputCard = int.Parse(Console.ReadLine());
				inputCard.Dump();
				if (e.Value.GetCard(inputCard).GetEnergyCost() <= e.Value.GetEnergy())
				{
					"Success".Dump();
				}
				else
				{
					"Lack Energy".Dump();
				}

				"Select location: ".Dump();
				int? inputLocation = int.Parse(Console.ReadLine());
				inputLocation?.Dump();
				// Console.Clear();
			}
		}
	}


}

static class MyExtension
{
	public static void Dump(this object obj)
	{
		Console.WriteLine(obj);
	}

	public static void DumpThis(this object obj)
	{
		Console.Write(obj);
	}
	public static void CardPrinter(Cards cards)
	{
		Console.WriteLine($"Id : {cards.GetId()}");
		Console.WriteLine($"Name : {cards.GetName()}");
		Console.WriteLine($"Cost : {cards.GetEnergyCost()}");
		Console.WriteLine($"Power : {cards.GetPower()}");
		Console.WriteLine($"Description : {cards.GetDescription()}");

	}
}