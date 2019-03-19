using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class TriggerTestComponent : ActorComponent {
		[Serialize("AutoStart"                                   )] public bool AutoStart;
		[Serialize("Detection"                                   )] public CList<TriggerSelectionAbstract> Detection;
		[Serialize("DetectionOperator"                           )] public Enum_DetectionOperator DetectionOperator;
		[Serialize("Test"                                        )] public CList<TriggerTestAbstract> Test;
		[Serialize("TestOperator"                                )] public Enum_TestOperator TestOperator;
		[Serialize("PlayMode"                                    )] public Enum_PlayMode PlayMode;
		[Serialize("OnActivate"                                  )] public CList<sEventData> OnActivate;
		[Serialize("OnDeactivate"                                )] public CList<sEventData> OnDeactivate;
		[Serialize("OnStayActive"                                )] public CList<sEventData> OnStayActive;
		[Serialize("StayActiveDelay"                             )] public float StayActiveDelay;
		[Serialize("bool__0"                                     )] public bool bool__0;
		[Serialize("CArray<Generic<TriggerSelectionAbstract>>__1")] public CArray<Generic<TriggerSelectionAbstract>> CArray_Generic_TriggerSelectionAbstract__1;
		[Serialize("Enum_VH_0__2"                                )] public Enum_VH_0 Enum_VH_0__2;
		[Serialize("CArray<Generic<TriggerTestAbstract>>__3"     )] public CArray<Generic<TriggerTestAbstract>> CArray_Generic_TriggerTestAbstract__3;
		[Serialize("Enum_VH_1__4"                                )] public Enum_VH_1 Enum_VH_1__4;
		[Serialize("CArray<Generic<TriggerSelectionAbstract>>__5")] public CArray<Generic<TriggerSelectionAbstract>> CArray_Generic_TriggerSelectionAbstract__5;
		[Serialize("Enum_VH_2__6"                                )] public Enum_VH_2 Enum_VH_2__6;
		[Serialize("CArray<Generic<TriggerTestAbstract>>__7"     )] public CArray<Generic<TriggerTestAbstract>> CArray_Generic_TriggerTestAbstract__7;
		[Serialize("Enum_VH_2__8"                                )] public Enum_VH_2 Enum_VH_2__8;
		[Serialize("CArray<sEventData>__9"                       )] public CArray<sEventData> CArray_sEventData__9;
		[Serialize("CArray<sEventData>__10"                      )] public CArray<sEventData> CArray_sEventData__10;
		[Serialize("CArray<sEventData>__11"                      )] public CArray<sEventData> CArray_sEventData__11;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(bool__0));
				if (s.HasFlags(SerializeFlags.Flags_x03)) {
					SerializeField(s, nameof(CArray_Generic_TriggerSelectionAbstract__1));
					SerializeField(s, nameof(Enum_VH_0__2));
					SerializeField(s, nameof(CArray_Generic_TriggerTestAbstract__3));
					SerializeField(s, nameof(Enum_VH_1__4));
					SerializeField(s, nameof(CArray_Generic_TriggerSelectionAbstract__5));
					SerializeField(s, nameof(Enum_VH_2__6));
					SerializeField(s, nameof(CArray_Generic_TriggerTestAbstract__7));
					SerializeField(s, nameof(Enum_VH_2__8));
				}
				SerializeField(s, nameof(CArray_sEventData__9));
				SerializeField(s, nameof(CArray_sEventData__10));
				SerializeField(s, nameof(CArray_sEventData__11));
			} else {
				SerializeField(s, nameof(AutoStart));
				if (s.HasFlags(SerializeFlags.Flags_x03)) {
					SerializeField(s, nameof(Detection));
					SerializeField(s, nameof(DetectionOperator));
					SerializeField(s, nameof(Test));
					SerializeField(s, nameof(TestOperator));
					SerializeField(s, nameof(PlayMode));
					SerializeField(s, nameof(Detection));
					SerializeField(s, nameof(DetectionOperator));
					SerializeField(s, nameof(Test));
					SerializeField(s, nameof(TestOperator));
				}
				SerializeField(s, nameof(OnActivate));
				SerializeField(s, nameof(OnDeactivate));
				SerializeField(s, nameof(OnStayActive));
				if (s.HasFlags(SerializeFlags.Flags_x03)) {
					SerializeField(s, nameof(StayActiveDelay));
				}
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
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public enum Enum_VH_1 {
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0xC3ACA835;
	}
}

