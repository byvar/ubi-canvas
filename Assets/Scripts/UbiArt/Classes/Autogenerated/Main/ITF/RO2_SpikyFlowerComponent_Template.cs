using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SpikyFlowerComponent_Template : ActorComponent_Template {
		[Serialize("hurtTriggerBounce"   )] public Path hurtTriggerBounce;
		[Serialize("noHurtTriggerBounce" )] public Path noHurtTriggerBounce;
		[Serialize("closedTime"          )] public float closedTime;
		[Serialize("hurtLevel"           )] public uint hurtLevel;
		[Serialize("bounceType"          )] public BOUNCETYPE bounceType;
		[Serialize("bounceIsRadial"      )] public bool bounceIsRadial;
		[Serialize("useActorPosForBounce")] public bool useActorPosForBounce;
		[Serialize("bounceType"          )] public Enum_bounceType bounceType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(hurtTriggerBounce));
				SerializeField(s, nameof(noHurtTriggerBounce));
				SerializeField(s, nameof(closedTime));
				SerializeField(s, nameof(hurtLevel));
				SerializeField(s, nameof(bounceType));
				SerializeField(s, nameof(bounceIsRadial));
				SerializeField(s, nameof(useActorPosForBounce));
			} else {
				SerializeField(s, nameof(hurtTriggerBounce));
				SerializeField(s, nameof(noHurtTriggerBounce));
				SerializeField(s, nameof(closedTime));
				SerializeField(s, nameof(hurtLevel));
				SerializeField(s, nameof(bounceType));
				SerializeField(s, nameof(bounceIsRadial));
				SerializeField(s, nameof(useActorPosForBounce));
			}
		}
		public enum BOUNCETYPE {
			[Serialize("BOUNCETYPE_ENEMY"            )] ENEMY = 1,
			[Serialize("BOUNCETYPE_BUMPER"           )] BUMPER = 2,
			[Serialize("BOUNCETYPE_BUMPER_AIRCONTROL")] BUMPER_AIRCONTROL = 8,
			[Serialize("BOUNCETYPE_SETBACKS"         )] SETBACKS = 7,
		}
		public enum Enum_bounceType {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_8")] Value_8 = 8,
			[Serialize("Value_7")] Value_7 = 7,
		}
		public override uint? ClassCRC => 0xE338FAB2;
	}
}

