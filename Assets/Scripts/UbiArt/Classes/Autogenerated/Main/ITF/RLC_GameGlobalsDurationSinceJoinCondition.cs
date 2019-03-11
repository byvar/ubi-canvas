using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_GameGlobalsDurationSinceJoinCondition : online.GameGlobalsCondition {
		[Serialize("duration")] public online.TimeInterval duration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(duration));
		}
		public override uint? ClassCRC => 0xD64891C8;
	}
}

