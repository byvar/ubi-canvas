using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventStoneManLaunch : Event {
		[Serialize("actionIndex")] public uint actionIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actionIndex));
		}
		public override uint? ClassCRC => 0xDDDAD568;
	}
}

