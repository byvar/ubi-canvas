using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class MessageBoxConfig_Template : ITF.TemplateObj {
		[Serialize("autoFetch"   )] public bool autoFetch;
		[Serialize("refreshDelay")] public float refreshDelay;
		[Serialize("fetchTypes"  )] public CList<string> fetchTypes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(autoFetch));
			SerializeField(s, nameof(refreshDelay));
			SerializeField(s, nameof(fetchTypes));
		}
		public override uint? ClassCRC => 0x29E2611C;
	}
}

