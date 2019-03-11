using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_AmbianceConfigRunnerOverride : RLC_AmbianceConfig {
		[Serialize("MapPath")] public Path MapPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(MapPath));
		}
		public override uint? ClassCRC => 0xCE6FB512;
	}
}

