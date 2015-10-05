using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseStatItems : BaseItems {

	private int health;
	private int attack;
	private int magic;
	private int defence;
	private int resistance;
	private int hiddenStatLuck;
	private int awesomeStat;
	private int speed;

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
}
