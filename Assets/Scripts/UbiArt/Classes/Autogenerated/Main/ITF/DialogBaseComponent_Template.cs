using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class DialogBaseComponent_Template : ActorComponent_Template {
		[Serialize("useOasis"                  )] public bool useOasis;
		[Serialize("replaceSpeakersByActivator")] public bool replaceSpeakersByActivator;
		[Serialize("activeOnTrigger"           )] public bool activeOnTrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useOasis));
			SerializeField(s, nameof(replaceSpeakersByActivator));
			SerializeField(s, nameof(activeOnTrigger));
		}
		public override uint? ClassCRC => 0x660B6720;
	}
}

