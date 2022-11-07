namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_alTranquiloAiComponent_Template : AIComponent_Template {
		public StringID idleAnim;
		public StringID squashedAnim;
		public StringID staySquashedAnim;
		public float staySquashedTime;
		public int autoBounce;
		public Vec2d bouncePos;
		public int isMini;
		public Path bubblePath;
		public StringID spawnBone;
		public float respawnTime;
		public Angle bounceAngle;
		public Enum_RFR_0 bounceType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
			squashedAnim = s.SerializeObject<StringID>(squashedAnim, name: "squashedAnim");
			staySquashedAnim = s.SerializeObject<StringID>(staySquashedAnim, name: "staySquashedAnim");
			staySquashedTime = s.Serialize<float>(staySquashedTime, name: "staySquashedTime");
			autoBounce = s.Serialize<int>(autoBounce, name: "autoBounce");
			bouncePos = s.SerializeObject<Vec2d>(bouncePos, name: "bouncePos");
			isMini = s.Serialize<int>(isMini, name: "isMini");
			bubblePath = s.SerializeObject<Path>(bubblePath, name: "bubblePath");
			spawnBone = s.SerializeObject<StringID>(spawnBone, name: "spawnBone");
			respawnTime = s.Serialize<float>(respawnTime, name: "respawnTime");
			bounceAngle = s.SerializeObject<Angle>(bounceAngle, name: "bounceAngle");
			bounceType = s.Serialize<Enum_RFR_0>(bounceType, name: "bounceType");
		}
		public enum Enum_RFR_0 {
		}
		public override uint? ClassCRC => 0xBD71F231;
	}
}

