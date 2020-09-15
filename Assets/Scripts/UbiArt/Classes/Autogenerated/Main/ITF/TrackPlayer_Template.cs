using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class TrackPlayer_Template : CSerializable {
		public CList<string> CList_String__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			CList_String__0 = s.SerializeObject<CList<string>>(CList_String__0, name: "CList_String__0");
		}
		public override uint? ClassCRC => 0xED859FD5;
	}
}

