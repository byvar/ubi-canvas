using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class ExternBehaviorData_Template : CSerializable {
		public Generic<TemplateAIBehavior> behaviorTemplate;
		public StringID behaviorName;
		public CList<StringID> cuttableBehaviors;
		public bool disablePhys;
		public CList<ExternBehaviorData_Template.NextBhvData> nextBehaviors;
		public StringID defaultNextBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			behaviorTemplate = s.SerializeObject<Generic<TemplateAIBehavior>>(behaviorTemplate, name: "behaviorTemplate");
			behaviorName = s.SerializeObject<StringID>(behaviorName, name: "behaviorName");
			cuttableBehaviors = s.SerializeObject<CList<StringID>>(cuttableBehaviors, name: "cuttableBehaviors");
			disablePhys = s.Serialize<bool>(disablePhys, name: "disablePhys");
			nextBehaviors = s.SerializeObject<CList<ExternBehaviorData_Template.NextBhvData>>(nextBehaviors, name: "nextBehaviors");
			defaultNextBehavior = s.SerializeObject<StringID>(defaultNextBehavior, name: "defaultNextBehavior");
		}
		[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
		public partial class NextBhvData : CSerializable {
			public StringID previousBvh;
			public StringID nextBvh;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				previousBvh = s.SerializeObject<StringID>(previousBvh, name: "previousBvh");
				nextBvh = s.SerializeObject<StringID>(nextBvh, name: "nextBvh");
			}
		}
	}
}

