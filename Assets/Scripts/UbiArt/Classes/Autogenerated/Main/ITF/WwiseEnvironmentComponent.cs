using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class WwiseEnvironmentComponent : BoxInterpolatorComponent {
		[Serialize("WwiseAuxBusGUID")] public StringID WwiseAuxBusGUID;
		[Serialize("ZoneType"       )] public ZONE ZoneType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(WwiseAuxBusGUID));
			SerializeField(s, nameof(ZoneType));
		}
		public enum ZONE {
			[Serialize("ZONE_CIRCLE"   )] CIRCLE = 0,
			[Serialize("ZONE_RECTANGLE")] RECTANGLE = 1,
		}
		public override uint? ClassCRC => 0x2341440A;
	}
}

