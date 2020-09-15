using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class MobileSDKConfig_Template : ITF.TemplateObj {
		public string SqliteKey;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SqliteKey = s.Serialize<string>(SqliteKey, name: "SqliteKey");
		}
		public override uint? ClassCRC => 0x839A2B9C;
	}
}

