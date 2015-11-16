using UnityEngine;
using System.Collections;

public class Tester : MonoBehaviour {

	private MainCharacterClass class1 = new BaseMonkClass();
	private MainCharacterClass class2 = new BaseNormalHumanClass();
	private MainCharacterClass class3 = new BasePriestClass();
	private MainCharacterClass class4 = new BaseStudentClass();


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUILayout.Label (class1.CharacterClassName);
		GUILayout.Label (class1.CharacterClassDescription);
		GUILayout.Label (class1.Strength.ToString ());
		GUILayout.Label (class2.CharacterClassName);
		GUILayout.Label (class2.CharacterClassDescription);
		GUILayout.Label (class3.CharacterClassName);
		GUILayout.Label (class3.CharacterClassDescription);
		GUILayout.Label (class4.CharacterClassName);
		GUILayout.Label (class4.CharacterClassDescription);

	}

}
