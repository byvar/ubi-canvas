using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LeverComponent_Template : CSerializable {
		[Serialize("animDuration")] public float animDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animDuration));
		}
		public override uint? ClassCRC => 0x804284F3;
	}
}

