using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour {

	private BaseClasses class1 = new BaseWarrior();
	private BaseClasses class2 = new BaseMage();
	private BaseClasses class3 = new BaseThief();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {

		GUILayout.Label (class1.CharacterClassName);
		GUILayout.Label (class1.CharacterClassDescription);

		GUILayout.Label (class2.CharacterClassName);
		GUILayout.Label (class2.CharacterClassDescription);

		GUILayout.Label (class3.CharacterClassName);
		GUILayout.Label (class3.CharacterClassDescription);
	}
}
