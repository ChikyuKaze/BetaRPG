using UnityEngine;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isWarriorClass;
	private bool isMageClass;
	private bool isThiefClass;
	private string playerName = "Enter Name";

	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		playerName = GUILayout.TextField (playerName, 16);

		isWarriorClass = GUILayout.Toggle (isWarriorClass, "Warrior Class");
		isMageClass = GUILayout.Toggle (isMageClass, "Mage Class");
		isThiefClass = GUILayout.Toggle (isThiefClass, "Thief Class");

		if (GUILayout.Button ("Create")) {
			if (isWarriorClass) {
				newPlayer.PlayerClass = new BaseWarrior();
			} else if (isMageClass) {
				newPlayer.PlayerClass = new BaseMage();
			} else if (isThiefClass) {
				newPlayer.PlayerClass = new BaseThief();
			}

			newPlayer.PlayerLVL = 1;
			newPlayer.Health = newPlayer.PlayerClass.Health;
			newPlayer.Attack = newPlayer.PlayerClass.Attack;
			newPlayer.Magic = newPlayer.PlayerClass.Magic;
			newPlayer.Defence = newPlayer.PlayerClass.Defence;
			newPlayer.Resistance = newPlayer.PlayerClass.Resistance;
			newPlayer.HiddenStatLuck = newPlayer.PlayerClass.HiddenStatLuck;
			newPlayer.AwesomeStat = newPlayer.PlayerClass.AwesomeStat;
			newPlayer.Speed = newPlayer.PlayerClass.Speed;
			newPlayer.PlayerName = playerName;
			SaveInformation.SaveAllInformation();
		}
	}
}
