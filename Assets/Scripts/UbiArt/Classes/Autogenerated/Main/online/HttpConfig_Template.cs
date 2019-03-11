using UnityEngine;

namespace UbiArt.online {
	public partial class HttpConfig_Template : ITF.TemplateObj {
		[Serialize("MaxRetryCount")] public uint MaxRetryCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(MaxRetryCount));
		}
		public override uint? ClassCRC => 0x983F2EE4;
	}
}

