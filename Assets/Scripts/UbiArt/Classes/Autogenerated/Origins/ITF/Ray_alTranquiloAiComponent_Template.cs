using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_alTranquiloAiComponent_Template : AIComponent_Template {
		[Serialize("idleAnim"        )] public StringID idleAnim;
		[Serialize("squashedAnim"    )] public StringID squashedAnim;
		[Serialize("staySquashedAnim")] public StringID staySquashedAnim;
		[Serialize("staySquashedTime")] public float staySquashedTime;
		[Serialize("autoBounce"      )] public bool autoBounce;
		[Serialize("bouncePos"       )] public Vector2 bouncePos;
		[Serialize("isMini"          )] public bool isMini;
		[Serialize("bubblePath"      )] public Path bubblePath;
		[Serialize("spawnBone"       )] public StringID spawnBone;
		[Serialize("respawnTime"     )] public float respawnTime;
		[Serialize("bounceAngle"     )] public Angle bounceAngle;
		[Serialize("bounceType"      )] public Enum_bounceType bounceType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idleAnim));
			SerializeField(s, nameof(squashedAnim));
			SerializeField(s, nameof(staySquashedAnim));
			SerializeField(s, nameof(staySquashedTime));
			SerializeField(s, nameof(autoBounce));
			SerializeField(s, nameof(bouncePos));
			SerializeField(s, nameof(isMini));
			SerializeField(s, nameof(bubblePath));
			SerializeField(s, nameof(spawnBone));
			SerializeField(s, nameof(respawnTime));
			SerializeField(s, nameof(bounceAngle));
			SerializeField(s, nameof(bounceType));
		}
		public enum Enum_bounceType {
		}
		public override uint? ClassCRC => 0xBD71F231;
	}
}

