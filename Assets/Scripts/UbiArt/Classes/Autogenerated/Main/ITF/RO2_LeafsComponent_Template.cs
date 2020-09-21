using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LeafsComponent_Template : ActorComponent_Template {
		public CListO<StringID> standAnims;
		public CListO<StringID> explodeAnims;
		public float randomDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			standAnims = s.SerializeObject<CListO<StringID>>(standAnims, name: "standAnims");
			explodeAnims = s.SerializeObject<CListO<StringID>>(explodeAnims, name: "explodeAnims");
			randomDelay = s.Serialize<float>(randomDelay, name: "randomDelay");
		}
		public override uint? ClassCRC => 0xF375DAEE;
	}
}

