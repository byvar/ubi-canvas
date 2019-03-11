using UnityEngine;

namespace UbiArt.ITF {
	public partial class ScreenShotDataRegionUnlocked : online.OpenGraphObject {
		[Serialize("region_name")] public string region_name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(region_name));
		}
		public override uint? ClassCRC => 0x6ADCF378;
	}
}

