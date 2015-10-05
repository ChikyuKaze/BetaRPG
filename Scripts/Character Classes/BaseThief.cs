using UnityEngine;
using System.Collections;

public class BaseThief : BaseClasses {
	
	public BaseThief() {

		CharacterClassName = "Thief";
		CharacterClassDescription = "A class you would choose if you wanted to rebel from the norm" +
			" or rebel against what I type because you hate me.";

		Health = 18;
		Attack = 6;
		Magic = 5;
		Defence = 5;
		Resistance = 6;
		HiddenStatLuck = 0;
		AwesomeStat = 0;
		Speed = 10;
	}
}
