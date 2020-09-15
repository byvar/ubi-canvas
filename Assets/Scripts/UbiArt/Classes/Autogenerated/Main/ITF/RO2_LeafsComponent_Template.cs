using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LeafsComponent_Template : ActorComponent_Template {
		public CList<StringID> standAnims;
		public CList<StringID> explodeAnims;
		public float randomDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			standAnims = s.SerializeObject<CList<StringID>>(standAnims, name: "standAnims");
			explodeAnims = s.SerializeObject<CList<StringID>>(explodeAnims, name: "explodeAnims");
			randomDelay = s.Serialize<float>(randomDelay, name: "randomDelay");
		}
		public override uint? ClassCRC => 0xF375DAEE;
	}
}

