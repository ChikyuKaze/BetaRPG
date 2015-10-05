using UnityEngine;
using System.Collections;

public class BaseMage : BaseClasses {

	public BaseMage() {

		CharacterClassName = "Mage";
		CharacterClassDescription = "The other class people usually pick if they don't like the Warrior.";

		Health = 15;
		Attack = 4;
		Magic = 11;
		Defence = 4;
		Resistance = 9;
		HiddenStatLuck = 0;
		AwesomeStat = 0;
		Speed = 7;
	}
}
