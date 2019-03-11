using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenComponent_Template : ActorComponent_Template {
		[Serialize("preInstructionSets"      )] public CList<TweenComponent_Template.InstructionSet> preInstructionSets;
		[Serialize("instructionSets"         )] public CList<TweenComponent_Template.InstructionSet> instructionSets;
		[Serialize("playFirstSetIfNoStartSet")] public bool playFirstSetIfNoStartSet;
		[Serialize("sync"                    )] public bool sync;
		[Serialize("metronome"               )] public METRONOME_TYPE metronome;
		[Serialize("applyPosition"           )] public bool applyPosition;
		[Serialize("applyRotation"           )] public bool applyRotation;
		[Serialize("applyScale"              )] public bool applyScale;
		[Serialize("applyFeedback"           )] public bool applyFeedback;
		[Serialize("trigOnCheckPointEnabled" )] public bool trigOnCheckPointEnabled;
		[Serialize("inputs"                  )] public CList<InputDesc> inputs;
		[Serialize("autoStart"               )] public bool autoStart;
		[Serialize("syncOffset"              )] public float syncOffset;
		[Serialize("startMode"               )] public StartMode startMode;
		[Serialize("startSet"                )] public StringID startSet;
		[Serialize("metronome"               )] public Enum_metronome metronome;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
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
			} else if (Settings.s.game == Settings.Game.RL) {
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
		public enum METRONOME_TYPE {
			[Serialize("METRONOME_TYPE_DEFAULT" )] DEFAULT = 0,
			[Serialize("METRONOME_TYPE_MENU"    )] MENU = 1,
			[Serialize("METRONOME_TYPE_GAMEPLAY")] GAMEPLAY = 2,
			[Serialize("METRONOME_TYPE_LUMKING" )] LUMKING = 3,
		}
		public enum StartMode {
			[Serialize("StartMode_Auto")] Auto = 0,
			[Serialize("StartMode_On"  )] On = 1,
			[Serialize("StartMode_Off" )] Off = 2,
		}
		public enum Enum_metronome {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xAAC45215;
	}
}

