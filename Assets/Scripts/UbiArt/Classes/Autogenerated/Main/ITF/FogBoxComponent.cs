using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class FogBoxComponent : ActorComponent {
		public Vec2d attenuationDist;
		public float near;
		public float far;
		public Color nearColor;
		public Color farColor;
		public bool useNearOffset;
		public float ZWorldCliping;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				attenuationDist = s.SerializeObject<Vec2d>(attenuationDist, name: "attenuationDist");
				near = s.Serialize<float>(near, name: "near");
				far = s.Serialize<float>(far, name: "far");
				nearColor = s.SerializeObject<Color>(nearColor, name: "nearColor");
				farColor = s.SerializeObject<Color>(farColor, name: "farColor");
				useNearOffset = s.Serialize<bool>(useNearOffset, name: "useNearOffset");
				ZWorldCliping = s.Serialize<float>(ZWorldCliping, name: "ZWorldCliping");
			}
		}
		public override uint? ClassCRC => 0xA466E579;
	}
}

