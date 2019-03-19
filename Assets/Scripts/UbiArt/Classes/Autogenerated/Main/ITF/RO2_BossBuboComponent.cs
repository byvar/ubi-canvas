using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossBuboComponent : ActorComponent {
		[Serialize("crushable"       )] public bool crushable;
		[Serialize("mega"            )] public bool mega;
		[Serialize("hitPoints"       )] public uint hitPoints;
		[Serialize("nbRewards"       )] public uint nbRewards;
		[Serialize("triggerActivator")] public bool triggerActivator;
		[Serialize("delayTrigger"    )] public bool delayTrigger;
		[Serialize("DRCdragDistance" )] public float DRCdragDistance;
		[Serialize("comeBackDuration")] public float comeBackDuration;
		[Serialize("nbBounce"        )] public float nbBounce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(crushable));
				SerializeField(s, nameof(mega));
				SerializeField(s, nameof(hitPoints));
				SerializeField(s, nameof(nbRewards));
				SerializeField(s, nameof(triggerActivator));
				SerializeField(s, nameof(delayTrigger));
				SerializeField(s, nameof(DRCdragDistance));
				SerializeField(s, nameof(comeBackDuration));
				SerializeField(s, nameof(nbBounce));
			}
		}
		public override uint? ClassCRC => 0xCD2784A8;
	}
}

