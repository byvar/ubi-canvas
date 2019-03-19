using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PushButtonComponent : ActorComponent {
		[Serialize("triggerOnStick")] public bool triggerOnStick;
		[Serialize("triggerOnHit"  )] public bool triggerOnHit;
		[Serialize("triggerOnDRC"  )] public bool triggerOnDRC;
		[Serialize("triggerCount"  )] public uint triggerCount;
		[Serialize("activator"     )] public uint activator;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(triggerOnStick));
					SerializeField(s, nameof(triggerOnHit));
					SerializeField(s, nameof(triggerOnDRC));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(activator));
					SerializeField(s, nameof(triggerCount));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(triggerOnStick));
					SerializeField(s, nameof(triggerOnHit));
					SerializeField(s, nameof(triggerOnDRC));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(triggerCount));
				}
			}
		}
		public override uint? ClassCRC => 0xA841D201;
	}
}

