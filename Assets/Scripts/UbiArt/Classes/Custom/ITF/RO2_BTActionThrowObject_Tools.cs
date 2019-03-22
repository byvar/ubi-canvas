using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionThrowObject_Tools : CSerializable {
		[Games(GameFlags.RL | GameFlags.RA)]
		public partial class LaunchData : CSerializable {
			[Serialize("angle"          )] public Angle angle;
			[Serialize("force"          )] public float force;
			[Serialize("gravityModifier")] public float gravityModifier;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(angle));
				SerializeField(s, nameof(force));
				SerializeField(s, nameof(gravityModifier));
			}
		}
	}
}

