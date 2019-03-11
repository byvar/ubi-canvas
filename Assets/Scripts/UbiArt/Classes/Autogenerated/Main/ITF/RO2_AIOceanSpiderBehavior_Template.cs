using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AIOceanSpiderBehavior_Template : TemplateAIBehavior {
		[Serialize("Actions"             )] public CList<RO2_AIOceanSpiderBehavior_Template.ActionTemplate> Actions;
		[Serialize("Instructions"        )] public CList<RO2_AIOceanSpiderBehavior_Template.InstructionTemplate> Instructions;
		[Serialize("InactiveInstructions")] public CList<RO2_AIOceanSpiderBehavior_Template.InstructionTemplate> InactiveInstructions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Actions));
			SerializeField(s, nameof(Instructions));
			SerializeField(s, nameof(InactiveInstructions));
		}
		public partial class InstructionTemplate : CSerializable {
			[Serialize("actionName")] public StringID actionName;
			[Serialize("playCount" )] public uint playCount;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(actionName));
				SerializeField(s, nameof(playCount));
			}
		}
		public partial class ActionTemplate : CSerializable {
			[Serialize("name"  )] public StringID name;
			[Serialize("action")] public Generic<AIAction_Template> action;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(action));
			}
		}
		public override uint? ClassCRC => 0x56166679;
	}
}

