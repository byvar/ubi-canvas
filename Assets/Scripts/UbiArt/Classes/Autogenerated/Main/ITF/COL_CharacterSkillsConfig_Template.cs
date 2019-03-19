using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CharacterSkillsConfig_Template : CSerializable {
		[Serialize("hasteBuffId"   )] public StringID hasteBuffId;
		[Serialize("slowBuffId"    )] public StringID slowBuffId;
		[Serialize("paralyzeBuffId")] public StringID paralyzeBuffId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hasteBuffId));
			SerializeField(s, nameof(slowBuffId));
			SerializeField(s, nameof(paralyzeBuffId));
		}
		public override uint? ClassCRC => 0x1A94CD46;
	}
}

