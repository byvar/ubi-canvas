using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DoorComponent_Template : ActorComponent_Template {
		[Serialize("startOpen")] public bool startOpen;
		[Serialize("openSpeed")] public float openSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startOpen));
			SerializeField(s, nameof(openSpeed));
		}
		public override uint? ClassCRC => 0xA84FB414;
	}
}

