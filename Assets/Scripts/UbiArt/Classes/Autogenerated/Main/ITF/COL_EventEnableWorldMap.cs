using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventEnableWorldMap : Event {
		public bool enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enable = s.Serialize<bool>(enable, name: "enable", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x69E8820D;
	}
}

