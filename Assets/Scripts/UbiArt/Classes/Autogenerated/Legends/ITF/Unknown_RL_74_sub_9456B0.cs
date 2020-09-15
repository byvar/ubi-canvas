using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_74_sub_9456B0 : MusicTreeNode_Template {
		public int playBlockOnce;
		public uint nbPartPlayed;
		public uint startingPart;
		public CList<StringID> partList;
		public int keepPositionBetweenPlay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playBlockOnce = s.Serialize<int>(playBlockOnce, name: "playBlockOnce");
			nbPartPlayed = s.Serialize<uint>(nbPartPlayed, name: "nbPartPlayed");
			startingPart = s.Serialize<uint>(startingPart, name: "startingPart");
			partList = s.SerializeObject<CList<StringID>>(partList, name: "partList");
			keepPositionBetweenPlay = s.Serialize<int>(keepPositionBetweenPlay, name: "keepPositionBetweenPlay");
		}
		public override uint? ClassCRC => 0x9AB69974;
	}
}

