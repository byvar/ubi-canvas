using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class MessageBoxConfig_Template : ITF.TemplateObj {
		public bool autoFetch;
		public float refreshDelay;
		public CListP<string> fetchTypes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			autoFetch = s.Serialize<bool>(autoFetch, name: "autoFetch");
			refreshDelay = s.Serialize<float>(refreshDelay, name: "refreshDelay");
			fetchTypes = s.SerializeObject<CListP<string>>(fetchTypes, name: "fetchTypes");
		}
		public override uint? ClassCRC => 0x29E2611C;
	}
}

