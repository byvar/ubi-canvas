using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class EventPlaySound : Event {
		[Serialize("soundDescriptorTemplate")] public SoundDescriptor_Template soundDescriptorTemplate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(soundDescriptorTemplate));
		}
		public override uint? ClassCRC => 0xC1B94CB3;
	}
}

