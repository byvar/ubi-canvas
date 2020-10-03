using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class TweenComponent_Template : ActorComponent_Template {
		public CListO<TweenComponent_Template.InstructionSet> preInstructionSets;
		public CListO<TweenComponent_Template.InstructionSet> instructionSets;
		public bool playFirstSetIfNoStartSet;
		public bool sync;
		public METRONOME_TYPE metronome;
		public METRONOME_TYPE2 metronome2;
		public bool applyPosition;
		public bool applyRotation;
		public bool applyScale;
		public bool applyFeedback;
		public bool trigOnCheckPointEnabled;
		public CListO<InputDesc> inputs;
		public bool autoStart;
		
		public StartMode startMode;
		public float syncOffset;
		public StringID startSet;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				instructionSets = s.SerializeObject<CListO<TweenComponent_Template.InstructionSet>>(instructionSets, name: "instructionSets");
				sync = s.Serialize<bool>(sync, name: "sync");
				metronome2 = s.Serialize<METRONOME_TYPE2>(metronome2, name: "metronome");
				syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
				startMode = s.Serialize<StartMode>(startMode, name: "startMode");
				startSet = s.SerializeObject<StringID>(startSet, name: "startSet");
				applyPosition = s.Serialize<bool>(applyPosition, name: "applyPosition");
				applyRotation = s.Serialize<bool>(applyRotation, name: "applyRotation");
				applyScale = s.Serialize<bool>(applyScale, name: "applyScale");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				instructionSets = s.SerializeObject<CListO<TweenComponent_Template.InstructionSet>>(instructionSets, name: "instructionSets");
				playFirstSetIfNoStartSet = s.Serialize<bool>(playFirstSetIfNoStartSet, name: "playFirstSetIfNoStartSet", options: CSerializerObject.Options.BoolAsByte);
				sync = s.Serialize<bool>(sync, name: "sync", options: CSerializerObject.Options.BoolAsByte);
				metronome = s.Serialize<METRONOME_TYPE>(metronome, name: "metronome");
				applyPosition = s.Serialize<bool>(applyPosition, name: "applyPosition", options: CSerializerObject.Options.BoolAsByte);
				applyRotation = s.Serialize<bool>(applyRotation, name: "applyRotation", options: CSerializerObject.Options.BoolAsByte);
				applyScale = s.Serialize<bool>(applyScale, name: "applyScale", options: CSerializerObject.Options.BoolAsByte);
				applyFeedback = s.Serialize<bool>(applyFeedback, name: "applyFeedback", options: CSerializerObject.Options.BoolAsByte);
				trigOnCheckPointEnabled = s.Serialize<bool>(trigOnCheckPointEnabled, name: "trigOnCheckPointEnabled", options: CSerializerObject.Options.BoolAsByte);
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
			} else if (Settings.s.game == Settings.Game.VH) {
				preInstructionSets = s.SerializeObject<CListO<TweenComponent_Template.InstructionSet>>(preInstructionSets, name: "preInstructionSets");
				instructionSets = s.SerializeObject<CListO<TweenComponent_Template.InstructionSet>>(instructionSets, name: "instructionSets");
				playFirstSetIfNoStartSet = s.Serialize<bool>(playFirstSetIfNoStartSet, name: "playFirstSetIfNoStartSet");
				sync = s.Serialize<bool>(sync, name: "sync");
				metronome = s.Serialize<METRONOME_TYPE>(metronome, name: "metronome");
				applyPosition = s.Serialize<bool>(applyPosition, name: "applyPosition");
				applyRotation = s.Serialize<bool>(applyRotation, name: "applyRotation");
				applyScale = s.Serialize<bool>(applyScale, name: "applyScale");
				applyFeedback = s.Serialize<bool>(applyFeedback, name: "applyFeedback");
				trigOnCheckPointEnabled = s.Serialize<bool>(trigOnCheckPointEnabled, name: "trigOnCheckPointEnabled");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
			} else {
				preInstructionSets = s.SerializeObject<CListO<TweenComponent_Template.InstructionSet>>(preInstructionSets, name: "preInstructionSets");
				instructionSets = s.SerializeObject<CListO<TweenComponent_Template.InstructionSet>>(instructionSets, name: "instructionSets");
				playFirstSetIfNoStartSet = s.Serialize<bool>(playFirstSetIfNoStartSet, name: "playFirstSetIfNoStartSet");
				sync = s.Serialize<bool>(sync, name: "sync");
				metronome = s.Serialize<METRONOME_TYPE>(metronome, name: "metronome");
				applyPosition = s.Serialize<bool>(applyPosition, name: "applyPosition");
				applyRotation = s.Serialize<bool>(applyRotation, name: "applyRotation");
				applyScale = s.Serialize<bool>(applyScale, name: "applyScale");
				applyFeedback = s.Serialize<bool>(applyFeedback, name: "applyFeedback");
				trigOnCheckPointEnabled = s.Serialize<bool>(trigOnCheckPointEnabled, name: "trigOnCheckPointEnabled");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				autoStart = s.Serialize<bool>(autoStart, name: "autoStart");
			}
		}
		[Games(GameFlags.All)]
		public partial class InstructionSet : CSerializable {
			public StringID name;
			public CListO<Generic<TweenInstruction_Template>> instructions;
			public uint iterationCount;
			public AngleAmount angleOffset;
			public Generic<Event> startEvent;
			public Generic<Event> stopEvent;
			public bool interruptible;
			public bool triggable;
			public StringID nextSet;
			public ProceduralInputData proceduralInput;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RJR) {
					name = s.SerializeObject<StringID>(name, name: "name");
					instructions = s.SerializeObject<CListO<Generic<TweenInstruction_Template>>>(instructions, name: "instructions");
					iterationCount = s.Serialize<uint>(iterationCount, name: "iterationCount");
					angleOffset = s.SerializeObject<AngleAmount>(angleOffset, name: "angleOffset");
					startEvent = s.SerializeObject<Generic<Event>>(startEvent, name: "startEvent");
					stopEvent = s.SerializeObject<Generic<Event>>(stopEvent, name: "stopEvent");
					interruptible = s.Serialize<bool>(interruptible, name: "interruptible");
					nextSet = s.SerializeObject<StringID>(nextSet, name: "nextSet");
					triggable = s.Serialize<bool>(triggable, name: "triggable");
					proceduralInput = s.SerializeObject<ProceduralInputData>(proceduralInput, name: "proceduralInput");
				} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
					name = s.SerializeObject<StringID>(name, name: "name");
					instructions = s.SerializeObject<CListO<Generic<TweenInstruction_Template>>>(instructions, name: "instructions");
					iterationCount = s.Serialize<uint>(iterationCount, name: "iterationCount");
					angleOffset = s.SerializeObject<AngleAmount>(angleOffset, name: "angleOffset");
					startEvent = s.SerializeObject<Generic<Event>>(startEvent, name: "startEvent");
					stopEvent = s.SerializeObject<Generic<Event>>(stopEvent, name: "stopEvent");
					interruptible = s.Serialize<bool>(interruptible, name: "interruptible", options: CSerializerObject.Options.BoolAsByte);
					triggable = s.Serialize<bool>(triggable, name: "triggable", options: CSerializerObject.Options.BoolAsByte);
					nextSet = s.SerializeObject<StringID>(nextSet, name: "nextSet");
					proceduralInput = s.SerializeObject<ProceduralInputData>(proceduralInput, name: "proceduralInput");
				} else {
					name = s.SerializeObject<StringID>(name, name: "name");
					instructions = s.SerializeObject<CListO<Generic<TweenInstruction_Template>>>(instructions, name: "instructions");
					iterationCount = s.Serialize<uint>(iterationCount, name: "iterationCount");
					angleOffset = s.SerializeObject<AngleAmount>(angleOffset, name: "angleOffset");
					startEvent = s.SerializeObject<Generic<Event>>(startEvent, name: "startEvent");
					stopEvent = s.SerializeObject<Generic<Event>>(stopEvent, name: "stopEvent");
					interruptible = s.Serialize<bool>(interruptible, name: "interruptible");
					triggable = s.Serialize<bool>(triggable, name: "triggable");
					nextSet = s.SerializeObject<StringID>(nextSet, name: "nextSet");
					proceduralInput = s.SerializeObject<ProceduralInputData>(proceduralInput, name: "proceduralInput");
				}
			}
		}
		public enum METRONOME_TYPE {
			[Serialize("METRONOME_TYPE_DEFAULT" )] DEFAULT = 0,
			[Serialize("METRONOME_TYPE_MENU"    )] MENU = 1,
			[Serialize("METRONOME_TYPE_GAMEPLAY")] GAMEPLAY = 2,
			[Serialize("METRONOME_TYPE_INVALID" )] INVALID = 4,
		}
		
		public enum METRONOME_TYPE2 {
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
		public override uint? ClassCRC => 0xAAC45215;
	}
}

