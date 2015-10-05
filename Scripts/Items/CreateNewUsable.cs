using UnityEngine;
using System.Collections;

public class CreateNewUsable : MonoBehaviour {

	private BaseUsables newUsable;

	private void createUsable() {
		newUsable = new BaseUsables();
		newUsable.ItemName = "Use me!";
		newUsable.ItemDescription = "A random effect, how conducive to the game!";
		newUsable.ItemID = Random.Range(1 ,101);
		chooseUsableType ();
	}

	private void chooseUsableType() {
		int temp = Random.Range(1, 2);
		if (temp == 1) {
			newUsable.UsableType = BaseUsables.UsableTypes.HEALING;
		} else {
			newUsable.UsableType = BaseUsables.UsableTypes.BOOST;
		}
	}
}
