using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_OnlineEventTeamAllocation : Event {
		[Serialize("playerOnlineID")] public uint playerOnlineID;
		[Serialize("teamID"        )] public char teamID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playerOnlineID));
			SerializeField(s, nameof(teamID));
		}
		public override uint? ClassCRC => 0x3F76C504;
	}
}

