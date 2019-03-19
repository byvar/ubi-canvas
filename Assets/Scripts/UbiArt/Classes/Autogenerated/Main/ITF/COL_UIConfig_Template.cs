using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_UIConfig_Template : CSerializable {
		[Serialize("isDLCData")] public int isDLCData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isDLCData));
		}
		public override uint? ClassCRC => 0x287853D1;
	}
}

