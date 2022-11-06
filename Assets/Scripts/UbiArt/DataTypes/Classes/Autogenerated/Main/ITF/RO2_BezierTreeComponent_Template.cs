using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_BezierTreeComponent_Template : ActorComponent_Template {
		public uint sampleCount;
		public float widthForAABB;
		public RO2_BezierTree_Template.LinkMode linkMainBranch;
		public CArrayO<Generic<RO2_BezierBranchComponent_Template>> branchComponents;
		public TweenInterpreter_Template tweenInterpreter;
		public StringID lengthCursorInput;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sampleCount = s.Serialize<uint>(sampleCount, name: "sampleCount");
			widthForAABB = s.Serialize<float>(widthForAABB, name: "widthForAABB");
			linkMainBranch = s.Serialize<RO2_BezierTree_Template.LinkMode>(linkMainBranch, name: "linkMainBranch");
			branchComponents = s.SerializeObject<CArrayO<Generic<RO2_BezierBranchComponent_Template>>>(branchComponents, name: "branchComponents");
			tweenInterpreter = s.SerializeObject<TweenInterpreter_Template>(tweenInterpreter, name: "tweenInterpreter");
			lengthCursorInput = s.SerializeObject<StringID>(lengthCursorInput, name: "lengthCursorInput");
		}
		public override uint? ClassCRC => 0x23D04434;
	}
}

