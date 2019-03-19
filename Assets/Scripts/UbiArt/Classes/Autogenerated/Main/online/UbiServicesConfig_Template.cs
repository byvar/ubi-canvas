using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class UbiServicesConfig_Template : ITF.TemplateObj {
		[Serialize("ApplicationId")] public string ApplicationId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ApplicationId));
		}
		public override uint? ClassCRC => 0x49FF8E91;
	}
}

