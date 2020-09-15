using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionThrowObject_Tools : CSerializable {
		[Games(GameFlags.RL | GameFlags.RA)]
		public partial class LaunchData : CSerializable {
			public Angle angle;
			public float force;
			public float gravityModifier;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				angle = s.SerializeObject<Angle>(angle, name: "angle");
				force = s.Serialize<float>(force, name: "force");
				gravityModifier = s.Serialize<float>(gravityModifier, name: "gravityModifier");
			}
		}
	}
}

