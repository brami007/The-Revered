using UnityEngine;
using System.Collections;

public class CreateWeapon : MonoBehaviour {

	private BaseWeapon newWeapon;

	void Start(){
		CreateWeapons ();
		Debug.Log (newWeapon.ItemName);
		Debug.Log (newWeapon.ItemDescription);
		Debug.Log (newWeapon.ItemID.ToString());
		Debug.Log (newWeapon.WeaponType.ToString());
		Debug.Log (newWeapon.Strength);
		Debug.Log (newWeapon.Endurance);
		Debug.Log (newWeapon.Resiliance);
		Debug.Log (newWeapon.Intellect);
		Debug.Log (newWeapon.ItemName);



	}

	public void CreateWeapons(){
		newWeapon = new BaseWeapon ();

		//weapon name
		newWeapon.ItemName = "w" + Random.Range (1, 101);
		//description
		newWeapon.ItemDescription = "new weapon";
		//id
		newWeapon.ItemID = Random.Range(1,101);
		//stats
		newWeapon.Strength = Random.Range (1, 11);
		newWeapon.Resiliance = Random.Range (1, 11);
		newWeapon.Intellect = Random.Range (1, 11);
		newWeapon.Endurance = Random.Range (1, 11);
		//type
		ChooseWeaponType ();
		//spelleffect
		newWeapon.SpellEffectID = Random.Range (1, 101);
	}

	public void ChooseWeaponType(){
		int randomWeapon = Random.Range (1, 7);
		if (randomWeapon == 1) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.KNUCKLES;
		}else if (randomWeapon == 2) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.STICK;
		}else if (randomWeapon == 3) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
		}else if (randomWeapon == 4) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
		}else if (randomWeapon == 5) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
		}else if (randomWeapon == 6) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOOMERANG;
		}
	}
}
