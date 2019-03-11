using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSyncActorUpdate : Event {
		[Serialize("wantFreeze"  )] public bool wantFreeze;
		[Serialize("startAtFrame")] public uint startAtFrame;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(wantFreeze));
			SerializeField(s, nameof(startAtFrame));
		}
		public override uint? ClassCRC => 0x001A132B;
	}
}

