using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventIsInfluencedByVacuum : Event {
		[Serialize("influenced")] public int influenced;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(influenced));
		}
		public override uint? ClassCRC => 0x74BE6E32;
	}
}

