using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ScreenShotDataFamilyShowcase : online.OpenGraphObject {
		public string family_name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			family_name = s.Serialize<string>(family_name, name: "family_name");
		}
		public override uint? ClassCRC => 0x82483F71;
	}
}

