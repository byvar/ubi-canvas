using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayAnimOnTriggerComponent_Template : ActorComponent_Template {
		[Serialize("triggerOnAnim" )] public StringID triggerOnAnim;
		[Serialize("triggerOffAnim")] public StringID triggerOffAnim;
		[Serialize("playOnGeneric" )] public bool playOnGeneric;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(triggerOnAnim));
			SerializeField(s, nameof(triggerOffAnim));
			SerializeField(s, nameof(playOnGeneric));
		}
		public override uint? ClassCRC => 0xA49D4BD7;
	}
}

