using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_GameGlobalsCreatureCountCondition : online.GameGlobalsCondition {
		[Serialize("count")] public uint count;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(count));
		}
		public override uint? ClassCRC => 0x0EF97764;
	}
}

