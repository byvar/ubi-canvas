using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_381_sub_AE81B0 : CSerializable {
		[Serialize("maxprojectiles"     )] public float maxprojectiles;
		[Serialize("ProjectilesDescList")] public Placeholder ProjectilesDescList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maxprojectiles));
			SerializeField(s, nameof(ProjectilesDescList));
		}
		public override uint? ClassCRC => 0x546EFC39;
	}
}

