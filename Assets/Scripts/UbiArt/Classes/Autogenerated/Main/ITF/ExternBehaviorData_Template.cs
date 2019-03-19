using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class ExternBehaviorData_Template : CSerializable {
		[Serialize("behaviorTemplate"   )] public Generic<TemplateAIBehavior> behaviorTemplate;
		[Serialize("behaviorName"       )] public StringID behaviorName;
		[Serialize("cuttableBehaviors"  )] public CList<StringID> cuttableBehaviors;
		[Serialize("disablePhys"        )] public bool disablePhys;
		[Serialize("nextBehaviors"      )] public CList<ExternBehaviorData_Template.NextBhvData> nextBehaviors;
		[Serialize("defaultNextBehavior")] public StringID defaultNextBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(behaviorTemplate));
			SerializeField(s, nameof(behaviorName));
			SerializeField(s, nameof(cuttableBehaviors));
			SerializeField(s, nameof(disablePhys));
			SerializeField(s, nameof(nextBehaviors));
			SerializeField(s, nameof(defaultNextBehavior));
		}
		[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
		public partial class NextBhvData : CSerializable {
			[Serialize("previousBvh")] public StringID previousBvh;
			[Serialize("nextBvh"    )] public StringID nextBvh;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(previousBvh));
				SerializeField(s, nameof(nextBvh));
			}
		}
	}
}

