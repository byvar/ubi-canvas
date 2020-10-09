using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SpecificBounceComponent : ActorComponent {
		public Angle angle;
		public Angle angleDelta;
		public float multiplierMin;
		public float multiplierMax;
		public float multiplierDistMin;
		public float multiplierDistMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			angle = s.SerializeObject<Angle>(angle, name: "angle");
			angleDelta = s.SerializeObject<Angle>(angleDelta, name: "angleDelta");
			multiplierMin = s.Serialize<float>(multiplierMin, name: "multiplierMin");
			multiplierMax = s.Serialize<float>(multiplierMax, name: "multiplierMax");
			multiplierDistMin = s.Serialize<float>(multiplierDistMin, name: "multiplierDistMin");
			multiplierDistMax = s.Serialize<float>(multiplierDistMax, name: "multiplierDistMax");
		}
		public override uint? ClassCRC => 0x2B4C0A42;
	}
}

