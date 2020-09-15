using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BossBirdPawnAIComponent_Template : CSerializable {
		public uint faction;
		public float gravity;
		public float scale;
		public float xMax;
		public float lifeDuration;
		public float yGround;
		public Vec2d initSpeed;
		public float speedRand;
		public float rotation;
		public float xBreakFactor;
		public StringID deathAnim;
		public float hitSpeed;
		public uint nbRewards;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			faction = s.Serialize<uint>(faction, name: "faction");
			gravity = s.Serialize<float>(gravity, name: "gravity");
			scale = s.Serialize<float>(scale, name: "scale");
			xMax = s.Serialize<float>(xMax, name: "xMax");
			lifeDuration = s.Serialize<float>(lifeDuration, name: "lifeDuration");
			yGround = s.Serialize<float>(yGround, name: "yGround");
			initSpeed = s.SerializeObject<Vec2d>(initSpeed, name: "initSpeed");
			speedRand = s.Serialize<float>(speedRand, name: "speedRand");
			rotation = s.Serialize<float>(rotation, name: "rotation");
			xBreakFactor = s.Serialize<float>(xBreakFactor, name: "xBreakFactor");
			deathAnim = s.SerializeObject<StringID>(deathAnim, name: "deathAnim");
			hitSpeed = s.Serialize<float>(hitSpeed, name: "hitSpeed");
			nbRewards = s.Serialize<uint>(nbRewards, name: "nbRewards");
		}
		public override uint? ClassCRC => 0x0579472C;
	}
}

