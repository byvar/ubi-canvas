namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_TeleportTargetComponent : ActorComponent {
		public COL_TeleportTargetComponent_ArriveFromInfos arriveFromInfos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			arriveFromInfos = s.SerializeObject<COL_TeleportTargetComponent_ArriveFromInfos>(arriveFromInfos, name: "arriveFromInfos");
		}
		public override uint? ClassCRC => 0xB1576575;

		public class COL_TeleportTargetComponent_ArriveFromInfos : CSerializable {	
			public StringID interactionAction;
			public Enum_gotoType gotoType;
			public Vec2d gotoTargetPos;
			public float gotoTargetZ;
			public float gotoDuration;
			public bool gotoRun;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.HasFlags(SerializeFlags.Default)) {
					interactionAction = s.SerializeObject<StringID>(interactionAction, name: "interactionAction");
					gotoType = s.Serialize<Enum_gotoType>(gotoType, name: "gotoType");
					gotoTargetPos = s.SerializeObject<Vec2d>(gotoTargetPos, name: "gotoTargetPos");
					gotoTargetZ = s.Serialize<float>(gotoTargetZ, name: "gotoTargetZ");
					gotoDuration = s.Serialize<float>(gotoDuration, name: "gotoDuration");
					gotoRun = s.Serialize<bool>(gotoRun, name: "gotoRun", options: CSerializerObject.Options.BoolAsByte);
				}
			}
			public enum Enum_gotoType {
				[Serialize("Value_0")] Value_0 = 0,
				[Serialize("Value_1")] Value_1 = 1,
				[Serialize("Value_2")] Value_2 = 2,
				[Serialize("Value_3")] Value_3 = 3,
			}
		}
	}
}

