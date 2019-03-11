using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_412_sub_B68190 : CSerializable {
		[Serialize("enter"                 )] public bool enter;
		[Serialize("hi5Event"              )] public Placeholder hi5Event;
		[Serialize("autoMurphy"            )] public bool autoMurphy;
		[Serialize("autoMurphyMultiAllowed")] public bool autoMurphyMultiAllowed;
		[Serialize("AMSoundEventList"      )] public Placeholder AMSoundEventList;
		[Serialize("AMSoundMapList"        )] public Placeholder AMSoundMapList;
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

