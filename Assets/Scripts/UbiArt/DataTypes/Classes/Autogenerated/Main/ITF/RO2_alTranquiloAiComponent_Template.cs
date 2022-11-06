using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_alTranquiloAiComponent_Template : AIComponent_Template {
		public StringID idleAnim;
		public StringID squashedAnim;
		public StringID staySquashedAnim;
		public float staySquashedTime;
		public bool autoBounce;
		public Vec2d bouncePos;
		public bool isMini;
		public Path bubblePath;
		public StringID spawnBone;
		public float respawnTime;
		public Angle bounceAngle;
		public Enum_bounceType bounceType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
			squashedAnim = s.SerializeObject<StringID>(squashedAnim, name: "squashedAnim");
			staySquashedAnim = s.SerializeObject<StringID>(staySquashedAnim, name: "staySquashedAnim");
			staySquashedTime = s.Serialize<float>(staySquashedTime, name: "staySquashedTime");
			autoBounce = s.Serialize<bool>(autoBounce, name: "autoBounce");
			bouncePos = s.SerializeObject<Vec2d>(bouncePos, name: "bouncePos");
			isMini = s.Serialize<bool>(isMini, name: "isMini");
			bubblePath = s.SerializeObject<Path>(bubblePath, name: "bubblePath");
			spawnBone = s.SerializeObject<StringID>(spawnBone, name: "spawnBone");
			respawnTime = s.Serialize<float>(respawnTime, name: "respawnTime");
			bounceAngle = s.SerializeObject<Angle>(bounceAngle, name: "bounceAngle");
			bounceType = s.Serialize<Enum_bounceType>(bounceType, name: "bounceType");
		}
		public enum Enum_bounceType {
		}
		public override uint? ClassCRC => 0x218CEF1A;
	}
}

