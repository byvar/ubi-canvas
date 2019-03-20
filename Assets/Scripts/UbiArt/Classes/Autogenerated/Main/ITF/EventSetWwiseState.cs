using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL)]
	public partial class EventSetWwiseState : Event {
		[Serialize("WwiseStateGroupGUID")] public StringID WwiseStateGroupGUID;
		[Serialize("WwiseStateGUID"     )] public StringID WwiseStateGUID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(WwiseStateGroupGUID));
			SerializeField(s, nameof(WwiseStateGUID));
		}
		public override uint? ClassCRC => 0xC7DCAC11;
	}
}

