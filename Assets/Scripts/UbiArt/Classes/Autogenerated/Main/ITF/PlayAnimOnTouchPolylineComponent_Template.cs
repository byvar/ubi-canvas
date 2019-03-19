using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayAnimOnTouchPolylineComponent_Template : ActorComponent_Template {
		[Serialize("maxSpeed")] public float maxSpeed;
		[Serialize("stiff"   )] public float stiff;
		[Serialize("damp"    )] public float damp;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(stiff));
			SerializeField(s, nameof(damp));
		}
		public override uint? ClassCRC => 0xEBEA4F63;
	}
}

