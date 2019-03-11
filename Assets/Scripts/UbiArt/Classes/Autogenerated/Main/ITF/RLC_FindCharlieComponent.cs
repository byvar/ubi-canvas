using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_FindCharlieComponent : ActorComponent {
		[Serialize("ForcedVariant")] public int ForcedVariant;
		[Serialize("isTutorial"   )] public bool isTutorial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ForcedVariant));
			SerializeField(s, nameof(isTutorial));
		}
		public override uint? ClassCRC => 0xBA21C73A;
	}
}

