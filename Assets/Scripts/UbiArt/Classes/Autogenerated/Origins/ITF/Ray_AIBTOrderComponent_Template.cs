using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIBTOrderComponent_Template : CSerializable {
		[Serialize("type"         )] public BTAIORDER type;
		[Serialize("detectionArea")] public StringID detectionArea;
		[Serialize("removeOnExit" )] public bool removeOnExit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(type));
			SerializeField(s, nameof(detectionArea));
			SerializeField(s, nameof(removeOnExit));
		}
		public enum BTAIORDER {
			[Serialize("BTAIORDER_WAITFORPLAYER"       )] WAITFORPLAYER = 1,
			[Serialize("BTAIORDER_WAITFORLAST"         )] WAITFORLAST = 2,
			[Serialize("BTAIORDER_WAITWHILEACTORSALIVE")] WAITWHILEACTORSALIVE = 3,
			[Serialize("BTAIORDER_SETTARGETWAYPOINT"   )] SETTARGETWAYPOINT = 4,
			[Serialize("BTAIORDER_PEDESTAL"            )] PEDESTAL = 5,
			[Serialize("BTAIORDER_SETRESPAWNPOINT"     )] SETRESPAWNPOINT = 6,
			[Serialize("BTAIORDER_DETECTIONAREA"       )] DETECTIONAREA = 7,
			[Serialize("BTAIORDER_REMOVECURRENTORDER"  )] REMOVECURRENTORDER = 8,
		}
		public override uint? ClassCRC => 0x4BAC317D;
	}
}

