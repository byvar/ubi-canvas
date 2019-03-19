using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIFruitTrapComponent_Template : ActorComponent_Template {
		[Serialize("delay"          )] public float delay;
		[Serialize("stayDownDelay"  )] public float stayDownDelay;
		[Serialize("weightThreshold")] public float weightThreshold;
		[Serialize("defaultPosIsUp" )] public bool defaultPosIsUp;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(delay));
			SerializeField(s, nameof(stayDownDelay));
			SerializeField(s, nameof(weightThreshold));
			SerializeField(s, nameof(defaultPosIsUp));
		}
		public override uint? ClassCRC => 0xFDFC9D5C;
	}
}

