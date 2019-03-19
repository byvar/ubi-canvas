using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventLightSphere : CSerializable {
		[Serialize("sender")] public uint sender;
		[Serialize("active")] public int active;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(active));
		}
		public override uint? ClassCRC => 0xCB943130;
	}
}

