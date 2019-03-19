using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class EventPlaySound : CSerializable {
		[Serialize("sender"                 )] public uint sender;
		[Serialize("soundDescriptorTemplate")] public Placeholder soundDescriptorTemplate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(soundDescriptorTemplate));
		}
		public override uint? ClassCRC => 0xC1B94CB3;
	}
}

