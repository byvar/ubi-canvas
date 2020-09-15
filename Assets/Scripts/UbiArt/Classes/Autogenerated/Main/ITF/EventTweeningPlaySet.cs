using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class EventTweeningPlaySet : Event {
		public bool autoIncrement;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			autoIncrement = s.Serialize<bool>(autoIncrement, name: "autoIncrement", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0xBCBF0922;
	}
}

