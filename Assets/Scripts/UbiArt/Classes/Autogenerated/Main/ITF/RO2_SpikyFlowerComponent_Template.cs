using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SpikyFlowerComponent_Template : ActorComponent_Template {
		[Serialize("hurtTriggerBounce"   )] public Path hurtTriggerBounce;
		[Serialize("noHurtTriggerBounce" )] public Path noHurtTriggerBounce;
		[Serialize("closedTime"          )] public float closedTime;
		[Serialize("hurtLevel"           )] public uint hurtLevel;
		[Serialize("bounceType"          )] public BOUNCETYPE bounceType;
		[Serialize("bounceIsRadial"      )] public bool bounceIsRadial;
		[Serialize("useActorPosForBounce")] public bool useActorPosForBounce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hurtTriggerBounce));
			SerializeField(s, nameof(noHurtTriggerBounce));
			SerializeField(s, nameof(closedTime));
			SerializeField(s, nameof(hurtLevel));
			SerializeField(s, nameof(bounceType));
			SerializeField(s, nameof(bounceIsRadial));
			SerializeField(s, nameof(useActorPosForBounce));
		}
		public enum BOUNCETYPE {
			[Serialize("BOUNCETYPE_ENEMY"            )] ENEMY = 1,
			[Serialize("BOUNCETYPE_BUMPER"           )] BUMPER = 2,
			[Serialize("BOUNCETYPE_BUMPER_AIRCONTROL")] BUMPER_AIRCONTROL = 8,
			[Serialize("BOUNCETYPE_SETBACKS"         )] SETBACKS = 7,
		}
		public override uint? ClassCRC => 0xE338FAB2;
	}
}

