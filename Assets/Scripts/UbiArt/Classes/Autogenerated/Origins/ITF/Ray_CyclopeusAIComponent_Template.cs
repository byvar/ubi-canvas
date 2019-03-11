using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_CyclopeusAIComponent_Template : Ray_SimpleAIComponent_Template {
		[Serialize("hurtBehavior")] public Placeholder hurtBehavior;
		[Serialize("hitMax"      )] public uint hitMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hurtBehavior));
			SerializeField(s, nameof(hitMax));
		}
		public override uint? ClassCRC => 0xBF9B3E0C;
	}
}

