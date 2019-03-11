using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_GameGlobalsJoinDateCondition : online.GameGlobalsCondition {
		[Serialize("date")] public online.DateTime date;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(date));
		}
		public override uint? ClassCRC => 0x7F5698BF;
	}
}

