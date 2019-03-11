using UnityEngine;

namespace UbiArt.ITF {
	public partial class TriggerTestComponent : ActorComponent {
		[Serialize("AutoStart"        )] public bool AutoStart;
		[Serialize("Detection"        )] public CList<TriggerSelectionAbstract> Detection;
		[Serialize("DetectionOperator")] public Enum_DetectionOperator DetectionOperator;
		[Serialize("Test"             )] public CList<TriggerTestAbstract> Test;
		[Serialize("TestOperator"     )] public Enum_TestOperator TestOperator;
		[Serialize("PlayMode"         )] public Enum_PlayMode PlayMode;
		[Serialize("OnActivate"       )] public CList<sEventData> OnActivate;
		[Serialize("OnDeactivate"     )] public CList<sEventData> OnDeactivate;
		[Serialize("OnStayActive"     )] public CList<sEventData> OnStayActive;
		[Serialize("StayActiveDelay"  )] public float StayActiveDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(AutoStart));
			if (s.HasFlags(SerializeFlags.Flags_x03)) {
				SerializeField(s, nameof(Detection));
				SerializeField(s, nameof(DetectionOperator));
				SerializeField(s, nameof(Test));
				SerializeField(s, nameof(TestOperator));
				SerializeField(s, nameof(PlayMode));
			}
			SerializeField(s, nameof(OnActivate));
			SerializeField(s, nameof(OnDeactivate));
			SerializeField(s, nameof(OnStayActive));
			if (s.HasFlags(SerializeFlags.Flags_x03)) {
				SerializeField(s, nameof(StayActiveDelay));
			}
		}
		public enum Enum_DetectionOperator {
			[Serialize("AND")] AND = 0,
			[Serialize("OR" )] OR = 1,
		}
		public enum Enum_PlayMode {
			[Serialize("LOOP")] LOOP = v11,
			[Serialize("ONCE")] ONCE = 1,
		}
		public override uint? ClassCRC => 0xC3ACA835;
	}
}

