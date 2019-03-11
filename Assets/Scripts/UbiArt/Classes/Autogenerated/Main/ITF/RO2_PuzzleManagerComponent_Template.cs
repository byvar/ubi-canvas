using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PuzzleManagerComponent_Template : ActorComponent_Template {
		[Serialize("debugDraw"  )] public bool debugDraw;
		[Serialize("caseLength" )] public float caseLength;
		[Serialize("caseHeight" )] public float caseHeight;
		[Serialize("lineCount"  )] public uint lineCount;
		[Serialize("columnCount")] public uint columnCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(debugDraw));
			SerializeField(s, nameof(caseLength));
			SerializeField(s, nameof(caseHeight));
			SerializeField(s, nameof(lineCount));
			SerializeField(s, nameof(columnCount));
		}
		public override uint? ClassCRC => 0xFE44A3D7;
	}
}

