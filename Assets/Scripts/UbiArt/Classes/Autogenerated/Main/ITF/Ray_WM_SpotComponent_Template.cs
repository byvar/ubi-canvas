using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WM_SpotComponent_Template : CSerializable {
		public StringID closedAnim;
		public StringID newAnim;
		public StringID cannotEnterAnim;
		public StringID openAnim;
		public StringID completedAnim;
		public StringID textNameID;
		public int isMid;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			closedAnim = s.SerializeObject<StringID>(closedAnim, name: "closedAnim");
			newAnim = s.SerializeObject<StringID>(newAnim, name: "newAnim");
			cannotEnterAnim = s.SerializeObject<StringID>(cannotEnterAnim, name: "cannotEnterAnim");
			openAnim = s.SerializeObject<StringID>(openAnim, name: "openAnim");
			completedAnim = s.SerializeObject<StringID>(completedAnim, name: "completedAnim");
			textNameID = s.SerializeObject<StringID>(textNameID, name: "textNameID");
			isMid = s.Serialize<int>(isMid, name: "isMid");
		}
		public override uint? ClassCRC => 0x2713EB21;
	}
}

