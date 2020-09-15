using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventStoneManLaunch : Event {
		public uint actionIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actionIndex = s.Serialize<uint>(actionIndex, name: "actionIndex");
		}
		public override uint? ClassCRC => 0xDDDAD568;
	}
}

