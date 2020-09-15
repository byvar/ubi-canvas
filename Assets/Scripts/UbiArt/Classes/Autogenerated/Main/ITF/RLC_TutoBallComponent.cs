using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_TutoBallComponent : ActorComponent {
		public bool tutoEnabled;
		public Vec2d tutoSwipeLeftPos;
		public Vec2d tutoSwipeRightPos;
		public Vec2d tutoTapPos;
		public float distanceFar;
		public float distanceCloseEnough;
		public CMultiMap<RLC_TutorialCommandType, RLC_TutoBallComponent.ActionToUnpause> ActionsToResume;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tutoEnabled = s.Serialize<bool>(tutoEnabled, name: "tutoEnabled");
			tutoSwipeLeftPos = s.SerializeObject<Vec2d>(tutoSwipeLeftPos, name: "tutoSwipeLeftPos");
			tutoSwipeRightPos = s.SerializeObject<Vec2d>(tutoSwipeRightPos, name: "tutoSwipeRightPos");
			tutoTapPos = s.SerializeObject<Vec2d>(tutoTapPos, name: "tutoTapPos");
			distanceFar = s.Serialize<float>(distanceFar, name: "distanceFar");
			distanceCloseEnough = s.Serialize<float>(distanceCloseEnough, name: "distanceCloseEnough");
			ActionsToResume = s.SerializeObject<CMultiMap<RLC_TutorialCommandType, RLC_TutoBallComponent.ActionToUnpause>>(ActionsToResume, name: "ActionsToResume");
		}
		[Games(GameFlags.RA)]
		public partial class ActionToUnpause : CSerializable {
			public StringID id;
			public float axis;
			public ECompareType Comparation;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				id = s.SerializeObject<StringID>(id, name: "id");
				axis = s.Serialize<float>(axis, name: "axis");
				Comparation = s.Serialize<ECompareType>(Comparation, name: "Comparation");
			}
			public enum ECompareType {
				[Serialize("ECompareType_GreaterThan" )] GreaterThan = 1,
				[Serialize("ECompareType_GreaterEqual")] GreaterEqual = 2,
				[Serialize("ECompareType_Equal"       )] Equal = 3,
				[Serialize("ECompareType_LesserEqual" )] LesserEqual = 4,
				[Serialize("ECompareType_LesserThan"  )] LesserThan = 5,
			}
		}
		public override uint? ClassCRC => 0xFDFE8E38;
	}
}

