namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class FeedbackFXManager_Template : TemplateObj {
		public CListO<SoundDescriptor_Template> soundDescriptors;
		public CListO<FxDescriptor_Template> FxDescriptors;
		public CMap<StringID, Target> actors;
		public CListO<FeedbackFXManager_Template.buses> busList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				soundDescriptors = s.SerializeObject<CListO<SoundDescriptor_Template>>(soundDescriptors, name: "soundDescriptors");
				FxDescriptors = s.SerializeObject<CListO<FxDescriptor_Template>>(FxDescriptors, name: "FxDescriptors");
			} else {
				soundDescriptors = s.SerializeObject<CListO<SoundDescriptor_Template>>(soundDescriptors, name: "soundDescriptors");
				FxDescriptors = s.SerializeObject<CListO<FxDescriptor_Template>>(FxDescriptors, name: "FxDescriptors");
				actors = s.SerializeObject<CMap<StringID, Target>>(actors, name: "actors");
				busList = s.SerializeObject<CListO<FeedbackFXManager_Template.buses>>(busList, name: "busList");
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
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

