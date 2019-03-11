using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TestBranchComponent_Template : RO2_BezierBranchComponent_Template {
		[Serialize("width"      )] public float width;
		[Serialize("attachToEnd")] public bool attachToEnd;
		[Serialize("tileLength" )] public float tileLength;
		[Serialize("tileBones"  )] public CList<TestSpriteBone> tileBones;
		[Serialize("endLength"  )] public float endLength;
		[Serialize("endBones"   )] public CList<TestSpriteBone> endBones;
		[Serialize("drawDebug"  )] public bool drawDebug;
		[Serialize("debugMode"  )] public uint debugMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(width));
			SerializeField(s, nameof(attachToEnd));
			SerializeField(s, nameof(tileLength));
			SerializeField(s, nameof(tileBones));
			SerializeField(s, nameof(endLength));
			SerializeField(s, nameof(endBones));
			SerializeField(s, nameof(drawDebug));
			SerializeField(s, nameof(debugMode));
		}
		public override uint? ClassCRC => 0x8417CF08;
	}
}

