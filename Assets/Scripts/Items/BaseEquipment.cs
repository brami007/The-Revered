using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseStatItem {

	public enum EquipmentTypes{
		HEAD,
		CHEST,
		LEGS,
		FEET,
		SHOULDERS,
		HANDS,
		NECKLACE,
		BRACERS,
		EARRINGS,
		RINGS
	}

	private EquipmentTypes equipmentType;
	private int spellEffectID;

	public EquipmentTypes EquipmentType{
		get{ return equipmentType;}
		set{ equipmentType = value;}
	}

	public int SpellEffects{
		get{ return spellEffectID;}
		set{ spellEffectID = value;}
	}
}
