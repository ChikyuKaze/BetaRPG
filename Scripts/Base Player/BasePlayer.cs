using UnityEngine;
using System.Collections;

public class BasePlayer {

	private string playerName;
	private int playerLVL, health, attack, magic, defence, resistance, hiddenStatLuck,
		awesomeStat, speed;
	private BaseClasses playerClass;

	public string PlayerName {
		get{ return playerName;}
		set{ playerName = value;}
	}

	public int PlayerLVL {
		get { return playerLVL;}
		set { playerLVL = value;}
	}

	public BaseClasses PlayerClass {
		get { return playerClass;}
		set { playerClass = value;}
	}

	public int Health {
		get { return health;}
		set { health = value;}
	}
	
	public int Attack {
		get { return attack;}
		set { attack = value;}
	}
	
	public int Magic {
		get { return magic;}
		set { magic = value;}
	}
	
	public int Defence {
		get { return defence;}
		set { defence = value;}
	}
	
	public int Resistance {
		get { return resistance;}
		set { resistance = value;}
	}
	
	public int HiddenStatLuck {
		get { return hiddenStatLuck;}
		set { hiddenStatLuck = value;}
	}
	
	public int AwesomeStat {
		get { return awesomeStat;}
		set { awesomeStat = value;}
	}
	
	public int Speed {
		get { return speed;}
		set { speed = value;}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
