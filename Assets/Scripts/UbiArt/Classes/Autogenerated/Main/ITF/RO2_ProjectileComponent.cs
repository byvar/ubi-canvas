using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ProjectileComponent : ActorComponent {
		[Serialize("projectileType")] public ProjectileType projectileType;
		[Serialize("projectileType")] public Enum_projectileType projectileType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(projectileType));
			} else {
				SerializeField(s, nameof(projectileType));
			}
		}
		public enum ProjectileType {
			[Serialize("ProjectileType_None"     )] None = 0,
			[Serialize("ProjectileType_RuberDuck")] RuberDuck = 1,
		}
		public enum Enum_projectileType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0xB5DB6995;
	}
}

