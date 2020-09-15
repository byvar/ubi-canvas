using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionConditionCharacterUnlocked_Template : CSerializable {
		public StringID characterId;
		public bool negated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			characterId = s.SerializeObject<StringID>(characterId, name: "characterId");
			negated = s.Serialize<bool>(negated, name: "negated", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0xD269800E;
	}
}

