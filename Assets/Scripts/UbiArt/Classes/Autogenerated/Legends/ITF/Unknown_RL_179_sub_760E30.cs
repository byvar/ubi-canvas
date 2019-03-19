using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_179_sub_760E30 : CSerializable {
		[Serialize("initLeftDoorOpened" )] public int initLeftDoorOpened;
		[Serialize("initRightDoorOpened")] public int initRightDoorOpened;
		[Serialize("doorStateCurrent0"  )] public Enum_doorStateCurrent0 doorStateCurrent0;
		[Serialize("doorStateTarget0"   )] public Enum_doorStateTarget0 doorStateTarget0;
		[Serialize("doorStateCursor0"   )] public float doorStateCursor0;
		[Serialize("doorStateCurrent1"  )] public Enum_doorStateCurrent1 doorStateCurrent1;
		[Serialize("doorStateTarget1"   )] public Enum_doorStateTarget1 doorStateTarget1;
		[Serialize("doorStateCursor1"   )] public float doorStateCursor1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(initLeftDoorOpened));
			SerializeField(s, nameof(initRightDoorOpened));
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(doorStateCurrent0));
				SerializeField(s, nameof(doorStateTarget0));
				SerializeField(s, nameof(doorStateCursor0));
				SerializeField(s, nameof(doorStateCurrent1));
				SerializeField(s, nameof(doorStateTarget1));
				SerializeField(s, nameof(doorStateCursor1));
			}
		}
		public enum Enum_doorStateCurrent0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0xB7898B2D;
	}
}

