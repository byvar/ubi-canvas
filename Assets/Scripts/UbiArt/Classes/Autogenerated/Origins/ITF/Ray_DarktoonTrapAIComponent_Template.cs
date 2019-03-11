using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_DarktoonTrapAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("holePath"          )] public Path holePath;
		[Serialize("holeOffset"        )] public Vector3 holeOffset;
		[Serialize("trapBehavior"      )] public Placeholder trapBehavior;
		[Serialize("receiveHitBehavior")] public Placeholder receiveHitBehavior;
		[Serialize("deathBehavior"     )] public Placeholder deathBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(holePath));
			SerializeField(s, nameof(holeOffset));
			SerializeField(s, nameof(trapBehavior));
			SerializeField(s, nameof(receiveHitBehavior));
			SerializeField(s, nameof(deathBehavior));
		}
		public override uint? ClassCRC => 0xD72D2A85;
	}
}

