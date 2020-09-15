using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class FeedbackFXManager_Template : TemplateObj {
		public CList<SoundDescriptor_Template> soundDescriptors;
		public CList<FxDescriptor_Template> FxDescriptors;
		public CMap<StringID, Target> actors;
		public CList<FeedbackFXManager_Template.buses> busList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				soundDescriptors = s.SerializeObject<CList<SoundDescriptor_Template>>(soundDescriptors, name: "soundDescriptors");
				FxDescriptors = s.SerializeObject<CList<FxDescriptor_Template>>(FxDescriptors, name: "FxDescriptors");
			} else {
				soundDescriptors = s.SerializeObject<CList<SoundDescriptor_Template>>(soundDescriptors, name: "soundDescriptors");
				FxDescriptors = s.SerializeObject<CList<FxDescriptor_Template>>(FxDescriptors, name: "FxDescriptors");
				actors = s.SerializeObject<CMap<StringID, Target>>(actors, name: "actors");
				busList = s.SerializeObject<CList<FeedbackFXManager_Template.buses>>(busList, name: "busList");
			}
		}
		[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
		public partial class buses : CSerializable {
			public StringID actorType;
			public StringID bus;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				actorType = s.SerializeObject<StringID>(actorType, name: "actorType");
				bus = s.SerializeObject<StringID>(bus, name: "bus");
			}
		}
		public override uint? ClassCRC => 0x0918E8D3;
	}
}

