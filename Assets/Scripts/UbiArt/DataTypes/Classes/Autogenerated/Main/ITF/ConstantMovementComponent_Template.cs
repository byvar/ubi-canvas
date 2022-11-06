using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class ConstantMovementComponent_Template : ActorComponent_Template {
		public Vec2d localSpeed;
		public Vec3d worldSpeed;
		public Angle worldAngularSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			localSpeed = s.SerializeObject<Vec2d>(localSpeed, name: "localSpeed");
			worldSpeed = s.SerializeObject<Vec3d>(worldSpeed, name: "worldSpeed");
			worldAngularSpeed = s.SerializeObject<Angle>(worldAngularSpeed, name: "worldAngularSpeed");
		}
		public override uint? ClassCRC => 0x49A81091;
	}
}

