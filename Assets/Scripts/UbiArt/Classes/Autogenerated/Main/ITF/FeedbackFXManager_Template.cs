using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class FeedbackFXManager_Template : TemplateObj {
		[Serialize("soundDescriptors")] public CList<SoundDescriptor_Template> soundDescriptors;
		[Serialize("FxDescriptors"   )] public CList<FxDescriptor_Template> FxDescriptors;
		[Serialize("actors"          )] public CMap<StringID, Target> actors;
		[Serialize("busList"         )] public CList<FeedbackFXManager_Template.buses> busList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(soundDescriptors));
				SerializeField(s, nameof(FxDescriptors));
			} else {
				SerializeField(s, nameof(soundDescriptors));
				SerializeField(s, nameof(FxDescriptors));
				SerializeField(s, nameof(actors));
				SerializeField(s, nameof(busList));
			}
		}
		[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
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

