using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class ConstantMovementComponent_Template : ActorComponent_Template {
		[Serialize("localSpeed"       )] public Vec2d localSpeed;
		[Serialize("worldSpeed"       )] public Vec3d worldSpeed;
		[Serialize("worldAngularSpeed")] public Angle worldAngularSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(localSpeed));
			SerializeField(s, nameof(worldSpeed));
			SerializeField(s, nameof(worldAngularSpeed));
		}
		public override uint? ClassCRC => 0x49A81091;
	}
}

