using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_BezierTreeComponent_Template : ActorComponent_Template {
		[Serialize("sampleCount"      )] public uint sampleCount;
		[Serialize("widthForAABB"     )] public float widthForAABB;
		[Serialize("linkMainBranch"   )] public RO2_BezierTree_Template.LinkMode linkMainBranch;
		[Serialize("branchComponents" )] public CArray<Generic<RO2_BezierBranchComponent_Template>> branchComponents;
		[Serialize("tweenInterpreter" )] public TweenInterpreter_Template tweenInterpreter;
		[Serialize("lengthCursorInput")] public StringID lengthCursorInput;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sampleCount));
			SerializeField(s, nameof(widthForAABB));
			SerializeField(s, nameof(linkMainBranch));
			SerializeField(s, nameof(branchComponents));
			SerializeField(s, nameof(tweenInterpreter));
			SerializeField(s, nameof(lengthCursorInput));
		}
		public override uint? ClassCRC => 0x23D04434;
	}
}

