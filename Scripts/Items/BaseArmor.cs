using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseArmor : BaseStatItems {

	public enum ArmorTypes {
		GENERAL,
		SPECIAL
	}
	private ArmorTypes armorType;

	public ArmorTypes ArmorType {
		get { return armorType;}
		set { armorType = value;}
	}
}
