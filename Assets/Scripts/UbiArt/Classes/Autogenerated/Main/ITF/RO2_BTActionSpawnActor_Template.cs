using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionSpawnActor_Template : BTAction_Template {
		public Path ActorPath;
		public Vec2d Offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ActorPath = s.SerializeObject<Path>(ActorPath, name: "ActorPath");
			Offset = s.SerializeObject<Vec2d>(Offset, name: "Offset");
		}
		public override uint? ClassCRC => 0x25E52449;
	}
}

