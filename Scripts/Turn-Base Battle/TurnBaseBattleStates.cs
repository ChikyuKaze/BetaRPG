using UnityEngine;
using System.Collections;

public class TurnBaseBattleStates : MonoBehaviour {

	public enum BattleStates {
		START,
		SPECIALANIMATE,
		PLAYERTURN,
		ENEMYTURN,
		LOSESTATE,
		WINSTATE
	}

	private BattleStates currentState;

	void Start () {
		currentState = BattleStates.START;
	}

	void Update () {
		switch (currentState) {
		case (BattleStates.START):
			break;
		case (BattleStates.SPECIALANIMATE):
			break;
		case (BattleStates.PLAYERTURN):
			break;
		case (BattleStates.ENEMYTURN):
			break;
		case (BattleStates.LOSESTATE):
			break;
		case (BattleStates.WINSTATE):
			break;
		}
	}

	void OnGUI () {
		if (GUILayout.Button("NEXT STATE")) {
			if (currentState == BattleStates.START) {
				currentState = BattleStates.SPECIALANIMATE;
			} else if (currentState == BattleStates.SPECIALANIMATE) {
				currentState = BattleStates.PLAYERTURN;
			} else if (currentState == BattleStates.PLAYERTURN) {
				currentState = BattleStates.ENEMYTURN;
			} else if (currentState == BattleStates.ENEMYTURN) {
				currentState = BattleStates.LOSESTATE;
			} else if (currentState == BattleStates.LOSESTATE) {
				currentState = BattleStates.WINSTATE;
			}
		}
	}

}
