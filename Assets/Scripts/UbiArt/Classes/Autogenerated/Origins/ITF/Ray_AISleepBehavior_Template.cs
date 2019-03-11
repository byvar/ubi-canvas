using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AISleepBehavior_Template : BlendTreeNodeTemplate<AnimTreeResult> {
		[Serialize("idle"             )] public Placeholder idle;
		[Serialize("wakeUp"           )] public Placeholder wakeUp;
		[Serialize("deactivatePhysics")] public bool deactivatePhysics;
		[Serialize("wakeUpOnTrigger"  )] public bool wakeUpOnTrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(wakeUp));
			SerializeField(s, nameof(deactivatePhysics));
			SerializeField(s, nameof(wakeUpOnTrigger));
		}
		public override uint? ClassCRC => 0xD9DEB640;
	}
}

