using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class TriggerTestComponent : ActorComponent {
		[Serialize("AutoStart"                                   )] public bool AutoStart;
		[Serialize("Detection"                                   )] public CList<Generic<TriggerSelectionAbstract>> Detection;
		[Serialize("DetectionOperator"                           )] public Operator DetectionOperator;
		[Serialize("Test"                                        )] public CList<Generic<TriggerTestAbstract>> Test;
		[Serialize("TestOperator"                                )] public Operator TestOperator;
		[Serialize("PlayMode"                                    )] public Enum_PlayMode PlayMode;
		[Serialize("OnActivate"                                  )] public CList<sEventData> OnActivate;
		[Serialize("OnDeactivate"                                )] public CList<sEventData> OnDeactivate;
		[Serialize("OnStayActive"                                )] public CList<sEventData> OnStayActive;
		[Serialize("StayActiveDelay"                             )] public float StayActiveDelay;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(AutoStart));
				if (!s.HasFlags(SerializeFlags.Editor)) {
					SerializeField(s, nameof(Detection));
					SerializeField(s, nameof(DetectionOperator));
					SerializeField(s, nameof(Test));
					SerializeField(s, nameof(TestOperator));
				} else if (!AutoStart) {
					SerializeField(s, nameof(Detection));
					if (Detection.Count > 1) SerializeField(s, nameof(DetectionOperator));
					SerializeField(s, nameof(Test));
					if (Test.Count > 1) SerializeField(s, nameof(TestOperator));
				}
				SerializeField(s, nameof(OnActivate));
				SerializeField(s, nameof(OnDeactivate));
				SerializeField(s, nameof(OnStayActive));
			} else {
				SerializeField(s, nameof(AutoStart));
				if (!s.HasFlags(SerializeFlags.Editor)) {
					SerializeField(s, nameof(Detection));
					SerializeField(s, nameof(DetectionOperator));
					SerializeField(s, nameof(Test));
					SerializeField(s, nameof(TestOperator));
					SerializeField(s, nameof(PlayMode));
				} else if(!AutoStart) {
					SerializeField(s, nameof(Detection));
					if (Detection.Count > 1) SerializeField(s, nameof(DetectionOperator));
					SerializeField(s, nameof(Test));
					if (Test.Count > 1) SerializeField(s, nameof(TestOperator));
				}
				SerializeField(s, nameof(OnActivate));
				SerializeField(s, nameof(OnDeactivate));
				SerializeField(s, nameof(OnStayActive));
				if (s.HasFlags(SerializeFlags.Editor)) {
					SerializeField(s, nameof(StayActiveDelay));
				}
			}
		}
		public enum Operator {
			[Serialize("AND")] AND = 0,
			[Serialize("OR" )] OR = 1,
		}
		public enum Enum_PlayMode {
			[Serialize("LOOP")] LOOP = 0,
			[Serialize("ONCE")] ONCE = 1,
		}
		public override uint? ClassCRC => 0xC3ACA835;
	}
}

