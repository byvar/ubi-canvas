using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_438_sub_B68260 : CSerializable {
		public float depth;
		public Vec2d screenBorderScale;
		public float moveDirBlendFactor;
		public float moveSpeed;
		public float moveDestDeltaDist;
		public float moveEjectSpeed;
		public float moveEjectAbsorptionBlendFactor;
		public StringID animBurst;
		public StringID appearRumbleID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			depth = s.Serialize<float>(depth, name: "depth");
			screenBorderScale = s.SerializeObject<Vec2d>(screenBorderScale, name: "screenBorderScale");
			moveDirBlendFactor = s.Serialize<float>(moveDirBlendFactor, name: "moveDirBlendFactor");
			moveSpeed = s.Serialize<float>(moveSpeed, name: "moveSpeed");
			moveDestDeltaDist = s.Serialize<float>(moveDestDeltaDist, name: "moveDestDeltaDist");
			moveEjectSpeed = s.Serialize<float>(moveEjectSpeed, name: "moveEjectSpeed");
			moveEjectAbsorptionBlendFactor = s.Serialize<float>(moveEjectAbsorptionBlendFactor, name: "moveEjectAbsorptionBlendFactor");
			animBurst = s.SerializeObject<StringID>(animBurst, name: "animBurst");
			appearRumbleID = s.SerializeObject<StringID>(appearRumbleID, name: "appearRumbleID");
		}
		public override uint? ClassCRC => 0x5A6A3AB9;
	}
}

