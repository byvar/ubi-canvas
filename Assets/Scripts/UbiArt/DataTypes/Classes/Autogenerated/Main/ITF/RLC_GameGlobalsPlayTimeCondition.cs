using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_GameGlobalsPlayTimeCondition : online.GameGlobalsCondition {
		public online.TimeInterval duration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			duration = s.SerializeObject<online.TimeInterval>(duration, name: "duration");
		}
		public override uint? ClassCRC => 0xFC121820;
	}
}

