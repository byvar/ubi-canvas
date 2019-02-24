using ITF.TweenInstructions.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents.Template {
	public class TweenComponent_Template : ActorComponent_Template {
		[Serialize(0, "preInstructionSets", game = Settings.Game.RA)] public Container<InstructionSet> preInstructionSets;
		[Serialize(1, "instructionSets")] public Container<InstructionSet> instructionSets;
		[Serialize(2, "playFirstSetIfNoStartSet")] public bool playFirstSetIfNoStartSet;
		[Serialize(3, "sync")] public bool sync;
		[Serialize(4, "metronome")] public MetronomeType metronome;
		[Serialize(5, "applyPosition")] public bool applyPosition;
		[Serialize(6, "applyRotation")] public bool applyRotation;
		[Serialize(7, "applyScale")] public bool applyScale;
		[Serialize(8, "applyFeedback")] public bool applyFeedback;
		[Serialize(9, "trigOnCheckPointEnabled")] public bool trigOnCheckPointEnabled;
		[Serialize(10, "inputs")] public Container<InputDesc> inputs;
		[Serialize(11, "autoStart", game = Settings.Game.RA)] public bool autoStart;
		public TweenComponent_Template(Reader reader) : base(reader) {
		}

		public class InstructionSet : BaseObject {
			[Serialize(0, "name")] public StringID name;
			[Serialize(1, "instructions")] public Container<Generic<TweenInstruction_Template>> instructions;
			[Serialize(2, "iterationCount")] public uint iterationCount;
			[Serialize(3, "angleOffset")] public AngleAmount angleOffset;
			[Serialize(4, "startEvent")] public Event startEvent;
			[Serialize(5, "stopEvent")] public Event stopEvent;
			[Serialize(6, "interruptible")] public bool interruptible;
			[Serialize(7, "triggable")] public bool triggable;
			[Serialize(8, "nextSet")] public StringID nextSet;
			[Serialize(9, "proceduralInput")] public ProceduralInputData proceduralInput;

			public InstructionSet(Reader reader) : base(reader) {
			}
		}
		public enum MetronomeType {
			Default = 0,
			Menu,
			Gameplay,
			Invalid
		}
	}
}
