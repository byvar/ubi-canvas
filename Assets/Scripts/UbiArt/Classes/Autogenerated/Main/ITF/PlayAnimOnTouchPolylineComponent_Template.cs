using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayAnimOnTouchPolylineComponent_Template : ActorComponent_Template {
		public float maxSpeed;
		public float stiff;
		public float damp;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			stiff = s.Serialize<float>(stiff, name: "stiff");
			damp = s.Serialize<float>(damp, name: "damp");
		}
		public override uint? ClassCRC => 0xEBEA4F63;
	}
}

