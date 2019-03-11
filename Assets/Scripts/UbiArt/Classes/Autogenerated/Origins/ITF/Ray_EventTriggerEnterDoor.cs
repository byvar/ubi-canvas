using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventTriggerEnterDoor : CSerializable {
		[Serialize("destination")] public uint destination;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(destination));
		}
		public override uint? ClassCRC => 0x32A700B6;
	}
}

