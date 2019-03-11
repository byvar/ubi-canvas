using UnityEngine;

namespace UbiArt.ITF {
	public partial class WwiseEnvironmentComponent : BoxInterpolatorComponent {
		[Serialize("ZoneType")] public ZONE ZoneType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ZoneType));
		}
		public enum ZONE {
			[Serialize("ZONE_CIRCLE"   )] CIRCLE = 0,
			[Serialize("ZONE_RECTANGLE")] RECTANGLE = 1,
		}
		public override uint? ClassCRC => 0x2341440A;
	}
}

