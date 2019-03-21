using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class PolylineComponent_Template : ActorComponent_Template {
		[Serialize("polylineParams")] public CList<PolylineParameters> polylineParams;
		[Serialize("isEnvironment" )] public bool isEnvironment;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(polylineParams));
			SerializeField(s, nameof(isEnvironment));
		}
		public override uint? ClassCRC => 0x72853946;
	}
}

