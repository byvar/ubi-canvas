using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ScreenShotDataRegionUnlocked : online.OpenGraphObject {
		public string region_name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			region_name = s.Serialize<string>(region_name, name: "region_name");
		}
		public override uint? ClassCRC => 0x6ADCF378;
	}
}

