using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_TutoBallComponent : ActorComponent {
		[Serialize("tutoEnabled"        )] public bool tutoEnabled;
		[Serialize("tutoSwipeLeftPos"   )] public Vec2d tutoSwipeLeftPos;
		[Serialize("tutoSwipeRightPos"  )] public Vec2d tutoSwipeRightPos;
		[Serialize("tutoTapPos"         )] public Vec2d tutoTapPos;
		[Serialize("distanceFar"        )] public float distanceFar;
		[Serialize("distanceCloseEnough")] public float distanceCloseEnough;
		[Serialize("ActionsToResume"    )] public CMultiMap<RLC_TutorialCommandType, RLC_TutoBallComponent.ActionToUnpause> ActionsToResume;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tutoEnabled));
			SerializeField(s, nameof(tutoSwipeLeftPos));
			SerializeField(s, nameof(tutoSwipeRightPos));
			SerializeField(s, nameof(tutoTapPos));
			SerializeField(s, nameof(distanceFar));
			SerializeField(s, nameof(distanceCloseEnough));
			SerializeField(s, nameof(ActionsToResume));
		}
		[Games(GameFlags.RA)]
		public partial class ActionToUnpause : CSerializable {
			[Serialize("id"         )] public StringID id;
			[Serialize("axis"       )] public float axis;
			[Serialize("Comparation")] public ECompareType Comparation;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(axis));
				SerializeField(s, nameof(Comparation));
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

