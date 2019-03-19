using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CountdownComponent_Template : ActorComponent_Template {
		[Serialize("onFinishEvent")] public Generic<Event> onFinishEvent;
		[Serialize("fxControls"   )] public CList<StringID> fxControls;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(onFinishEvent));
			SerializeField(s, nameof(fxControls));
		}
		public override uint? ClassCRC => 0x3BE6C699;
	}
}

