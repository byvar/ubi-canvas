using ITF.ActorComponents.Template;
using ITF.TweenInstructions;
using UnityEngine;

namespace ITF.ActorComponents {
	public class TweenComponent : ActorComponent {
		//public bool trigOnCheckPoint;
		[Serialize(0, "instanceTemplate")] public Nullable<TweenComponent_Template> instanceTemplate;
		[Serialize(1, "syncOffset")] public float syncOffset;
		[Serialize(2, "skipInstructionSetSyncOffset")] public bool skipInstructionSetSyncOffset;
		[Serialize(3, "autoStart")] public bool autoStart;
		[Serialize(4, "groupIndex")] public uint groupIndex;
		[Serialize(5, "startSet")] public StringID startSet;
		[Serialize(6, "instructionSets")] public Container<InstructionSet> instructionSets;

		public TweenComponent(Reader reader) : base(reader) {
		}

		public class InstructionSet : BaseObject {
			[Serialize(0, "name")] public StringID name;
			[Serialize(1, "instructions")] public Container<Generic<TweenInstruction>> instructions;

			public InstructionSet(Reader reader) : base(reader) {
			}
		}
	}
}
