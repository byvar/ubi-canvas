using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class EventTweeningPlaySet : CSerializable {
		[Serialize("sender"       )] public uint sender;
		[Serialize("autoIncrement")] public bool autoIncrement;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(autoIncrement), boolAsByte: true);
		}
		public override uint? ClassCRC => 0xBCBF0922;
	}
}

