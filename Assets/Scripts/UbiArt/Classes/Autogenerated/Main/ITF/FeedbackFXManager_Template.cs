using UnityEngine;

namespace UbiArt.ITF {
	public partial class FeedbackFXManager_Template : TemplateObj {
		[Serialize("soundDescriptors")] public CList<SoundDescriptor_Template> soundDescriptors;
		[Serialize("FxDescriptors"   )] public CList<FxDescriptor_Template> FxDescriptors;
		[Serialize("actors"          )] public CMap<StringID, Target> actors;
		[Serialize("busList"         )] public CList<FeedbackFXManager_Template.buses> busList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(soundDescriptors));
			SerializeField(s, nameof(FxDescriptors));
			SerializeField(s, nameof(actors));
			SerializeField(s, nameof(busList));
		}
		public partial class buses : CSerializable {
			[Serialize("actorType")] public StringID actorType;
			[Serialize("bus"      )] public StringID bus;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(actorType));
				SerializeField(s, nameof(bus));
			}
		}
		public override uint? ClassCRC => 0x0918E8D3;
	}
}

