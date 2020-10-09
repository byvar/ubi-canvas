using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimTreeNodePlayAnim_Template : BlendTreeNodeTemplate<AnimTreeResult> {
		public StringID animationName;
		public bool usePatches;
		public bool useEvents;
		public ProceduralInputData proceduralInput;
		public ProceduralInputData proceduralPlayRate;
		public float weight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				animationName = s.SerializeObject<StringID>(animationName, name: "animationName");
				usePatches = s.Serialize<bool>(usePatches, name: "usePatches");
				useEvents = s.Serialize<bool>(useEvents, name: "useEvents");
				proceduralInput = s.SerializeObject<ProceduralInputData>(proceduralInput, name: "proceduralInput");
				proceduralPlayRate = s.SerializeObject<ProceduralInputData>(proceduralPlayRate, name: "proceduralPlayRate");
			} else {
				animationName = s.SerializeObject<StringID>(animationName, name: "animationName");
				usePatches = s.Serialize<bool>(usePatches, name: "usePatches");
				useEvents = s.Serialize<bool>(useEvents, name: "useEvents");
				proceduralInput = s.SerializeObject<ProceduralInputData>(proceduralInput, name: "proceduralInput");
				proceduralPlayRate = s.SerializeObject<ProceduralInputData>(proceduralPlayRate, name: "proceduralPlayRate");
				weight = s.Serialize<float>(weight, name: "weight");
			}
		}
		public override uint? ClassCRC => 0xEA217003;
	}
}

