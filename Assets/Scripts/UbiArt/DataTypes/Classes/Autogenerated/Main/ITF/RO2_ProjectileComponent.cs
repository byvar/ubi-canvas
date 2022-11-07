namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_ProjectileComponent : ActorComponent {
		public ProjectileType projectileType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			projectileType = s.Serialize<ProjectileType>(projectileType, name: "projectileType");
		}
		public enum ProjectileType {
			[Serialize("ProjectileType_None"     )] None = 0,
			[Serialize("ProjectileType_RuberDuck")] RuberDuck = 1,
		}
		public override uint? ClassCRC => 0xB5DB6995;
	}
}

