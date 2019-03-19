using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionEnableWorldMap_Template : CSerializable {
		[Serialize("enable")] public bool enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enable), boolAsByte: true);
		}
		public override uint? ClassCRC => 0x8B3590C5;
	}
}

