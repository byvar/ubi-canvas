using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Track : CSerializable {
		[Serialize("uint__0"                  )] public uint uint__0;
		[Serialize("CString__1"               )] public CString CString__1;
		[Serialize("Path__2"                  )] public Path Path__2;
		[Serialize("int__3"                   )] public int int__3;
		[Serialize("uint__4"                  )] public uint uint__4;
		[Serialize("CList<TrackPlayerData>__5")] public CList<TrackPlayerData> CList_TrackPlayerData__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
			SerializeField(s, nameof(CString__1));
			SerializeField(s, nameof(Path__2));
			SerializeField(s, nameof(int__3));
			SerializeField(s, nameof(uint__4));
			SerializeField(s, nameof(CList_TrackPlayerData__5));
		}
		public override uint? ClassCRC => 0xFF1D5160;
	}
}

