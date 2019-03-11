using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_GameGlobalsCreatureIdCondition : online.GameGlobalsCondition {
		[Serialize("creature")] public StringID creature;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(creature));
		}
		public override uint? ClassCRC => 0xA05E6782;
	}
}

