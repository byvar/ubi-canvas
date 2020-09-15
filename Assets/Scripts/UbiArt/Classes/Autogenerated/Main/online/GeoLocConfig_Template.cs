using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GeoLocConfig_Template : ITF.TemplateObj {
		public bool AutoFetch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			AutoFetch = s.Serialize<bool>(AutoFetch, name: "AutoFetch");
		}
		public override uint? ClassCRC => 0x98251A96;
	}
}

