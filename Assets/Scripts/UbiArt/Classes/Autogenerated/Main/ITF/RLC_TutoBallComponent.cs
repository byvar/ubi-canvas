using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_TutoBallComponent : ActorComponent {
		[Serialize("tutoEnabled"        )] public bool tutoEnabled;
		[Serialize("tutoSwipeLeftPos"   )] public Vector2 tutoSwipeLeftPos;
		[Serialize("tutoSwipeRightPos"  )] public Vector2 tutoSwipeRightPos;
		[Serialize("tutoTapPos"         )] public Vector2 tutoTapPos;
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

