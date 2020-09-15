using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventIsInfluencedByVacuum : Event {
		public int influenced;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			influenced = s.Serialize<int>(influenced, name: "influenced");
		}
		public override uint? ClassCRC => 0x74BE6E32;
	}
}

