using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseWeapon : BaseStatItems {

	public enum WeaponTypes {
		SWORD,
		STAFF,
		TOME,
		FIST,
		DAGGER,
		BOW,
		SMASHINGBOARD
	}
	private WeaponTypes weaponType;
	private int spellEffectID;

	public WeaponTypes WeaponType {
		get { return weaponType;}
		set { weaponType = value;}
	}

	public int SpellEffectID {
		get { return spellEffectID;}
		set { spellEffectID = value;}
	}
}
