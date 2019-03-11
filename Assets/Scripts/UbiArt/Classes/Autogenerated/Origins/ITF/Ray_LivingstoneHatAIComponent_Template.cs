using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_LivingstoneHatAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("roamBehavior"    )] public Placeholder roamBehavior;
		[Serialize("floatingBehavior")] public Placeholder floatingBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(roamBehavior));
			SerializeField(s, nameof(floatingBehavior));
		}
		public override uint? ClassCRC => 0x86C46ABD;
	}
}

