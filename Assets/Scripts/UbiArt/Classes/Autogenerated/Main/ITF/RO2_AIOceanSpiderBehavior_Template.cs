using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIOceanSpiderBehavior_Template : TemplateAIBehavior {
		public CList<RO2_AIOceanSpiderBehavior_Template.ActionTemplate> Actions;
		public CList<RO2_AIOceanSpiderBehavior_Template.InstructionTemplate> Instructions;
		public CList<RO2_AIOceanSpiderBehavior_Template.InstructionTemplate> InactiveInstructions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Actions = s.SerializeObject<CList<RO2_AIOceanSpiderBehavior_Template.ActionTemplate>>(Actions, name: "Actions");
			Instructions = s.SerializeObject<CList<RO2_AIOceanSpiderBehavior_Template.InstructionTemplate>>(Instructions, name: "Instructions");
			InactiveInstructions = s.SerializeObject<CList<RO2_AIOceanSpiderBehavior_Template.InstructionTemplate>>(InactiveInstructions, name: "InactiveInstructions");
		}
		[Games(GameFlags.RA)]
		public partial class InstructionTemplate : CSerializable {
			public StringID actionName;
			public uint playCount;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				actionName = s.SerializeObject<StringID>(actionName, name: "actionName");
				playCount = s.Serialize<uint>(playCount, name: "playCount");
			}
		}
		[Games(GameFlags.RA)]
		public partial class ActionTemplate : CSerializable {
			public StringID name;
			public Generic<AIAction_Template> action;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				name = s.SerializeObject<StringID>(name, name: "name");
				action = s.SerializeObject<Generic<AIAction_Template>>(action, name: "action");
			}
		}
		public override uint? ClassCRC => 0x56166679;
	}
}

