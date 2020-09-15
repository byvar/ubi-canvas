using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GameConfigExtended_Template : TemplateObj {
		public uint doSomething;
		public CList<PlayerIDInfo> playerIDInfo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			doSomething = s.Serialize<uint>(doSomething, name: "doSomething");
			playerIDInfo = s.SerializeObject<CList<PlayerIDInfo>>(playerIDInfo, name: "playerIDInfo");
		}
		public override uint? ClassCRC => 0x16EDCE2E;
	}
}

