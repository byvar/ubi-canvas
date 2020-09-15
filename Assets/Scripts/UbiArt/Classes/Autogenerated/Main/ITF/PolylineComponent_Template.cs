using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class PolylineComponent_Template : ActorComponent_Template {
		public CList<PolylineParameters> polylineParams;
		public bool isEnvironment;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			polylineParams = s.SerializeObject<CList<PolylineParameters>>(polylineParams, name: "polylineParams");
			isEnvironment = s.Serialize<bool>(isEnvironment, name: "isEnvironment");
		}
		public override uint? ClassCRC => 0x72853946;
	}
}

