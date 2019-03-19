using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CharacterStatsConfig_Template : CSerializable {
		[Serialize("defaultMaxAttributes")] public Placeholder defaultMaxAttributes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(defaultMaxAttributes));
		}
		public override uint? ClassCRC => 0xBC58D901;
	}
}

