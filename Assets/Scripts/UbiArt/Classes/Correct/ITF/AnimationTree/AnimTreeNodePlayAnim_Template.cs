using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class AnimTreeNodePlayAnim_Template : BlendTreeNodeTemplate<AnimTreeResult> {
		[Serialize("animationName"         )] public StringID animationName;
		[Serialize("usePatches"            )] public bool usePatches;
		[Serialize("useEvents"             )] public bool useEvents;
		[Serialize("proceduralInput"       )] public ProceduralInputData proceduralInput;
		[Serialize("proceduralPlayRate"    )] public ProceduralInputData proceduralPlayRate;
		[Serialize("weight"                )] public float weight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(animationName));
				SerializeField(s, nameof(usePatches));
				SerializeField(s, nameof(useEvents));
				SerializeField(s, nameof(proceduralInput));
				SerializeField(s, nameof(proceduralPlayRate));
			} else {
				SerializeField(s, nameof(animationName));
				SerializeField(s, nameof(usePatches));
				SerializeField(s, nameof(useEvents));
				SerializeField(s, nameof(proceduralInput));
				SerializeField(s, nameof(proceduralPlayRate));
				SerializeField(s, nameof(weight));
			}
		}
		public override uint? ClassCRC => 0xEA217003;
	}
}

