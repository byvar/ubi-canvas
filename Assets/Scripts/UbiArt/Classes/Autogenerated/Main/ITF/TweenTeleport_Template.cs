using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class TweenTeleport_Template : TweenInstruction_Template {
		public Vec3d position;
		public bool resetAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			position = s.SerializeObject<Vec3d>(position, name: "position");
			resetAngle = s.Serialize<bool>(resetAngle, name: "resetAngle");
		}
		public override uint? ClassCRC => 0x647A2951;
	}
}

