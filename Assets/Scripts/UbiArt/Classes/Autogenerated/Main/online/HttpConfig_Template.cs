using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class HttpConfig_Template : ITF.TemplateObj {
		[Serialize("MaxRetryCount"   )] public uint MaxRetryCount;
		[Serialize("MaxRetryDuration")] public float MaxRetryDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(MaxRetryCount));
			SerializeField(s, nameof(MaxRetryDuration));
		}
		public override uint? ClassCRC => 0x983F2EE4;
	}
}

