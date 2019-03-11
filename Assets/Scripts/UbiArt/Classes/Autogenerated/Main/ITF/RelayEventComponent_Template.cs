using UnityEngine;

namespace UbiArt.ITF {
	public partial class RelayEventComponent_Template : ActorComponent_Template {
		[Serialize("relays")] public CList<RelayData> relays;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(relays));
		}
		public override uint? ClassCRC => 0x060B7DC1;
	}
}

