using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_SkillTreeMenu : CSerializable {
		public StringID characterID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			characterID = s.SerializeObject<StringID>(characterID, name: "characterID");
		}
		public override uint? ClassCRC => 0x217F2515;
	}
}

