using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_436_sub_B68190 : ActorComponent_Template {
		public int enter;
		public Generic<Event> hi5Event;
		public int autoMurphy;
		public int autoMurphyMultiAllowed;
		public CList<Generic<Event>> AMSoundEventList;
		public CList<StringID> AMSoundMapList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enter = s.Serialize<int>(enter, name: "enter");
			hi5Event = s.SerializeObject<Generic<Event>>(hi5Event, name: "hi5Event");
			autoMurphy = s.Serialize<int>(autoMurphy, name: "autoMurphy");
			autoMurphyMultiAllowed = s.Serialize<int>(autoMurphyMultiAllowed, name: "autoMurphyMultiAllowed");
			AMSoundEventList = s.SerializeObject<CList<Generic<Event>>>(AMSoundEventList, name: "AMSoundEventList");
			AMSoundMapList = s.SerializeObject<CList<StringID>>(AMSoundMapList, name: "AMSoundMapList");
		}
		public override uint? ClassCRC => 0x68D44447;
	}
}

