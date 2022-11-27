namespace UbiArt.ITF {
	public partial class RO2_BTActionThrowObject_Tools : CSerializable {
		[Games(GameFlags.RL | GameFlags.RA)]
		public partial class LaunchData : CSerializable {
			public Angle angle = 0.5235988f;
			public float force = 30f;
			public float gravityModifier = 1f;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				angle = s.SerializeObject<Angle>(angle, name: "angle");
				force = s.Serialize<float>(force, name: "force");
				gravityModifier = s.Serialize<float>(gravityModifier, name: "gravityModifier");
			}
		}
	}
}

