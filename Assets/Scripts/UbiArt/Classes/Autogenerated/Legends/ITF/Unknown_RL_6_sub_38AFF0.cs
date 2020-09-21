using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_6_sub_38AFF0 : SoundCommand {
		public CListO<StringID> buslist;
		public float pitch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			buslist = s.SerializeObject<CListO<StringID>>(buslist, name: "buslist");
			pitch = s.Serialize<float>(pitch, name: "pitch");
		}
		public override uint? ClassCRC => 0xC5569A5C;
	}
}

