using UnityEngine;

namespace UbiArt.online {
	public partial class RendezVousConfig_Template : ITF.TemplateObj {
		[Serialize("Sandbox"  )] public string Sandbox;
		[Serialize("AccessKey")] public string AccessKey;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Sandbox));
			SerializeField(s, nameof(AccessKey));
		}
		public override uint? ClassCRC => 0x596551F6;
	}
}

