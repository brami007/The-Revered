using UnityEngine;
using System.Collections;

public class MainCharacterClass {

	private string characterClassName;
	private string characterClassDescription;
	//state
	private int strength;
	private int endurance;
	private int resiliance;
	private int intellect;

	public string CharacterClassName{
		get{ return characterClassName;}
		set{characterClassName = value;}
	}
	public string CharacterClassDescription{
		get{ return characterClassDescription;}
		set{characterClassDescription = value;}
	}
	public int Resiliance{
		get{ return resiliance;}
		set{resiliance = value;}
	}
	public int Endurance{
		get{ return endurance;}
		set{endurance = value;}
	}
	public int Strength{
		get{ return strength;}
		set{strength = value;}
	}
	public int Intellect{
		get{ return intellect;}
		set{intellect = value;}
	}
}
