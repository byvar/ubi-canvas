using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_BasicAdventureButton : ActorComponent {
		[Serialize("LockChildrenTutoStepString")] public string LockChildrenTutoStepString;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(LockChildrenTutoStepString));
		}
		public override uint? ClassCRC => 0xB410E499;
	}
}

