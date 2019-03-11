using UnityEngine;

namespace UbiArt.ITF {
	public partial class GameConfigExtended_Template : TemplateObj {
		[Serialize("doSomething" )] public uint doSomething;
		[Serialize("playerIDInfo")] public CList<PlayerIDInfo> playerIDInfo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(doSomething));
			SerializeField(s, nameof(playerIDInfo));
		}
		public override uint? ClassCRC => 0x16EDCE2E;
	}
}

