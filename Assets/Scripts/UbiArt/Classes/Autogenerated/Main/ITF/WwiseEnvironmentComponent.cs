using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class WwiseEnvironmentComponent : BoxInterpolatorComponent {
		public StringID WwiseAuxBusGUID;
		public ZONE ZoneType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			WwiseAuxBusGUID = s.SerializeObject<StringID>(WwiseAuxBusGUID, name: "WwiseAuxBusGUID");
			ZoneType = s.Serialize<ZONE>(ZoneType, name: "ZoneType");
		}
		public enum ZONE {
			[Serialize("ZONE_CIRCLE"   )] CIRCLE = 0,
			[Serialize("ZONE_RECTANGLE")] RECTANGLE = 1,
		}
		public override uint? ClassCRC => 0x2341440A;
	}
}

