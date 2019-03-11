using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventDarkCreatureVisionActivation : Event {
		[Serialize("DetectionDistance")] public float DetectionDistance;
		[Serialize("AttackDistance"   )] public float AttackDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DetectionDistance));
			SerializeField(s, nameof(AttackDistance));
		}
		public override uint? ClassCRC => 0xE63E044A;
	}
}

