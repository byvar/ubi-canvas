using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class SkillRatingConfig_Template : ITF.TemplateObj {
		[Serialize("DefaultSkillboard")] public uint DefaultSkillboard;
		[Serialize("AutoFetch"        )] public bool AutoFetch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DefaultSkillboard));
			SerializeField(s, nameof(AutoFetch));
		}
		public override uint? ClassCRC => 0xC133B853;
	}
}

