using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class FacebookConfig_Template : ITF.TemplateObj {
		[Serialize("AppId"      )] public string AppId;
		[Serialize("RedirectUri")] public string RedirectUri;
		[Serialize("Permissions")] public string Permissions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(AppId));
			SerializeField(s, nameof(RedirectUri));
			SerializeField(s, nameof(Permissions));
		}
		public override uint? ClassCRC => 0x90E25A13;
	}
}

