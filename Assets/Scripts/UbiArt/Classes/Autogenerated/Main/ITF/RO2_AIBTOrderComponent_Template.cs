using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIBTOrderComponent_Template : ActorComponent_Template {
		public BTAIORDER type;
		public StringID detectionArea;
		public bool removeOnExit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			type = s.Serialize<BTAIORDER>(type, name: "type");
			detectionArea = s.SerializeObject<StringID>(detectionArea, name: "detectionArea");
			removeOnExit = s.Serialize<bool>(removeOnExit, name: "removeOnExit");
		}
		public enum BTAIORDER {
			[Serialize("BTAIORDER_WAITFORPLAYER"                    )] WAITFORPLAYER = 1,
			[Serialize("BTAIORDER_WAITFORLAST"                      )] WAITFORLAST = 2,
			[Serialize("BTAIORDER_WAITWHILEACTORSALIVE"             )] WAITWHILEACTORSALIVE = 3,
			[Serialize("BTAIORDER_SETTARGETWAYPOINT"                )] SETTARGETWAYPOINT = 4,
			[Serialize("BTAIORDER_PEDESTAL"                         )] PEDESTAL = 5,
			[Serialize("BTAIORDER_SETRESPAWNPOINT"                  )] SETRESPAWNPOINT = 6,
			[Serialize("BTAIORDER_DETECTIONAREA"                    )] DETECTIONAREA = 7,
			[Serialize("BTAIORDER_DANCE"                            )] DANCE = 8,
			[Serialize("BTAIORDER_WAITWHILEDARKCREATURESALIVE"      )] WAITWHILEDARKCREATURESALIVE = 9,
			[Serialize("BTAIORDER_WAITWHILELIGHTINGMUSHROOMHASFIRED")] WAITWHILELIGHTINGMUSHROOMHASFIRED = 10,
			[Serialize("BTAIORDER_WAITUNTILROPECUT"                 )] WAITUNTILROPECUT = 11,
			[Serialize("BTAIORDER_WAIT"                             )] WAIT = 12,
			[Serialize("BTAIORDER_REMOVECURRENTORDER"               )] REMOVECURRENTORDER = 13,
		}
		public override uint? ClassCRC => 0xE8290BAA;
	}
}

