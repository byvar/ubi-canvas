using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossBuboComponent : ActorComponent {
		public bool crushable;
		public bool mega;
		public uint hitPoints;
		public uint nbRewards;
		public bool triggerActivator;
		public bool delayTrigger;
		public float DRCdragDistance;
		public float comeBackDuration;
		public float nbBounce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				crushable = s.Serialize<bool>(crushable, name: "crushable");
				mega = s.Serialize<bool>(mega, name: "mega");
				hitPoints = s.Serialize<uint>(hitPoints, name: "hitPoints");
				nbRewards = s.Serialize<uint>(nbRewards, name: "nbRewards");
				triggerActivator = s.Serialize<bool>(triggerActivator, name: "triggerActivator");
				delayTrigger = s.Serialize<bool>(delayTrigger, name: "delayTrigger");
				DRCdragDistance = s.Serialize<float>(DRCdragDistance, name: "DRCdragDistance");
				comeBackDuration = s.Serialize<float>(comeBackDuration, name: "comeBackDuration");
				nbBounce = s.Serialize<float>(nbBounce, name: "nbBounce");
			}
		}
		public override uint? ClassCRC => 0xCD2784A8;
	}
}

