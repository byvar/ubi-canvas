using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_432_sub_B56840 : ActorComponent {
		[Serialize("rotatingPlatformPositionSmooth")] public Unknown_RL_45756_sub_B55B80 rotatingPlatformPositionSmooth;
		[Serialize("rotatingPlatformAngleSmooth"   )] public Unknown_RL_45757_sub_B55C30 rotatingPlatformAngleSmooth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rotatingPlatformPositionSmooth));
			SerializeField(s, nameof(rotatingPlatformAngleSmooth));
		}
		public override uint? ClassCRC => 0xD8A100C4;

		[Games(GameFlags.RL)]
		public partial class Unknown_RL_45756_sub_B55B80 : CSerializable {
			[Serialize("midBlendFactor")] public float midBlendFactor; // Serialized as Vec2d, but okay
			[Serialize("blendFactor"   )] public float blendFactor;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(midBlendFactor));
				SerializeField(s, nameof(blendFactor));
			}
		}

		[Games(GameFlags.RL)]
		public partial class Unknown_RL_45757_sub_B55C30 : CSerializable {
			[Serialize("midBlendFactor")] public float midBlendFactor;
			[Serialize("blendFactor"   )] public float blendFactor;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(midBlendFactor));
				SerializeField(s, nameof(blendFactor));
			}
		}
	}
}

