using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class TweenTeleport_Template : TweenInstruction_Template {
		[Serialize("position"  )] public Vector3 position;
		[Serialize("resetAngle")] public bool resetAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(position));
			SerializeField(s, nameof(resetAngle));
		}
		public override uint? ClassCRC => 0x647A2951;
	}
}

