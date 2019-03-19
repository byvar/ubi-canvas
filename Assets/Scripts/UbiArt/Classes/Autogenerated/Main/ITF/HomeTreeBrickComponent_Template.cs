using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class HomeTreeBrickComponent_Template : ActorComponent_Template {
		[Serialize("editor_stepCount" )] public uint editor_stepCount;
		[Serialize("editor_minGrowth" )] public float editor_minGrowth;
		[Serialize("editor_brickSize" )] public Vector2 editor_brickSize;
		[Serialize("editor_trunkWidth")] public float editor_trunkWidth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(editor_stepCount));
			SerializeField(s, nameof(editor_minGrowth));
			SerializeField(s, nameof(editor_brickSize));
			SerializeField(s, nameof(editor_trunkWidth));
		}
		public override uint? ClassCRC => 0x86FD77D7;
	}
}

