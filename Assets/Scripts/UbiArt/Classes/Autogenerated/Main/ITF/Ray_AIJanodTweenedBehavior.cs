using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIJanodTweenedBehavior : CSerializable {
		[Serialize("Idle")] public Placeholder Idle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Idle));
		}
		public override uint? ClassCRC => 0xE3016D1B;
	}
}

