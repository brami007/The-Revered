using UnityEngine;
using System.Collections;

public class BaseStatItem : BaseItem {

	private int strength;
	private int endurance;
	private int resiliance;
	private int intellect;

	public int Strength{
		get{return strength;}
		set{ strength = value;}
	}
	public int Endurance{
		get{return endurance;}
		set{ endurance = value;}
	}
	public int Resiliance{
		get{return resiliance;}
		set{ resiliance = value;}
	}
	public int Intellect{
		get{return intellect;}
		set{ intellect = value;}
	}
}
