using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

	private BaseWeapon newWeapon;

	public void createWeapon() {

		newWeapon = new BaseWeapon ();
		newWeapon.ItemName = "W" + Random.Range (1, 101);
		newWeapon.ItemDescription = "This is a rad weapon.";
		newWeapon.ItemID = Random.Range (1, 101);

		newWeapon.Health = Random.Range (1, 11);
		newWeapon.Attack = Random.Range (1, 11);
		newWeapon.Magic = Random.Range (1, 11);
		newWeapon.Defence = Random.Range (1, 11);
		newWeapon.Resistance = Random.Range (1, 11);
		newWeapon.HiddenStatLuck = Random.Range (1, 11);
		newWeapon.AwesomeStat = Random.Range (1, 11);
		newWeapon.Speed = Random.Range (1, 11);

		chooseWeaponType ();
	}

	private void chooseWeaponType() {
		int temp = Random.Range (1, 7);
		if (temp == 1) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
		}
		else if (temp == 2) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
		}
		else if (temp == 3) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.TOME;
		}
		else if (temp == 4) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.FIST;
		}
		else if (temp == 5) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
		}
		else if (temp == 6) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		}
		else if (temp == 7) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SMASHINGBOARD;
		}
	}
}
