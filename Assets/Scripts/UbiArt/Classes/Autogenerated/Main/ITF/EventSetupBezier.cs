using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.COL)]
	public partial class EventSetupBezier : CSerializable {
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
		}
		public override uint? ClassCRC => 0x2A8EAB91;
	}
}

