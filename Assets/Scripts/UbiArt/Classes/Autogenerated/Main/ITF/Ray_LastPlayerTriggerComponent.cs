using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_LastPlayerTriggerComponent : TriggerComponent {
		[Serialize("timeBeforeActivation")] public float timeBeforeActivation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timeBeforeActivation));
		}
		public override uint? ClassCRC => 0x74794E3B;
	}
}

