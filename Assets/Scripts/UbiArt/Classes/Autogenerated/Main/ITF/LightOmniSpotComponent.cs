using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class LightOmniSpotComponent : CSerializable {
		public Color LightCol;
		public float Near;
		public float Far;
		public Vec3d SpotDir;
		public float SpotLittleAngle;
		public float SpotBigAngle;
		public float LightColMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				LightCol = s.SerializeObject<Color>(LightCol, name: "LightCol");
				Near = s.Serialize<float>(Near, name: "Near");
				Far = s.Serialize<float>(Far, name: "Far");
				SpotDir = s.SerializeObject<Vec3d>(SpotDir, name: "SpotDir");
				SpotLittleAngle = s.Serialize<float>(SpotLittleAngle, name: "SpotLittleAngle");
				SpotBigAngle = s.Serialize<float>(SpotBigAngle, name: "SpotBigAngle");
				LightColMultiplier = s.Serialize<float>(LightColMultiplier, name: "LightColMultiplier");
			}
		}
		public override uint? ClassCRC => 0xD5327F8A;
	}
}

