using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WaterFloatingPlatformComponent_Template : CSerializable {
		public float stiff;
		public float damp;
		public float weightToAngle;
		public float weightToHeight;
		public Angle maxAngle;
		public float maxHeight;
		public float weightMultiplier;
		public float forceMultiplier;
		public float floatMinHeight;
		public float floatMaxHeight;
		public Angle floatMinAngle;
		public Angle floatMaxAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stiff = s.Serialize<float>(stiff, name: "stiff");
			damp = s.Serialize<float>(damp, name: "damp");
			weightToAngle = s.Serialize<float>(weightToAngle, name: "weightToAngle");
			weightToHeight = s.Serialize<float>(weightToHeight, name: "weightToHeight");
			maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
			maxHeight = s.Serialize<float>(maxHeight, name: "maxHeight");
			weightMultiplier = s.Serialize<float>(weightMultiplier, name: "weightMultiplier");
			forceMultiplier = s.Serialize<float>(forceMultiplier, name: "forceMultiplier");
			floatMinHeight = s.Serialize<float>(floatMinHeight, name: "floatMinHeight");
			floatMaxHeight = s.Serialize<float>(floatMaxHeight, name: "floatMaxHeight");
			floatMinAngle = s.SerializeObject<Angle>(floatMinAngle, name: "floatMinAngle");
			floatMaxAngle = s.SerializeObject<Angle>(floatMaxAngle, name: "floatMaxAngle");
		}
		public override uint? ClassCRC => 0xAC077B8F;
	}
}

