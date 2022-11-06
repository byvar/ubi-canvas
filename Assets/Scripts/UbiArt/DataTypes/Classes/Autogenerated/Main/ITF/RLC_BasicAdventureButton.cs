using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_BasicAdventureButton : ActorComponent {
		public string LockChildrenTutoStepString;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			LockChildrenTutoStepString = s.Serialize<string>(LockChildrenTutoStepString, name: "LockChildrenTutoStepString");
		}
		public override uint? ClassCRC => 0xB410E499;
	}
}

