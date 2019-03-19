using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RO | GameFlags.RFR | GameFlags.RL | GameFlags.VH)]
	public partial class TweenComponent_Template : ActorComponent_Template {
		[Serialize("preInstructionSets"                               )] public CList<TweenComponent_Template.InstructionSet> preInstructionSets;
		[Serialize("instructionSets"                                  )] public CList<TweenComponent_Template.InstructionSet> instructionSets;
		[Serialize("playFirstSetIfNoStartSet"                         )] public bool playFirstSetIfNoStartSet;
		[Serialize("sync"                                             )] public bool sync;
		[Serialize("metronome"                                        )] public METRONOME_TYPE metronome;
		[Serialize("applyPosition"                                    )] public bool applyPosition;
		[Serialize("applyRotation"                                    )] public bool applyRotation;
		[Serialize("applyScale"                                       )] public bool applyScale;
		[Serialize("applyFeedback"                                    )] public bool applyFeedback;
		[Serialize("trigOnCheckPointEnabled"                          )] public bool trigOnCheckPointEnabled;
		[Serialize("inputs"                                           )] public CList<InputDesc> inputs;
		[Serialize("autoStart"                                        )] public bool autoStart;
		[Serialize("sync"                                             )] public int sync;
		[Serialize("metronome"                                        )] public Enum_RJR_0 metronome;
		[Serialize("syncOffset"                                       )] public float syncOffset;
		[Serialize("startMode"                                        )] public Enum_RJR_1 startMode;
		[Serialize("startSet"                                         )] public StringID startSet;
		[Serialize("applyPosition"                                    )] public int applyPosition;
		[Serialize("applyRotation"                                    )] public int applyRotation;
		[Serialize("applyScale"                                       )] public int applyScale;
		[Serialize("playFirstSetIfNoStartSet"                         )] public int playFirstSetIfNoStartSet;
		[Serialize("sync"                                             )] public Enum_RFR_0 sync;
		[Serialize("metronome"                                        )] public float metronome;
		[Serialize("applyPosition"                                    )] public Enum_RFR_1 applyPosition;
		[Serialize("applyRotation"                                    )] public StringID applyRotation;
		[Serialize("applyFeedback"                                    )] public int applyFeedback;
		[Serialize("trigOnCheckPointEnabled"                          )] public int trigOnCheckPointEnabled;
		[Serialize("CArray<TweenComponent_Template.InstructionSet>__0")] public CArray<TweenComponent_Template.InstructionSet> CArray_TweenComponent_Template_InstructionSet__0;
		[Serialize("CArray<TweenComponent_Template.InstructionSet>__1")] public CArray<TweenComponent_Template.InstructionSet> CArray_TweenComponent_Template_InstructionSet__1;
		[Serialize("bool__2"                                          )] public bool bool__2;
		[Serialize("bool__3"                                          )] public bool bool__3;
		[Serialize("Enum_VH_0__4"                                     )] public Enum_VH_0 Enum_VH_0__4;
		[Serialize("bool__5"                                          )] public bool bool__5;
		[Serialize("bool__6"                                          )] public bool bool__6;
		[Serialize("bool__7"                                          )] public bool bool__7;
		[Serialize("bool__8"                                          )] public bool bool__8;
		[Serialize("bool__9"                                          )] public bool bool__9;
		[Serialize("CArray<InputDesc>__10"                            )] public CArray<InputDesc> CArray_InputDesc__10;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(instructionSets));
				SerializeField(s, nameof(sync));
				SerializeField(s, nameof(metronome));
				SerializeField(s, nameof(syncOffset));
				SerializeField(s, nameof(startMode));
				SerializeField(s, nameof(startSet));
				SerializeField(s, nameof(applyPosition));
				SerializeField(s, nameof(applyRotation));
				SerializeField(s, nameof(applyScale));
				SerializeField(s, nameof(inputs));
			} else if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(instructionSets));
				SerializeField(s, nameof(playFirstSetIfNoStartSet));
				SerializeField(s, nameof(sync));
				SerializeField(s, nameof(metronome));
				SerializeField(s, nameof(applyPosition));
				SerializeField(s, nameof(applyRotation));
				SerializeField(s, nameof(applyScale));
				SerializeField(s, nameof(applyFeedback));
				SerializeField(s, nameof(trigOnCheckPointEnabled));
				SerializeField(s, nameof(inputs));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(CArray_TweenComponent_Template_InstructionSet__0));
				SerializeField(s, nameof(CArray_TweenComponent_Template_InstructionSet__1));
				SerializeField(s, nameof(bool__2));
				SerializeField(s, nameof(bool__3));
				SerializeField(s, nameof(Enum_VH_0__4));
				SerializeField(s, nameof(bool__5));
				SerializeField(s, nameof(bool__6));
				SerializeField(s, nameof(bool__7));
				SerializeField(s, nameof(bool__8));
				SerializeField(s, nameof(bool__9));
				SerializeField(s, nameof(CArray_InputDesc__10));
			} else {
				SerializeField(s, nameof(preInstructionSets));
				SerializeField(s, nameof(instructionSets));
				SerializeField(s, nameof(playFirstSetIfNoStartSet));
				SerializeField(s, nameof(sync));
				SerializeField(s, nameof(metronome));
				SerializeField(s, nameof(applyPosition));
				SerializeField(s, nameof(applyRotation));
				SerializeField(s, nameof(applyScale));
				SerializeField(s, nameof(applyFeedback));
				SerializeField(s, nameof(trigOnCheckPointEnabled));
				SerializeField(s, nameof(inputs));
				SerializeField(s, nameof(autoStart));
			}
		}
		[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
		public partial class InstructionSet : CSerializable {
			[Serialize("name"           )] public StringID name;
			[Serialize("instructions"   )] public CList<TweenInstruction_Template> instructions;
			[Serialize("iterationCount" )] public uint iterationCount;
			[Serialize("angleOffset"    )] public AngleAmount angleOffset;
			[Serialize("startEvent"     )] public Generic<Event> startEvent;
			[Serialize("stopEvent"      )] public Generic<Event> stopEvent;
			[Serialize("interruptible"  )] public bool interruptible;
			[Serialize("triggable"      )] public bool triggable;
			[Serialize("nextSet"        )] public StringID nextSet;
			[Serialize("proceduralInput")] public ProceduralInputData proceduralInput;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(instructions));
				SerializeField(s, nameof(iterationCount));
				SerializeField(s, nameof(angleOffset));
				SerializeField(s, nameof(startEvent));
				SerializeField(s, nameof(stopEvent));
				SerializeField(s, nameof(interruptible));
				SerializeField(s, nameof(triggable));
				SerializeField(s, nameof(nextSet));
				SerializeField(s, nameof(proceduralInput));
			}
		}
		public enum METRONOME_TYPE {
			[Serialize("METRONOME_TYPE_DEFAULT" )] DEFAULT = 0,
			[Serialize("METRONOME_TYPE_MENU"    )] MENU = 1,
			[Serialize("METRONOME_TYPE_GAMEPLAY")] GAMEPLAY = 2,
			[Serialize("METRONOME_TYPE_INVALID" )] INVALID = 4,
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_RJR_1 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_RFR_1 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0xAAC45215;
	}
}

