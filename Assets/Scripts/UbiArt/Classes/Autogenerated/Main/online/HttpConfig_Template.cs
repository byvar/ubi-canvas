using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class HttpConfig_Template : ITF.TemplateObj {
		public uint MaxRetryCount;
		public float MaxRetryDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			MaxRetryCount = s.Serialize<uint>(MaxRetryCount, name: "MaxRetryCount");
			MaxRetryDuration = s.Serialize<float>(MaxRetryDuration, name: "MaxRetryDuration");
		}
		public override uint? ClassCRC => 0x983F2EE4;
	}
}

