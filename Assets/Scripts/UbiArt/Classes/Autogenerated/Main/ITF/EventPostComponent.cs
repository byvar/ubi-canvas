using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventPostComponent : Event {
		[Serialize("componentID")] public uint componentID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(componentID));
		}
		public override uint? ClassCRC => 0x88EACC5A;
	}
}

