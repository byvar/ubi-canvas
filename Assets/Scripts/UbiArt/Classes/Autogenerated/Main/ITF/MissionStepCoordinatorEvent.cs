using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepCoordinatorEvent : CSerializable {
		[Serialize("sender"   )] public uint sender;
		[Serialize("completed")] public int completed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(completed));
		}
		public override uint? ClassCRC => 0xB60A591F;
	}
}

