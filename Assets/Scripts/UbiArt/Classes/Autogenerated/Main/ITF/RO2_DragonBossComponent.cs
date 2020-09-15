using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DragonBossComponent : ActorComponent {
		public Enum_mode mode;
		public StringID anim;
		public StringID secondAnim;
		public Vec2d speed;
		public bool showAttackSphere;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				mode = s.Serialize<Enum_mode>(mode, name: "mode");
				anim = s.SerializeObject<StringID>(anim, name: "anim");
				secondAnim = s.SerializeObject<StringID>(secondAnim, name: "secondAnim");
				speed = s.SerializeObject<Vec2d>(speed, name: "speed");
				showAttackSphere = s.Serialize<bool>(showAttackSphere, name: "showAttackSphere");
			}
		}
		public enum Enum_mode {
			[Serialize("apparitions")] apparitions = 0,
			[Serialize("forcedMove" )] forcedMove = 1,
		}
		public override uint? ClassCRC => 0x4CC36D70;
	}
}

