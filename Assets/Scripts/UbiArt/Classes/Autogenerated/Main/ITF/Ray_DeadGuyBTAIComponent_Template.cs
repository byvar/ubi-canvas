using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_DeadGuyBTAIComponent_Template : BTAIComponent_Template {
		[Serialize("maxTeeth"                )] public uint maxTeeth;
		[Serialize("getTeethSequenceDistance")] public float getTeethSequenceDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maxTeeth));
			SerializeField(s, nameof(getTeethSequenceDistance));
		}
		public override uint? ClassCRC => 0x7F67FAC7;
	}
}

