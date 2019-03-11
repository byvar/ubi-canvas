using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_OnlineEventNewScore : Event {
		[Serialize("newScore")] public char newScore;
		[Serialize("teamID"  )] public char teamID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(newScore));
			SerializeField(s, nameof(teamID));
		}
		public override uint? ClassCRC => 0x48919D85;
	}
}

