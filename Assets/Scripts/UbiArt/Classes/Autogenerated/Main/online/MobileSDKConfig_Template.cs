using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class MobileSDKConfig_Template : ITF.TemplateObj {
		[Serialize("SqliteKey")] public string SqliteKey;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(SqliteKey));
		}
		public override uint? ClassCRC => 0x839A2B9C;
	}
}

