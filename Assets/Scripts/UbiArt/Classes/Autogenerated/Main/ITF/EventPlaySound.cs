using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class EventPlaySound : Event {
		public SoundDescriptor_Template soundDescriptorTemplate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			soundDescriptorTemplate = s.SerializeObject<SoundDescriptor_Template>(soundDescriptorTemplate, name: "soundDescriptorTemplate");
		}
		public override uint? ClassCRC => 0x72C1B820;
	}
}

