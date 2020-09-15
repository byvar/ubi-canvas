using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_381_sub_AE81B0 : CSerializable {
		public float maxprojectiles;
		public Placeholder ProjectilesDescList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxprojectiles = s.Serialize<float>(maxprojectiles, name: "maxprojectiles");
			ProjectilesDescList = s.SerializeObject<Placeholder>(ProjectilesDescList, name: "ProjectilesDescList");
		}
		public override uint? ClassCRC => 0x546EFC39;
	}
}

