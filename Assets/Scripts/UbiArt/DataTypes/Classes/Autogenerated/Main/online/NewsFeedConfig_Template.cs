using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class NewsFeedConfig_Template : ITF.TemplateObj {
		public bool AutoFetch;
		public uint RefreshDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			AutoFetch = s.Serialize<bool>(AutoFetch, name: "AutoFetch");
			RefreshDelay = s.Serialize<uint>(RefreshDelay, name: "RefreshDelay");
		}
		public override uint? ClassCRC => 0xA65E5796;
	}
}

