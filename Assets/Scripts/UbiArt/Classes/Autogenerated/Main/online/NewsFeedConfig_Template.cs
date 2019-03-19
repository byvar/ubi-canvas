using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class NewsFeedConfig_Template : ITF.TemplateObj {
		[Serialize("AutoFetch"   )] public bool AutoFetch;
		[Serialize("RefreshDelay")] public uint RefreshDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(AutoFetch));
			SerializeField(s, nameof(RefreshDelay));
		}
		public override uint? ClassCRC => 0xA65E5796;
	}
}

