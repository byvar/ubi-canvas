using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionConditionCharacterUnlocked_Template : CSerializable {
		[Serialize("characterId")] public StringID characterId;
		[Serialize("negated"    )] public bool negated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(characterId));
			SerializeField(s, nameof(negated), boolAsByte: true);
		}
		public override uint? ClassCRC => 0xD269800E;
	}
}

