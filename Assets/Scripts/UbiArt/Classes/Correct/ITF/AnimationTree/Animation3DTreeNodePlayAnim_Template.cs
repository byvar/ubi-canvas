using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class Animation3DTreeNodePlayAnim_Template : BlendTreeNodeTemplate<Animation3DTreeResult> {
		public StringID animationName;
		public ProceduralInputData proceduralInput;
		public ProceduralInputData proceduralPlayRate;
		public float weight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animationName = s.SerializeObject<StringID>(animationName, name: "animationName");
			proceduralInput = s.SerializeObject<ProceduralInputData>(proceduralInput, name: "proceduralInput");
			proceduralPlayRate = s.SerializeObject<ProceduralInputData>(proceduralPlayRate, name: "proceduralPlayRate");
			weight = s.Serialize<float>(weight, name: "weight");
		}
		public override uint? ClassCRC => 0x727BBB4E;
	}
}

