using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ProjectileComponent : ActorComponent {
		[Serialize("projectileType")] public ProjectileType projectileType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(projectileType));
		}
		public enum ProjectileType {
			[Serialize("ProjectileType_None"     )] None = 0,
			[Serialize("ProjectileType_RuberDuck")] RuberDuck = 1,
		}
		public override uint? ClassCRC => 0xB5DB6995;
	}
}

