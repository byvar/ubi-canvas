namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_432_sub_B56840 : ActorComponent {
		public Unknown_RL_45756_sub_B55B80 rotatingPlatformPositionSmooth;
		public Unknown_RL_45757_sub_B55C30 rotatingPlatformAngleSmooth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			rotatingPlatformPositionSmooth = s.SerializeObject<Unknown_RL_45756_sub_B55B80>(rotatingPlatformPositionSmooth, name: "rotatingPlatformPositionSmooth");
			rotatingPlatformAngleSmooth = s.SerializeObject<Unknown_RL_45757_sub_B55C30>(rotatingPlatformAngleSmooth, name: "rotatingPlatformAngleSmooth");
		}
		public override uint? ClassCRC => 0xD8A100C4;

		[Games(GameFlags.RL)]
		public partial class Unknown_RL_45756_sub_B55B80 : CSerializable {
			public float midBlendFactor; // Serialized as Vec2d, but okay
			public float blendFactor;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				midBlendFactor = s.Serialize<float>(midBlendFactor, name: "midBlendFactor");
				blendFactor = s.Serialize<float>(blendFactor, name: "blendFactor");
			}
		}

		[Games(GameFlags.RL)]
		public partial class Unknown_RL_45757_sub_B55C30 : CSerializable {
			public float midBlendFactor;
			public float blendFactor;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				midBlendFactor = s.Serialize<float>(midBlendFactor, name: "midBlendFactor");
				blendFactor = s.Serialize<float>(blendFactor, name: "blendFactor");
			}
		}
	}
}

