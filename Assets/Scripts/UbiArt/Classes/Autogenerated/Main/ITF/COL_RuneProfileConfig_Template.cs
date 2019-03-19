using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_RuneProfileConfig_Template : CSerializable {
		[Serialize("runeBagSize")] public uint runeBagSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(runeBagSize));
		}
		public override uint? ClassCRC => 0x5CA69E72;
	}
}

