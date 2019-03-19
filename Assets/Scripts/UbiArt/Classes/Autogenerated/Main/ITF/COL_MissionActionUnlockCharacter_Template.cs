using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionUnlockCharacter_Template : CSerializable {
		[Description("character to unlock")]
		[Serialize("characterID")] public StringID characterID;
		[Serialize("unlock"     )] public bool unlock;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(characterID));
			SerializeField(s, nameof(unlock), boolAsByte: true);
		}
		public override uint? ClassCRC => 0x37A0F730;
	}
}

