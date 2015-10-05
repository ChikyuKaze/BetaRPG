using UnityEngine;
using System.Collections;

public class BaseWarrior : BaseClasses {

	public BaseWarrior() {

		CharacterClassName = "Warrior";
		CharacterClassDescription = "What most people choose as their first class.";

		Health = 21;
		Attack = 9;
		Magic = 3;
		Defence = 8;
		Resistance = 4;
		HiddenStatLuck = 0;
		AwesomeStat = 0;
		Speed = 5;
	}
}
