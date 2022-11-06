using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionRemoveEquippedRunes_Template : CSerializable {
		[Description("character to unequip")]
		public StringID characterID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			characterID = s.SerializeObject<StringID>(characterID, name: "characterID");
		}
		public override uint? ClassCRC => 0xA2BEF6A6;
	}
}

