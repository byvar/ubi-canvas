using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BossBirdPawnAIComponent_Template : CSerializable {
		[Serialize("faction"     )] public uint faction;
		[Serialize("gravity"     )] public float gravity;
		[Serialize("scale"       )] public float scale;
		[Serialize("xMax"        )] public float xMax;
		[Serialize("lifeDuration")] public float lifeDuration;
		[Serialize("yGround"     )] public float yGround;
		[Serialize("initSpeed"   )] public Vector2 initSpeed;
		[Serialize("speedRand"   )] public float speedRand;
		[Serialize("rotation"    )] public float rotation;
		[Serialize("xBreakFactor")] public float xBreakFactor;
		[Serialize("deathAnim"   )] public StringID deathAnim;
		[Serialize("hitSpeed"    )] public float hitSpeed;
		[Serialize("nbRewards"   )] public uint nbRewards;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(gravity));
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(xMax));
			SerializeField(s, nameof(lifeDuration));
			SerializeField(s, nameof(yGround));
			SerializeField(s, nameof(initSpeed));
			SerializeField(s, nameof(speedRand));
			SerializeField(s, nameof(rotation));
			SerializeField(s, nameof(xBreakFactor));
			SerializeField(s, nameof(deathAnim));
			SerializeField(s, nameof(hitSpeed));
			SerializeField(s, nameof(nbRewards));
		}
		public override uint? ClassCRC => 0x0579472C;
	}
}

