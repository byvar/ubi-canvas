namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_DRCMandatoryZoneComponent_Template : ActorComponent_Template {
		public int enter;
		public Generic<Event> hi5Event;
		public int autoMurphy;
		public int autoMurphyMultiAllowed;
		public CListO<Generic<Event>> AMSoundEventList;
		public CListO<StringID> AMSoundMapList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enter = s.Serialize<int>(enter, name: "enter");
			hi5Event = s.SerializeObject<Generic<Event>>(hi5Event, name: "hi5Event");
			if (s.Settings.platform != Settings.Platform.Vita) {
				autoMurphy = s.Serialize<int>(autoMurphy, name: "autoMurphy");
				autoMurphyMultiAllowed = s.Serialize<int>(autoMurphyMultiAllowed, name: "autoMurphyMultiAllowed");
				AMSoundEventList = s.SerializeObject<CListO<Generic<Event>>>(AMSoundEventList, name: "AMSoundEventList");
				AMSoundMapList = s.SerializeObject<CListO<StringID>>(AMSoundMapList, name: "AMSoundMapList");
			}
		}
		public override uint? ClassCRC => 0x68D44447;
	}
}

