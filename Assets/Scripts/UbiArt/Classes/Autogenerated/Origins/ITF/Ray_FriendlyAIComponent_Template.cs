using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_FriendlyAIComponent_Template : Ray_GroundAIComponent_Template {
		[Serialize("waitBehavior"        )] public Placeholder waitBehavior;
		[Serialize("triggerBehavior"     )] public Placeholder triggerBehavior;
		[Serialize("exitBehavior"        )] public Placeholder exitBehavior;
		[Serialize("pedestalBehavior"    )] public Placeholder pedestalBehavior;
		[Serialize("jumpBehavior"        )] public Placeholder jumpBehavior;
		[Serialize("gotoBehavior"        )] public Placeholder gotoBehavior;
		[Serialize("followBehavior"      )] public Placeholder followBehavior;
		[Serialize("danceBehavior"       )] public Placeholder danceBehavior;
		[Serialize("followDetectDistance")] public float followDetectDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(waitBehavior));
			SerializeField(s, nameof(triggerBehavior));
			SerializeField(s, nameof(exitBehavior));
			SerializeField(s, nameof(pedestalBehavior));
			SerializeField(s, nameof(jumpBehavior));
			SerializeField(s, nameof(gotoBehavior));
			SerializeField(s, nameof(followBehavior));
			SerializeField(s, nameof(danceBehavior));
			SerializeField(s, nameof(followDetectDistance));
		}
		public override uint? ClassCRC => 0x246AC14F;
	}
}

