using UnityEngine;
using System.Collections;

public class LoadInformation {

	public static void LoadAllInformation() {
		GameInfo.PlayerLVL = PlayerPrefs.GetInt ("PLAYERLVL");
		GameInfo.PlayerName = PlayerPrefs.GetString ("PLAYERNAME");
		GameInfo.Health = PlayerPrefs.GetInt ("HEALTH");
		GameInfo.Attack = PlayerPrefs.GetInt ("ATTACK");
		GameInfo.Magic = PlayerPrefs.GetInt ("MAGIC");
		GameInfo.Defence = PlayerPrefs.GetInt ("DEFENCE");
		GameInfo.Resistance = PlayerPrefs.GetInt ("RESISTANCE");
		GameInfo.HiddenStatLuck = PlayerPrefs.GetInt ("HIDDENSTATLUCK");
		GameInfo.AwesomeStat = PlayerPrefs.GetInt ("AWESOMESTAT");
		GameInfo.Speed = PlayerPrefs.GetInt ("SPEED");

		if (PlayerPrefs.GetString ("EQUIPMENT1") != null) {
			GameInfo.EquipmentOne = (BaseArmor)PPSerialization.Load("EQUIPMENT1");
		}
	}
}
