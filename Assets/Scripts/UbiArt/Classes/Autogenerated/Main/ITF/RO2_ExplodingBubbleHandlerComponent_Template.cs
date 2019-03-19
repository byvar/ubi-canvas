using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ExplodingBubbleHandlerComponent_Template : AnimMeshVertexComponent_Template {
		[Serialize("bubbleZ"            )] public float bubbleZ;
		[Serialize("bubbleScale"        )] public float bubbleScale;
		[Serialize("bubbleCount"        )] public uint bubbleCount;
		[Serialize("bubbleRadius"       )] public float bubbleRadius;
		[Serialize("bubbleInitAccel"    )] public float bubbleInitAccel;
		[Serialize("displayDebug"       )] public bool displayDebug;
		[Serialize("DRCdisplay"         )] public bool DRCdisplay;
		[Serialize("heartAppearRumbleID")] public StringID heartAppearRumbleID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bubbleZ));
			SerializeField(s, nameof(bubbleScale));
			SerializeField(s, nameof(bubbleCount));
			SerializeField(s, nameof(bubbleRadius));
			SerializeField(s, nameof(bubbleInitAccel));
			SerializeField(s, nameof(displayDebug));
			SerializeField(s, nameof(DRCdisplay));
			SerializeField(s, nameof(heartAppearRumbleID));
		}
		public override uint? ClassCRC => 0xC37619CF;
	}
}

