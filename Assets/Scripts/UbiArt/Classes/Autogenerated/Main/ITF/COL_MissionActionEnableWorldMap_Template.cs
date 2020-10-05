using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionEnableWorldMap_Template : CSerializable {
		public bool enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enable = s.Serialize<bool>(enable, name: "enable", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x7499D2C0;
	}
}

