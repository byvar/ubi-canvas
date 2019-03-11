using UnityEngine;

namespace UbiArt.ITF {
	public partial class DialogSoundDescriptorComponent_Template : ActorComponent_Template {
		[Serialize("DescriptorList")] public CList<DialogSoundDescriptorElement> DescriptorList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DescriptorList));
		}
		public override uint? ClassCRC => 0xD4B2FEBB;
	}
}

