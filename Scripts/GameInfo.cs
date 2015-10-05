using UnityEngine;
using System.Collections;

public class GameInfo : MonoBehaviour {

	void Awake () {
		DontDestroyOnLoad (transform.gameObject);
	}

	public static string PlayerName {get; set;}
	public static int PlayerLVL {get; set;}
	public static BaseClasses PlayerClass {get; set;}
	public static int Health {get; set;}
	public static int Attack {get; set;}
	public static int Magic {get; set;}
	public static int Defence {get; set;}
	public static int Resistance {get; set;}
	public static int HiddenStatLuck {get; set;}
	public static int AwesomeStat {get; set;}
	public static int Speed {get; set;}
	public static BaseArmor EquipmentOne {get; set;}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
