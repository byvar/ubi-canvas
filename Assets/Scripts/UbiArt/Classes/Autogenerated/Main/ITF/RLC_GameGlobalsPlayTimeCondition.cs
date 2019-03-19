using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_GameGlobalsPlayTimeCondition : online.GameGlobalsCondition {
		[Serialize("duration")] public online.TimeInterval duration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(duration));
		}
		public override uint? ClassCRC => 0xFC121820;
	}
}

