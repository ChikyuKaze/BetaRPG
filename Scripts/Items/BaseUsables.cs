using UnityEngine;
using System.Collections;

public class BaseUsables : BaseStatItems {

	public enum UsableTypes {
		HEALING,
		BOOST
	}
	private UsableTypes usableType;

	public UsableTypes UsableType {
		get { return usableType;}
		set { usableType = value;}
	}
}
