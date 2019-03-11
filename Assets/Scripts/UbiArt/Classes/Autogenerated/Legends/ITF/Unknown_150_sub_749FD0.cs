using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_150_sub_749FD0 : CSerializable {
		[Serialize("pendingFriendText")] public Placeholder pendingFriendText;
		[Serialize("addFriendText"    )] public Placeholder addFriendText;
		[Serialize("cupPulseScale"    )] public float cupPulseScale;
		[Serialize("cupPulsePeriod"   )] public float cupPulsePeriod;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pendingFriendText));
			SerializeField(s, nameof(addFriendText));
			SerializeField(s, nameof(cupPulseScale));
			SerializeField(s, nameof(cupPulsePeriod));
		}
		public override uint? ClassCRC => 0x590A7A5D;
	}
}

