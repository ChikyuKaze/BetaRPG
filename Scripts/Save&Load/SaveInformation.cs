using UnityEngine;
using System.Collections;

public class SaveInformation {

	public static void SaveAllInformation () {
		PlayerPrefs.SetInt ("PLAYERLVL", GameInfo.PlayerLVL);
		PlayerPrefs.SetString ("PLAYERNAME", GameInfo.PlayerName);
		PlayerPrefs.SetInt ("HEALTH", GameInfo.Health);
		PlayerPrefs.SetInt ("ATTACK", GameInfo.Attack);
		PlayerPrefs.SetInt ("MAGIC", GameInfo.Magic);
		PlayerPrefs.SetInt ("DEFENCE", GameInfo.Defence);
		PlayerPrefs.SetInt ("RESISTANCE", GameInfo.Resistance);
		PlayerPrefs.SetInt ("HIDDENSTATLUCK", GameInfo.HiddenStatLuck);
		PlayerPrefs.SetInt ("AWESOMESTAT", GameInfo.AwesomeStat);
		PlayerPrefs.SetInt ("SPEED", GameInfo.Speed);

		if (GameInfo.EquipmentOne != null) {
			PPSerialization.saveFunction ("EQUIPENT1", GameInfo.EquipmentOne);
		}
	}
}
