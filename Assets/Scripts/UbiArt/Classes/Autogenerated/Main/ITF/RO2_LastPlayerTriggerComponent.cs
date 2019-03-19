using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LastPlayerTriggerComponent : TriggerComponent {
		[Serialize("timeBeforeActivation")] public float timeBeforeActivation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timeBeforeActivation));
		}
		public override uint? ClassCRC => 0x2ABCD46D;
	}
}

