using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_RewardTrigger_Event : CSerializable {
		[Serialize("eventID")] public StringID eventID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(eventID));
		}
		public override uint? ClassCRC => 0xDC301090;
	}
}

