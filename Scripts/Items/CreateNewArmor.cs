using UnityEngine;
using System.Collections;

public class CreateNewArmor : MonoBehaviour {

	private BaseArmor newArmor;
	private string[] itemNames = (new string[2]{"Common", "Special"});

	private void createArmor() {
		newArmor = new BaseArmor();
		newArmor.ItemName = itemNames[Random.Range(0, 1)];
		newArmor.ItemID = Random.Range(1, 101);
		chooseItemType();

		newArmor.Health = Random.Range (1, 11);
		newArmor.Attack = Random.Range (1, 11);
		newArmor.Magic = Random.Range (1, 11);
		newArmor.Defence = Random.Range (1, 11);
		newArmor.Resistance = Random.Range (1, 11);
		newArmor.HiddenStatLuck = Random.Range (1, 11);
		newArmor.AwesomeStat = Random.Range (1, 11);
		newArmor.Speed = Random.Range (1, 11);
	}

	private void chooseItemType() {
		int temp = Random.Range (1, 2);
		if (temp == 1) {
			newArmor.ArmorType = BaseArmor.ArmorTypes.GENERAL;
		} else {
			newArmor.ArmorType = BaseArmor.ArmorTypes.SPECIAL;
		}
	}
}
