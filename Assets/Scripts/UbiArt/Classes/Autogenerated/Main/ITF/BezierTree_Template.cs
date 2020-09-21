using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class BezierTree_Template : CSerializable {
		public uint sampleCount;
		public float widthForAABB;
		public LinkMode linkMainBranch;
		public CArrayO<Generic<BezierBranchComponent_Template>> branchComponents;
		public TweenInterpreter_Template tweenInterpreter;
		public StringID lengthCursorInput;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sampleCount = s.Serialize<uint>(sampleCount, name: "sampleCount");
			widthForAABB = s.Serialize<float>(widthForAABB, name: "widthForAABB");
			linkMainBranch = s.Serialize<LinkMode>(linkMainBranch, name: "linkMainBranch");
			branchComponents = s.SerializeObject<CArrayO<Generic<BezierBranchComponent_Template>>>(branchComponents, name: "branchComponents");
			tweenInterpreter = s.SerializeObject<TweenInterpreter_Template>(tweenInterpreter, name: "tweenInterpreter");
			lengthCursorInput = s.SerializeObject<StringID>(lengthCursorInput, name: "lengthCursorInput");
		}
		public enum LinkMode {
			[Serialize("LinkMode_None"          )] None = 0,
			[Serialize("LinkMode_FirstLinkOrTag")] FirstLinkOrTag = 1,
			[Serialize("LinkMode_TagOnly"       )] TagOnly = 2,
		}
	}
}

