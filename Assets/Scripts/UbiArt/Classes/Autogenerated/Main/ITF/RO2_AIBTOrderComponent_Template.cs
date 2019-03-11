using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AIBTOrderComponent_Template : ActorComponent_Template {
		[Serialize("type"         )] public BTAIORDER type;
		[Serialize("detectionArea")] public StringID detectionArea;
		[Serialize("removeOnExit" )] public bool removeOnExit;
		[Serialize("type"         )] public Enum_type type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(detectionArea));
				SerializeField(s, nameof(removeOnExit));
			} else {
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(detectionArea));
				SerializeField(s, nameof(removeOnExit));
			}
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
		public enum Enum_type {
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
		}
		public override uint? ClassCRC => 0xE8290BAA;
	}
}

