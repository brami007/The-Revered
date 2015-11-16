using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {

	public enum WeaponTypes{
		KNUCKLES,
		STICK,
		STAFF,
		SHIELD,
		SWORD,
		BOOMERANG
	}
	private WeaponTypes weaponType;
	private int spellEffectID;

	public WeaponTypes WeaponType{
		get{ return weaponType;}
		set{ weaponType = value;}
	}

	public int SpellEffectID{
		get{ return spellEffectID;}
		set{ spellEffectID = value;}
	}
}
