using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class TestBranchComponent_Template : BezierBranchComponent_Template {
		[Serialize("width"      )] public float width;
		[Serialize("attachToEnd")] public bool attachToEnd;
		[Serialize("tileLength" )] public float tileLength;
		[Serialize("tileBones"  )] public CList<TestSpriteBone> tileBones;
		[Serialize("endLength"  )] public float endLength;
		[Serialize("endBones"   )] public CList<TestSpriteBone> endBones;
		[Serialize("drawDebug"  )] public bool drawDebug;
		[Serialize("debugMode"  )] public uint debugMode;
		[Serialize("tileBones"  )] public Placeholder tileBones;
		[Serialize("endBones"   )] public Placeholder endBones;
		[Serialize("drawDebug"  )] public int drawDebug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(width));
				SerializeField(s, nameof(attachToEnd), boolAsByte: true);
				SerializeField(s, nameof(tileLength));
				SerializeField(s, nameof(tileBones));
				SerializeField(s, nameof(endLength));
				SerializeField(s, nameof(endBones));
				SerializeField(s, nameof(drawDebug));
				SerializeField(s, nameof(debugMode));
			} else {
				SerializeField(s, nameof(width));
				SerializeField(s, nameof(attachToEnd));
				SerializeField(s, nameof(tileLength));
				SerializeField(s, nameof(tileBones));
				SerializeField(s, nameof(endLength));
				SerializeField(s, nameof(endBones));
				SerializeField(s, nameof(drawDebug));
				SerializeField(s, nameof(debugMode));
			}
		}
		public override uint? ClassCRC => 0xC5630DE5;
	}
}

