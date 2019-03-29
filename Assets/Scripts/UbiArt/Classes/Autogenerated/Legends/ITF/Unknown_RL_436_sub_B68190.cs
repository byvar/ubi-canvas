using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_436_sub_B68190 : ActorComponent_Template {
		[Serialize("enter"                 )] public int enter;
		[Serialize("hi5Event"              )] public Generic<Event> hi5Event;
		[Serialize("autoMurphy"            )] public int autoMurphy;
		[Serialize("autoMurphyMultiAllowed")] public int autoMurphyMultiAllowed;
		[Serialize("AMSoundEventList"      )] public CList<Generic<Event>> AMSoundEventList;
		[Serialize("AMSoundMapList"        )] public CList<StringID> AMSoundMapList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enter));
			SerializeField(s, nameof(hi5Event));
			SerializeField(s, nameof(autoMurphy));
			SerializeField(s, nameof(autoMurphyMultiAllowed));
			SerializeField(s, nameof(AMSoundEventList));
			SerializeField(s, nameof(AMSoundMapList));
		}
		public override uint? ClassCRC => 0x68D44447;
	}
}

