using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class RendezVousConfig_Template : ITF.TemplateObj {
		public string Sandbox;
		public string AccessKey;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Sandbox = s.Serialize<string>(Sandbox, name: "Sandbox");
			AccessKey = s.Serialize<string>(AccessKey, name: "AccessKey");
		}
		public override uint? ClassCRC => 0x596551F6;
	}
}

