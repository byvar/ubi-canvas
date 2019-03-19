using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MusicHeadTriggerComponent_Template : ActorComponent_Template {
		[Serialize("sqrRadius")] public float sqrRadius;
		[Serialize("event"    )] public Generic<Event> _event;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sqrRadius));
			SerializeField(s, nameof(_event));
		}
		public override uint? ClassCRC => 0x892C3F31;
	}
}

