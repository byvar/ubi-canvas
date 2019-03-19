using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionRemoveEquippedRunes_Template : CSerializable {
		[Description("character to unequip")]
		[Serialize("characterID")] public StringID characterID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(characterID));
		}
		public override uint? ClassCRC => 0x097F1A91;
	}
}

