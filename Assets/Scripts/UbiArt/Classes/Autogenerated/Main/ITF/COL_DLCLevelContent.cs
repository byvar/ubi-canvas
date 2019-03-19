using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCLevelContent : CSerializable {
		[Serialize("map")] public string map;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(map));
		}
		public override uint? ClassCRC => 0xDAE24836;
	}
}

