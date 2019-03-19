using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RO2_BezierTree_Template : CSerializable {
		[Serialize("sampleCount"      )] public uint sampleCount;
		[Serialize("widthForAABB"     )] public float widthForAABB;
		[Serialize("linkMainBranch"   )] public LinkMode linkMainBranch;
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
		public enum LinkMode {
			[Serialize("LinkMode_None"          )] None = 0,
			[Serialize("LinkMode_FirstLinkOrTag")] FirstLinkOrTag = 1,
			[Serialize("LinkMode_TagOnly"       )] TagOnly = 2,
		}
	}
}

