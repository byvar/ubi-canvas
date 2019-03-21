using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class TrackPlayer_Template : CSerializable {
		[Serialize("CList<String>__0")] public CList<string> CList_String__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CList_String__0));
		}
		public override uint? ClassCRC => 0xED859FD5;
	}
}

