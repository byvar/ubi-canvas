using UnityEngine;

namespace UbiArt.online {
	public partial class MatchMakingConfig_Template : ITF.TemplateObj {
		[Serialize("DefaultSessionType")] public uint DefaultSessionType;
		[Serialize("DefaultQuery"      )] public uint DefaultQuery;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DefaultSessionType));
			SerializeField(s, nameof(DefaultQuery));
		}
		public override uint? ClassCRC => 0x1873E7DF;
	}
}

