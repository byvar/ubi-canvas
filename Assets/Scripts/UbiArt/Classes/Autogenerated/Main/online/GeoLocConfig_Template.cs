using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GeoLocConfig_Template : ITF.TemplateObj {
		[Serialize("AutoFetch")] public bool AutoFetch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(AutoFetch));
		}
		public override uint? ClassCRC => 0x98251A96;
	}
}

