using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ParachuteComponent_Template : ActorComponent_Template {
		[Serialize("animOpening"         )] public StringID animOpening;
		[Serialize("animFalling"         )] public StringID animFalling;
		[Serialize("animDrop"            )] public StringID animDrop;
		[Serialize("animCarryingStart"   )] public StringID animCarryingStart;
		[Serialize("animCarryingStop"    )] public StringID animCarryingStop;
		[Serialize("animEmpty"           )] public StringID animEmpty;
		[Serialize("explodeFxName"       )] public StringID explodeFxName;
		[Serialize("collisionRadius"     )] public float collisionRadius;
		[Serialize("eventCarryingStart"  )] public Generic<Event> eventCarryingStart;
		[Serialize("eventCarryingStop"   )] public Generic<Event> eventCarryingStop;
		[Serialize("eventParachuteBroken")] public Generic<Event> eventParachuteBroken;
		[Serialize("reward"              )] public uint reward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animOpening));
			SerializeField(s, nameof(animFalling));
			SerializeField(s, nameof(animDrop));
			SerializeField(s, nameof(animCarryingStart));
			SerializeField(s, nameof(animCarryingStop));
			SerializeField(s, nameof(animEmpty));
			SerializeField(s, nameof(explodeFxName));
			SerializeField(s, nameof(collisionRadius));
			SerializeField(s, nameof(eventCarryingStart));
			SerializeField(s, nameof(eventCarryingStop));
			SerializeField(s, nameof(eventParachuteBroken));
			SerializeField(s, nameof(reward));
		}
		public override uint? ClassCRC => 0x8558B074;
	}
}

